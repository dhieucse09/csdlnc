using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Auditing.Business.Entities;
using Auditing.Presentation.Controls;

namespace Auditing.Presentation.Forms
{
	public partial class AuditTableForm : Form
	{
		#region Fields --------------------------------------------------------------------------------

		private AuditTableEventArgs _auditTableEventArgs = new AuditTableEventArgs();

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------
		
		public AuditTableForm(string tableName)
		{
			InitializeComponent();

			_auditTableEventArgs.TableName = tableName;
			DialogResult = DialogResult.Cancel;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void btnSave_Click(object sender, EventArgs e)
		{
			_auditTableEventArgs.SelectChecked = cbxStatementSelect.Checked;
			_auditTableEventArgs.InsertChecked = cbxStatementInsert.Checked;
			_auditTableEventArgs.UpdateChecked = cbxStatementUpdate.Checked;
			_auditTableEventArgs.DeleteChecked = cbxStatementDelete.Checked;
			_auditTableEventArgs.AlterChecked = cbxStatementAlter.Checked;
			_auditTableEventArgs.GrantChecked = cbxStatementGrant.Checked;

			_auditTableEventArgs.ByAccessChecked = rbtByAccess.Checked;
			_auditTableEventArgs.BySessionChecked = rbtBySession.Checked;

			_auditTableEventArgs.WheneverSuccessfulChecked = cbxWheneverSuccessful.Checked;
			_auditTableEventArgs.WheneverUnsuccessfulChecked = cbxWheneverUnsuccessful.Checked;

			_auditTableEventArgs.AuditChecked = cbxAudit.Checked;
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public AuditTableEventArgs AuditTableInfo
		{
			get { return _auditTableEventArgs; }
		}

		#endregion Properties -------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------
		#endregion Events -----------------------------------------------------------------------------
	}
}