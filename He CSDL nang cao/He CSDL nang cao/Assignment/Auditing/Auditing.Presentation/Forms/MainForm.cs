using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Auditing.Business;
using Auditing.Business.Entities;
using Auditing.Presentation.Controls;
using System.Data;
using Auditing.Presentation.Properties;

namespace Auditing.Presentation.Forms
{
	public partial class MainForm : Form
	{
		#region Fields --------------------------------------------------------------------------------

		private string _formTitle;
		private BsAuditing _bsAuditing;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public MainForm()
		{
			InitializeComponent();

			_formTitle = this.Text;
			loginControl.Visible = true;
			loginControl.Focus();

#if DEBUG
			loginControl.IsAdmin = true;
#endif

			adminViewControl.SearchUsers += new EventHandler<SearchEventArgs<User>>(adminViewControl_SearchUsers);
			adminViewControl.SearchTable += new EventHandler<SearchEventArgs<Table>>(adminViewControl_SearchTable);
			adminViewControl.SearchAuditing += new EventHandler<SearchEventArgs<AuditInfo>>(adminViewControl_SearchAuditing);

			userViewControl.ListAllTables += new EventHandler<SearchEventArgs<string>>(userViewControl_ListAllTables);
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_bsAuditing != null)
			{
				_bsAuditing.Signout();
			}
		}

		private void userViewControl_ChangePassword(object sender, EventArgs e)
		{
			UserInfoForm userInfoForm = new UserInfoForm(loginControl.Username);
			if (userInfoForm.ShowDialog() == DialogResult.OK)
			{
				if (_bsAuditing.ChangePassword(userInfoForm.Username, userInfoForm.Password))
				{
					loginControl.Username = userInfoForm.Username;
					loginControl.Password = userInfoForm.Password;
				}
				else
				{
					MessageBox.Show("Change password has error.", _formTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private void loginControl_VisibleChanged(object sender, EventArgs e)
		{
			if (loginControl.Visible)
			{
				this.Text = _formTitle;
				this.WindowState = FormWindowState.Normal;
				this.FormBorderStyle = FormBorderStyle.Fixed3D;
				this.MinimumSize = new Size(300, 200);
				this.Size = new Size(300, 200);
				this.MinimizeBox = this.MaximizeBox = false;
			}
			else
			{
				this.FormBorderStyle = FormBorderStyle.Sizable;
				this.MinimumSize = new Size(500, 500);
				this.MinimizeBox = this.MaximizeBox = true;
			}
		}

		private void loginControl_Login(object sender, EventArgs e)
		{
			loginControl.Enabled = false;
			_bsAuditing = new BsAuditing(loginControl.DataSourceName);
			if (_bsAuditing.Signin(loginControl.Username, loginControl.Password))
			{
				loginControl.Enabled = true;
				loginControl.Visible = false;
				linkSignout.Visible = true;
				this.WindowState = FormWindowState.Maximized;

				Settings.Default.DataSourceName = loginControl.DataSourceName;
				Settings.Default.Username = loginControl.Username;
				Settings.Default.Password = CryptoLib.SymmetricEncrypt(loginControl.Password, Program.DataKey, Program.DataIV);
				Settings.Default.Save();

				if (loginControl.IsAdmin)
				{
					this.Text = _formTitle + ": admin " + loginControl.Username;
					userViewControl.Visible = false;
					userViewControl.Dock = DockStyle.None;
					adminViewControl.Visible = true;
					adminViewControl.Dock = DockStyle.Fill;

					adminViewControl.ResetView();
				}
				else
				{
					this.Text = _formTitle + ": " + loginControl.Username;
					adminViewControl.Visible = false;
					adminViewControl.Dock = DockStyle.None;
					userViewControl.Visible = true;
					userViewControl.Dock = DockStyle.Fill;
				}
			}
		}

		private void linkSignout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			userViewControl.Visible = false;
			userViewControl.Dock = DockStyle.None;
			adminViewControl.Visible = false;
			adminViewControl.Dock = DockStyle.None;
			loginControl.Visible = true;
			linkSignout.Visible = false;
		}

		// ------------------------------------------------------------------------

		private void adminViewControl_SearchUsers(object sender, SearchEventArgs<User> e)
		{
			e.Result = _bsAuditing.SearchUsers(e.SearchString);
		}

		private void adminViewControl_NewUser(object sender, UserEventArgs e)
		{
			e.Result = _bsAuditing.NewUser(e.Username, e.Password);
		}

		private void adminViewControl_AlterUser(object sender, UserEventArgs e)
		{
			e.Result = (_bsAuditing.ChangePassword(e.Username, e.Password) ? "Change password has been finished." : "Change password has error.");
		}

		private void adminViewControl_DeleteUser(object sender, UserEventArgs e)
		{
			_bsAuditing.DeleteUser(e.Username, 0);
		}

		private void adminViewControl_SetAuditUser(object sender, AuditUserEventArgs e)
		{
			_bsAuditing.SetAuditUser(e.UserName, e.SelectChecked, e.InsertChecked, e.UpdateChecked, e.DeleteChecked, e.ExecuteProcedureChecked,
				e.WheneverSuccessfulChecked, e.WheneverUnsuccessfulChecked, e.AuditChecked);
		}

		// ------------------------------------------------------------------------

		private void adminViewControl_SearchTable(object sender, SearchEventArgs<Table> e)
		{
			e.Result = _bsAuditing.SearchTables(loginControl.Username, e.SearchString);
		}

		private void adminViewControl_NewTable(object sender, ScriptEventArgs e)
		{
			string errorString = "";
			e.Result = (_bsAuditing.ExecuteNonQuery(e.ScriptString, out errorString) ? "Create new table." : "Error: " + errorString);
		}

		private void adminViewControl_DeleteTable(object sender, TableEventArgs e)
		{
			string errorString = "";
			e.Result = (_bsAuditing.DeleteTable(e.TableName, out errorString) ? "'" + e.TableName + "' has been deleted." : "Error: " + errorString);
		}

		private void adminViewControl_SetAuditTable(object sender, AuditTableEventArgs e)
		{
			_bsAuditing.SetAuditTable(e.TableName, e.SelectChecked, e.InsertChecked, e.UpdateChecked, e.DeleteChecked, e.AlterChecked, e.GrantChecked, e.ByAccessChecked, e.BySessionChecked, e.WheneverSuccessfulChecked, e.WheneverUnsuccessfulChecked, e.AuditChecked);
		}

		// ------------------------------------------------------------------------

		private void adminViewControl_SearchAuditing(object sender, SearchEventArgs<AuditInfo> e)
		{
			e.Result = _bsAuditing.SearchAuditing(e.SearchString);
		}

		private void adminViewControl_ExecuteScript(object sender, ScriptEventArgs e)
		{
			string result = "";
			_bsAuditing.ExecuteNonQuery(e.ScriptString, out result);
			e.Result = result;
		}

		// ------------------------------------------------------------------------

		private void userViewControl_ExecuteScript(object sender, ScriptEventArgs e)
		{
			string output = "";
			DataSet dataset;
			if (_bsAuditing.ExecuteQuery(e.ScriptString, out dataset) && dataset != null && dataset.Tables.Count > 0)
			{
				e.DataSet = dataset;
				e.Result = "Execute successful.";
			}
			else
			{
				_bsAuditing.ExecuteNonQuery(e.ScriptString, out output);
				e.Result = output;
			}
		}

		private void userViewControl_ListAllTables(object sender, SearchEventArgs<string> e)
		{
			e.Result = _bsAuditing.ListAllTables();
		}

		private void userViewControl_CreateSampleTable(object sender, ScriptEventArgs e)
		{
			string errorString = "";
			e.Result = (_bsAuditing.ExecuteNonQuery(e.ScriptString, out errorString) ? "Create sample table." : errorString);
		}

		private void userViewControl_DescribeTable(object sender, ScriptEventArgs e)
		{
			e.Result = _bsAuditing.DescribeTable(e.ScriptString);
		}

		private void userViewControl_DeleteTable(object sender, TableEventArgs e)
		{
			string errorString = "";
			e.Result = (_bsAuditing.DeleteTable(e.TableName, out errorString) ? "'" + e.TableName + "' has been deleted." : "Error: " + errorString);
		}

		private void userViewControl_SelectTable(object sender, ScriptEventArgs e)
		{
			DataSet dataset;
			string output = "";
			if (_bsAuditing.ExecuteQuery(e.ScriptString, out dataset))
			{
				e.DataSet = dataset;
				e.Result = "Select table successful.";
			}
			else
			{
				_bsAuditing.ExecuteNonQuery(e.ScriptString, out output);
				e.Result = output;
			}
		}

		private void userViewControl_InsertTable(object sender, ScriptEventArgs e)
		{
			string errorString = "";
			e.Result = (_bsAuditing.ExecuteNonQuery(e.ScriptString, out errorString) ? "Insert into table." : errorString);
		}

		private void userViewControl_UpdateTable(object sender, ScriptEventArgs e)
		{
			string errorString = "";
			e.Result = (_bsAuditing.ExecuteNonQuery(e.ScriptString, out errorString) ? "Update table." : errorString);
		}

		#endregion Private functions ------------------------------------------------------------------
	}
}