using System;
using System.Windows.Forms;
using System.Text;

namespace Auditing.Presentation.Controls
{
	public partial class AuditOtherControl : UserControl
	{
		#region Fields --------------------------------------------------------------------------------

		private const string AuditAllQueryString = "Audit all";
		private const string NoAuditAllQueryString = "Noaudit all";

		private const string AuditAllPrivilegesQueryString = "Audit all privileges";
		private const string NoAuditAllPrivilegesQueryString = "Noaudit all privileges";

		private const string AuditDirectoryQueryString = "Audit directory";
		private const string NoAuditDirectoryQueryString = "Noaudit directory";
		private const string AuditCreateAnyDirectoryQueryString = "Audit create any directory";
		private const string NoauditCreateAnyDirectoryQueryString = "Noaudit create any directory";

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public AuditOtherControl()
		{
			InitializeComponent();
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void executeQueryString(string queryString)
		{
			if (ExecuteScript != null)
			{
				ScriptEventArgs eventArgs = new ScriptEventArgs(queryString);
				ExecuteScript(this, eventArgs);
				MessageBox.Show(eventArgs.Result, "Audit other", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnAuditAll_Click(object sender, EventArgs e)
		{
			executeQueryString(AuditAllQueryString);
		}
		private void btnNoAuditAll_Click(object sender, EventArgs e)
		{
			executeQueryString(NoAuditAllQueryString);
		}

		private void btnAuditRole_Click(object sender, EventArgs e)
		{
			if (cbxWheneverSuccessful)
				executeQueryString("Audit role whenever successful");
			else if (cbxWheneverNotSuccessful)
				executeQueryString("Audit role whenever not successful");
			else
				executeQueryString("Audit role");
		}

		private void btnAuditAllPrivileges_Click(object sender, EventArgs e)
		{
			executeQueryString(AuditAllPrivilegesQueryString);
		}
		private void btnNoAuditAllPrivileges_Click(object sender, EventArgs e)
		{
			executeQueryString(NoAuditAllPrivilegesQueryString);
		}

		private void btnAuditDirectory_Click(object sender, EventArgs e)
		{
			executeQueryString(AuditDirectoryQueryString);
		}
		private void btnNoAuditDirectory_Click(object sender, EventArgs e)
		{
			executeQueryString(NoAuditDirectoryQueryString);
		}
		private void btnAuditCreateAnyDirectory_Click(object sender, EventArgs e)
		{
			executeQueryString(AuditCreateAnyDirectoryQueryString);
		}
		private void btnNoauditCreateAnyDirectory_Click(object sender, EventArgs e)
		{
			executeQueryString(NoauditCreateAnyDirectoryQueryString);
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------
		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------
		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler<ScriptEventArgs> ExecuteScript = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}