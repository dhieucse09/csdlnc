using System;
using System.Drawing;
using System.Windows.Forms;
using Auditing.Presentation.Forms;

namespace Auditing.Presentation.Controls
{
	public partial class ManipulateTableControl : UserControl
	{
		#region Fields --------------------------------------------------------------------------------
		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public ManipulateTableControl()
		{
			InitializeComponent();

			cbxTable.LostFocus += new EventHandler(cbxTable_LostFocus);
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void cbxTable_LostFocus(object sender, EventArgs e)
		{
			if (cbxTable.Items.Count > 0)
			{
				int index = cbxTable.FindString(cbxTable.Text);
				cbxTable.SelectedIndex = (index == -1 ? 0 : index);
				txtSelectFrom.Text = txtInsertTable.Text = txtUpdateTable.Text = cbxTable.Text;
			}
			else
			{
				cbxTable.Text = "";
			}
		}

		private void cbxTable_TextChanged(object sender, EventArgs e)
		{
			bool buttonEnabled = (cbxTable.Text != "");
			btnDescribeTable.Enabled = buttonEnabled;
			btnDeleteTable.Enabled = buttonEnabled;
		}

		private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTable.SelectedIndex != -1)
			{
				txtSelectFrom.Text = txtInsertTable.Text = txtUpdateTable.Text = cbxTable.Text;
			}
		}

		private void txtSelect_TextChanged(object sender, EventArgs e)
		{
			btnSelect.Enabled = txtSelectColumns.Text != "" && txtSelectFrom.Text != "";
		}

		private void txtInsert_TextChanged(object sender, EventArgs e)
		{
			btnInsertInto.Enabled = txtInsertTable.Text != "" && txtInsertValues.Text != "";
		}

		private void txtUpdate_TextChanged(object sender, EventArgs e)
		{
			btnUpdate.Enabled = txtUpdateTable.Text != "" && txtUpdateSet.Text != "" && txtUpdateWhere.Text != "";
		}

		private void btnListTables_Click(object sender, EventArgs e)
		{
			if (ListAllTables != null)
			{
				SearchEventArgs<string> eventArgs = new SearchEventArgs<string>();
				ListAllTables(this, eventArgs);
				cbxTable.DataSource = eventArgs.Result;

				bool enabled = (cbxTable.Items.Count > 0);
				btnDescribeTable.Enabled = btnDeleteTable.Enabled = groupBoxSelect.Enabled = groupBoxInsert.Enabled = groupBoxUpdate.Enabled = enabled;
				txtSelectColumns.Text = "*";
				txtSelectWhere.Text = "";
				txtInsertValues.Text = "";
				txtUpdateSet.Text = txtUpdateWhere.Text = "";
			}
		}

		private void btnCreateSampleTable_Click(object sender, EventArgs e)
		{
			if (CreateSampleTable != null)
			{
				string queryString = "CREATE TABLE table1 (num number, str varchar2(100))";
				ScriptEventArgs eventArgs = new ScriptEventArgs(queryString);
				CreateSampleTable(this, eventArgs);
				AppendOutput(eventArgs.Result);
			}
		}

		private void btnDescribeTable_Click(object sender, EventArgs e)
		{
			if (btnDescribeTable.Enabled && DescribeTable != null)
			{
				ScriptEventArgs eventArgs = new ScriptEventArgs(cbxTable.Text);
				DescribeTable(this, eventArgs);
				AppendOutput(eventArgs.Result);
			}
		}

		private void btnDeleteTable_Click(object sender, EventArgs e)
		{
			if (btnDeleteTable.Enabled && DeleteTable != null)
			{
				TableEventArgs eventArgs = new TableEventArgs(cbxTable.Text);
				DeleteTable(this, eventArgs);
				AppendOutput(eventArgs.Result);
			}
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			if (btnSelect.Enabled && SelectTable != null)
			{
				string formatString = (txtSelectWhere.Text.Trim() != "" ? "Select {0} From {1} Where {2}" : "Select {0} From {1}");
				string queryString = string.Format(formatString, txtSelectColumns.Text, txtSelectFrom.Text, txtSelectWhere.Text);
				ScriptEventArgs EventArgs = new ScriptEventArgs(queryString);
				SelectTable(this, EventArgs);
				AppendOutput(EventArgs.Result);
				if (EventArgs.DataSet != null && EventArgs.DataSet.Tables.Count > 0)
				{
					GridViewForm gridViewForm = new GridViewForm(queryString, EventArgs.DataSet);
					gridViewForm.ShowDialog();
				}
			}
		}

		private void btnInsertInto_Click(object sender, EventArgs e)
		{
			if (btnInsertInto.Enabled && InsertTable != null)
			{
				string queryString = string.Format("INSERT INTO {0} VALUES ({1})", txtInsertTable.Text, txtInsertValues.Text);
				ScriptEventArgs eventArgs = new ScriptEventArgs(queryString);
				InsertTable(this, eventArgs);
				AppendOutput(eventArgs.Result);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (btnUpdate.Enabled && UpdateTable != null)
			{
				string queryString = string.Format("UPDATE {0} SET {1} WHERE {2}", txtUpdateTable.Text, txtUpdateSet.Text, txtUpdateWhere.Text);
				ScriptEventArgs eventArgs = new ScriptEventArgs(queryString);
				UpdateTable(this, eventArgs);
				AppendOutput(eventArgs.Result);
			}
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------
		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public void UpdateView()
		{
			cbxTable.Items.Clear();
			txtSelectColumns.Text = "*"; txtSelectFrom.Text = txtSelectWhere.Text = "";
			txtInsertTable.Text = txtInsertValues.Text = "";
			txtUpdateTable.Text = txtUpdateSet.Text = txtUpdateWhere.Text = "";
			btnDescribeTable.Enabled = btnDeleteTable.Enabled = btnSelect.Enabled = btnInsertInto.Enabled = btnUpdate.Enabled = false;
			groupBoxSelect.Enabled = groupBoxInsert.Enabled = groupBoxUpdate.Enabled = false;
		}

		public void AppendOutput(string text)
		{
			rtbOutput.Text += (rtbOutput.Text == "" ? text : "\n" + text);
		}

		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler<SearchEventArgs<string>> ListAllTables = null;
		public event EventHandler<ScriptEventArgs> CreateSampleTable = null;
		public event EventHandler<ScriptEventArgs> DescribeTable = null;
		public event EventHandler<TableEventArgs> DeleteTable = null;
		public event EventHandler<ScriptEventArgs> SelectTable = null;
		public event EventHandler<ScriptEventArgs> InsertTable = null;
		public event EventHandler<ScriptEventArgs> UpdateTable = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}