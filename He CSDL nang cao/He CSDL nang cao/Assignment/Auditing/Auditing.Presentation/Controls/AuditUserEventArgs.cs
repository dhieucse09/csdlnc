using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Auditing.Presentation.Controls
{
	public class AuditUserEventArgs : EventArgs
	{
		private string _userName = "";
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		private bool _selectChecked = false;
		public bool SelectChecked
		{
			get { return _selectChecked; }
			set { _selectChecked = value; }
		}

		private bool _insertChecked = false;
		public bool InsertChecked
		{
			get { return _insertChecked; }
			set { _insertChecked = value; }
		}

		private bool _updateChecked = false;
		public bool UpdateChecked
		{
			get { return _updateChecked; }
			set { _updateChecked = value; }
		}

		private bool _deleteChecked = false;
		public bool DeleteChecked
		{
			get { return _deleteChecked; }
			set { _deleteChecked = value; }
		}

		private bool _executeProcedureChecked = false;
		public bool ExecuteProcedureChecked
		{
			get { return _executeProcedureChecked; }
			set { _executeProcedureChecked = value; }
		}

		private bool _wheneverSuccessfulChecked = false;
		public bool WheneverSuccessfulChecked
		{
			get { return _wheneverSuccessfulChecked; }
			set { _wheneverSuccessfulChecked = value; }
		}

		private bool _wheneverUnsuccessfulChecked = false;
		public bool WheneverUnsuccessfulChecked
		{
			get { return _wheneverUnsuccessfulChecked; }
			set { _wheneverUnsuccessfulChecked = value; }
		}

		private bool _auditChecked = false;
		public bool AuditChecked
		{
			get { return _auditChecked; }
			set { _auditChecked = value; }
		}
	}
}