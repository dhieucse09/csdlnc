using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Auditing.Business.Entities;
using Auditing.Presentation.Forms;

namespace Auditing.Presentation.Controls
{
	public partial class AuditUsersControl : UserControl
	{
		#region Fields --------------------------------------------------------------------------------

		private int _minScriptHeight = 100;
		private int _minOutputHeight = 100;
		private string _searchString = "";

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public AuditUsersControl()
		{
			InitializeComponent();
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void appendRtbOutput(string text)
		{
			rtbOutput.Text = (rtbOutput.Text == "" ? "" : "\n") + text;
		}

		private void searchUser()
		{
			if (SearchUser != null)
			{
				SearchEventArgs<User> eventArgs = new SearchEventArgs<User>(_searchString);
				SearchUser(this, eventArgs);
				dataGridView.DataSource = eventArgs.Result;
			}
		}

		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
			{
				btnSearch_Click(btnSearch, EventArgs.Empty);
			}
		}

		private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
		{
			if (_minScriptHeight + _minOutputHeight < splitContainer.Height)
			{
				if (splitContainer.SplitterDistance < _minScriptHeight)
				{
					splitContainer.SplitterDistance = _minScriptHeight;
				}
				if (splitContainer.SplitterDistance + _minOutputHeight > splitContainer.Height)
				{
					splitContainer.SplitterDistance = splitContainer.Height - _minOutputHeight;
				}
			}
			else
			{
				splitContainer.SplitterDistance = (int)(splitContainer.Height / 2);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (_searchString != txtSearch.Text)
			{
				_searchString = txtSearch.Text;
				searchUser();
			}
		}

		private void btnNewUser_Click(object sender, EventArgs e)
		{
			UserInfoForm userInfoForm = new UserInfoForm();
			if (userInfoForm.ShowDialog() == DialogResult.OK && NewUser != null)
			{
				UserEventArgs eventArgs = new UserEventArgs(userInfoForm.Username, userInfoForm.Password);
				NewUser(this, eventArgs);
				appendRtbOutput(eventArgs.Result);
				searchUser();
			}
		}

		private void btnAuditUser_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedCells.Count > 0)
			{
				DataGridViewCell cell = dataGridView.SelectedCells[0];
				int rowIndex = cell.RowIndex;
				int columnIndex = cell.ColumnIndex;
				if (rowIndex != -1 && columnIndex != -1)
				{
					string username = dataGridView[colUsername.Name, rowIndex].Value.ToString();
					AuditUserForm auditUserForm = new AuditUserForm(username);

					if (auditUserForm.ShowDialog() == DialogResult.OK && SetAuditUser!=null)
					{
						SetAuditUser(this, auditUserForm.UserInfo);
					}
				}
			}
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			int columnIndex = e.ColumnIndex;
			if (rowIndex != -1 && columnIndex != -1)
			{
				int userId = int.Parse(dataGridView[colUserId.Name, rowIndex].Value.ToString());
				string username = dataGridView[colUsername.Name, rowIndex].Value.ToString();
				string password = dataGridView[colPassword.Name, rowIndex].Value.ToString();

				if (e.ColumnIndex == colAlterUser.Index)
				{
					UserInfoForm userInfoForm = new UserInfoForm(username);
					if (userInfoForm.ShowDialog() == DialogResult.OK && AlterUser != null)
					{
						UserEventArgs eventArgs = new UserEventArgs(userInfoForm.Username, userInfoForm.Password);
						AlterUser(this, eventArgs);
						searchUser();
						appendRtbOutput(username + " has changed password.");
					}
				}
				else if (e.ColumnIndex == colDeleteUser.Index)
				{
					if (MessageBox.Show("Are you sure you want to delete user " + username + "?", "Delete user " + username, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && DeleteUser != null)
					{
						UserEventArgs eventArgs = new UserEventArgs(userId, username.ToUpper(), "");
						DeleteUser(this, eventArgs);
						searchUser();
						appendRtbOutput(username + " has been deleted.");
					}
				}
			}
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		[Browsable(true), DefaultValue(100)]
		public int MinScriptHeight
		{
			get { return _minScriptHeight; }
			set { _minScriptHeight = value; }
		}

		[Browsable(true), DefaultValue(100)]
		public int MinOutputHeight
		{
			get { return _minOutputHeight; }
			set { _minOutputHeight = value; }
		}

		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public void AppendOutput(string message)
		{
			rtbOutput.Text += (rtbOutput.Text == "" ? "" : "\n") + message;
		}

		public void ResetView()
		{
			_searchString = "";
			txtSearch.Text = "";
			searchUser();
		}

		public new void Focus()
		{
			txtSearch.Select();
		}

		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler<SearchEventArgs<User>> SearchUser = null;
		public event EventHandler<UserEventArgs> NewUser = null;
		public event EventHandler<UserEventArgs> AlterUser = null;
		public event EventHandler<UserEventArgs> DeleteUser = null;
		public event EventHandler<AuditUserEventArgs> SetAuditUser = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}