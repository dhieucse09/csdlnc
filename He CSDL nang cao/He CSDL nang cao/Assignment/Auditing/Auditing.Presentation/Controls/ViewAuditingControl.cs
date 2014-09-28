using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using Auditing.Business.Entities;

namespace Auditing.Presentation.Controls
{
	public partial class ViewAuditingControl : UserControl
	{
		#region Fields --------------------------------------------------------------------------------
		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public ViewAuditingControl()
		{
			InitializeComponent();
			this.Dock = DockStyle.Fill;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearch_Click(btnSearch, EventArgs.Empty);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (SearchAuditing != null)
			{
				SearchEventArgs<AuditInfo> eventArgs = new SearchEventArgs<AuditInfo>(txtSearch.Text);
				SearchAuditing(this, eventArgs);
				dataGridView.DataSource = eventArgs.Result;
			}
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public void UpdateView()
		{
			btnSearch_Click(btnSearch, EventArgs.Empty);
		}

		public new void Focus()
		{
			txtSearch.Select();
		}

		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler<SearchEventArgs<AuditInfo>> SearchAuditing = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}