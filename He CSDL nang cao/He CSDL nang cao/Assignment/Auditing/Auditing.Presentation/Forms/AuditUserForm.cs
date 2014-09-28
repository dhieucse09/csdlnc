using System;
using System.Drawing;
using System.Windows.Forms;
using Auditing.Presentation.Controls;
using Auditing.Business.Entities;

namespace Auditing.Presentation.Forms
{
	public partial class AuditUserForm : Form
	{
		#region Fields --------------------------------------------------------------------------------

		private AuditUserEventArgs _userInfo = new AuditUserEventArgs();

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public AuditUserForm(string username)
		{
			InitializeComponent();

			_userInfo.UserName = username;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void btnSave_Click(object sender, EventArgs e)
		{
			_userInfo.SelectChecked = cbxStatementSelect.Checked;
			_userInfo.InsertChecked = cbxStatementInsert.Checked;
			_userInfo.UpdateChecked = cbxStatementUpdate.Checked;
			_userInfo.DeleteChecked = cbxStatementDelete.Checked;
			_userInfo.ExecuteProcedureChecked = cbxExecuteProcedure.Checked;

			_userInfo.WheneverSuccessfulChecked = cbxWheneverSuccessful.Checked;
			_userInfo.WheneverUnsuccessfulChecked = cbxWheneverUnsuccessful.Checked;

			_userInfo.AuditChecked = cbxAudit.Checked;
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public AuditUserEventArgs UserInfo
		{
			get { return _userInfo; }
		}

		#endregion Properties -------------------------------------------------------------------------
	}
}