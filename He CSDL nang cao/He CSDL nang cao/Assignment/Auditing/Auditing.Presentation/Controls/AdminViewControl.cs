using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Auditing.Business;
using Auditing.Business.Entities;

namespace Auditing.Presentation.Controls
{
	public partial class AdminViewControl : UserControl
	{
		#region Constructors --------------------------------------------------------------------------

		public AdminViewControl()
		{
			InitializeComponent();
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			tabControl.SelectedTab.Controls[0].Focus();
		}

		// ------------------------------------------------------------------------

		private void auditUsersControl_SearchUser(object sender, SearchEventArgs<User> e)
		{
			if (SearchUsers != null)
			{
				SearchUsers(this, e);
			}
		}

		private void auditUsersControl_NewUser(object sender, UserEventArgs e)
		{
			if (NewUser != null)
			{
				NewUser(this, e);
			}
		}

		private void auditUsersControl_DeleteUser(object sender, UserEventArgs e)
		{
			if (DeleteUser != null)
			{
				DeleteUser(this, e);
			}
		}

		private void auditUsersControl_AlterUser(object sender, UserEventArgs e)
		{
			if (AlterUser != null)
			{
				AlterUser(this, e);
			}
		}

		private void auditUsersControl_SetAuditUser(object sender, AuditUserEventArgs e)
		{
			if (SetAuditUser != null)
			{
				SetAuditUser(this, e);
			}
		}

		// ------------------------------------------------------------------------

		private void auditTableControl_SearchTable(object sender, SearchEventArgs<Table> e)
		{
			if (SearchTable != null)
			{
				SearchTable(this, e);
			}
		}

		private void auditTableControl_NewTable(object sender, ScriptEventArgs e)
		{
			if (NewTable != null)
			{
				NewTable(this, e);
			}
		}

		private void auditTableControl_DeleteTable(object sender, TableEventArgs e)
		{
			if (DeleteTable != null)
			{
				DeleteTable(this, e);
			}
		}

		private void auditTableControl_SetAuditTable(object sender, AuditTableEventArgs e)
		{
			if (SetAuditTable != null)
			{
				SetAuditTable(this, e);
			}
		}

		// ------------------------------------------------------------------------

		private void viewAuditingControl_SearchAuditing(object sender, SearchEventArgs<AuditInfo> e)
		{
			if (SearchAuditing != null)
			{
				SearchAuditing(this, e);
			}
		}

		private void auditOtherControl_ExecuteScript(object sender, ScriptEventArgs e)
		{
			if (ExecuteScript != null)
			{
				ExecuteScript(this, e);
			}
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public void ResetView()
		{
			auditUsersControl.ResetView();
			auditTableControl.ResetView();
			viewAuditingControl.UpdateView();

			tabControl.SelectedTab = tabPageAuditUsers;
			auditUsersControl.Focus();
		}

		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler<SearchEventArgs<User>> SearchUsers = null;
		public event EventHandler<UserEventArgs> NewUser = null;
		public event EventHandler<UserEventArgs> AlterUser = null;
		public event EventHandler<UserEventArgs> DeleteUser = null;
		public event EventHandler<AuditUserEventArgs> SetAuditUser = null;

		public event EventHandler<SearchEventArgs<Table>> SearchTable = null;
		public event EventHandler<ScriptEventArgs> NewTable = null;
		public event EventHandler<TableEventArgs> DeleteTable = null;
		public event EventHandler<AuditTableEventArgs> SetAuditTable = null;

		public event EventHandler<SearchEventArgs<AuditInfo>> SearchAuditing = null;

		public event EventHandler<ScriptEventArgs> ExecuteScript = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}