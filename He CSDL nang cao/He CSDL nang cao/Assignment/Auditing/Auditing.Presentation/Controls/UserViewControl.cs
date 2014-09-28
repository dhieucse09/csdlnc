using System;
using System.Drawing;
using System.Windows.Forms;
using Auditing.Business;
using Auditing.Presentation.Forms;

namespace Auditing.Presentation.Controls
{
	public partial class UserViewControl : UserControl
	{
		#region Fields --------------------------------------------------------------------------------
		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public UserViewControl()
		{
			InitializeComponent();

			manipulateTableControl.ListAllTables += new EventHandler<SearchEventArgs<string>>(manipulateTableControl_ListAllTables);
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void executeScriptControl_ExecuteScript(object sender, ScriptEventArgs e)
		{
			if (ExecuteScript != null)
			{
				ExecuteScript(this, e);
			}
		}

		private void manipulateTableControl_ListAllTables(object sender, SearchEventArgs<string> e)
		{
			if (ListAllTables != null)
			{
				ListAllTables(this, e);
			}
		}

		private void manipulateTableControl_CreateSampleTable(object sender, ScriptEventArgs e)
		{
			if (CreateSampleTable != null)
			{
				CreateSampleTable(this, e);
			}
		}

		private void manipulateTableControl_DescribeTable(object sender, ScriptEventArgs e)
		{
			if (DescribeTable != null)
			{
				DescribeTable(this, e);
			}
		}

		private void manipulateTableControl_DeleteTable(object sender, TableEventArgs e)
		{
			if (DeleteTable != null)
			{
				DeleteTable(this, e);
			}
		}

		private void manipulateTableControl_SelectTable(object sender, ScriptEventArgs e)
		{
			if (SelectTable != null)
			{
				SelectTable(this, e);
			}
		}

		private void manipulateTableControl_InsertTable(object sender, ScriptEventArgs e)
		{
			if (InsertTable != null)
			{
				InsertTable(this, e);
			}
		}

		private void manipulateTableControl_UpdateTable(object sender, ScriptEventArgs e)
		{
			if (UpdateTable != null)
			{
				UpdateTable(this, e);
			}
		}

		private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (ChangePassword != null)
			{
				ChangePassword(this, EventArgs.Empty);
			}
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------
		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler<ScriptEventArgs> ExecuteScript = null;

		public event EventHandler<SearchEventArgs<string>> ListAllTables = null;
		public event EventHandler<ScriptEventArgs> CreateSampleTable = null;
		public event EventHandler<ScriptEventArgs> DescribeTable = null;
		public event EventHandler<TableEventArgs> DeleteTable = null;
		public event EventHandler<ScriptEventArgs> SelectTable = null;
		public event EventHandler<ScriptEventArgs> InsertTable = null;
		public event EventHandler<ScriptEventArgs> UpdateTable = null;

		public event EventHandler ChangePassword = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}