using System;

namespace Auditing.Presentation.Controls
{
	public class TableEventArgs :EventArgs
	{
		private string _tableName = "";
		private string _result = "";

		public TableEventArgs(string tableName)
		{
			_tableName = tableName;
		}

		public string TableName
		{
			get { return _tableName; }
		}

		public string Result
		{
			get { return _result; }
			set { _result = value; }
		}
	}
}