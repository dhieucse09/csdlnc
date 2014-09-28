using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Auditing.Presentation.Controls
{
	public class AuditTableEventArgs : EventArgs
	{
		private string _tableName = "";
		public string TableName
		{
			get { return _tableName; }
			set { _tableName = value; }
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

		private bool _alterChecked = false;
		public bool AlterChecked
		{
			get { return _alterChecked; }
			set { _alterChecked = value; }
		}

		private bool _grantChecked = false;
		public bool GrantChecked
		{
			get { return _grantChecked; }
			set { _grantChecked = value; }
		}

		private bool _byAccessChecked = false;
		public bool ByAccessChecked
		{
			get { return _byAccessChecked; }
			set { _byAccessChecked = value; }
		}

		private bool _bySessionChecked = false;
		public bool BySessionChecked
		{
			get { return _bySessionChecked; }
			set { _bySessionChecked = value; }
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