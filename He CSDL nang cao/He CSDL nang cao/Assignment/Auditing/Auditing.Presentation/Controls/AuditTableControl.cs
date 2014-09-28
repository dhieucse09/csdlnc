using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Auditing.Presentation.Controls;
using Auditing.Presentation.Forms;
using Auditing.Business.Entities;

namespace Auditing.Presentation.Controls
{
	public partial class AuditTableControl : UserControl
	{
		#region Fields --------------------------------------------------------------------------------

		private int _minScriptHeight = 100;
		private int _minOutputHeight = 100;
		private string _searchString = "";

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public AuditTableControl()
		{
			InitializeComponent();
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

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

		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			btnSearch_Click(btnSearch, EventArgs.Empty);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			_searchString = txtSearch.Text;
			if (SearchTable != null)
			{
				SearchEventArgs<Table> eventArgs = new SearchEventArgs<Table>(_searchString);
				SearchTable(this, eventArgs);
				dataGridView.DataSource = eventArgs.Result;
			}
		}

		private void btnNewTable_Click(object sender, EventArgs e)
		{
			NewTableForm newTableForm = new NewTableForm();
			newTableForm.ExecuteScript += new EventHandler<ScriptEventArgs>(newTableForm_ExecuteScript);
			newTableForm.ShowDialog();
			btnSearch_Click(btnSearch, EventArgs.Empty);
		}

		private void newTableForm_ExecuteScript(object sender, ScriptEventArgs e)
		{
			if (NewTable != null)
			{
				NewTable(this, e);
			}
		}

		private void btnDeleteTable_Click(object sender, EventArgs e)
		{
			int selectedCellCount = dataGridView.GetCellCount(DataGridViewElementStates.Selected);
			if (selectedCellCount > 0)
			{
				for (int i = 0; i < selectedCellCount; i++)
				{
					//int indexToDo = dgvAuditTables.SelectedCells[i].RowIndex;
					//_presenterAdmin.DeleteSelectedTable(dgvAuditTables.Rows[indexToDo].Cells[0].Value.ToString(), dgvAuditTables.Rows[indexToDo].Cells[1].Value.ToString());
				}
			}
			else
			{
				MessageBox.Show("There is no table selected.", "Delete table", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnAuditTable_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedCells.Count > 0)
			{
				DataGridViewCell cell = dataGridView.SelectedCells[0];
				int rowIndex = cell.RowIndex;
				int columnIndex = cell.ColumnIndex;
				if (rowIndex != -1 && columnIndex != -1)
				{
					string owner = dataGridView[colOwner.Name, rowIndex].Value.ToString();
					string tableName = dataGridView[colTableName.Name, rowIndex].Value.ToString();

					AuditTableForm auditTableForm = new AuditTableForm(string.Format("{0}.{1}", owner, tableName));
					if (auditTableForm.ShowDialog() == DialogResult.OK && SetAuditTable != null)
					{
						SetAuditTable(this, auditTableForm.AuditTableInfo);
					}
				}
			}
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				string tableName = dataGridView[2, e.RowIndex].Value.ToString();
				if (e.ColumnIndex == 0 && MessageBox.Show("Are you sure you want to delete table " + tableName + "?", "Delete table " + tableName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && DeleteTable != null)
				{
					TableEventArgs eventArgs = new TableEventArgs(tableName);
					DeleteTable(this, eventArgs);
					btnSearch_Click(btnSearch, EventArgs.Empty);
					AppendOutput(eventArgs.Result);
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
			btnSearch_Click(btnSearch, EventArgs.Empty);
		}

		public new void Focus()
		{
			txtSearch.Select();
		}

		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler<AuditTableEventArgs> SetAuditTable = null;
		public event EventHandler<SearchEventArgs<Table>> SearchTable = null;
		public event EventHandler<ScriptEventArgs> NewTable = null;
		public event EventHandler<TableEventArgs> DeleteTable = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}