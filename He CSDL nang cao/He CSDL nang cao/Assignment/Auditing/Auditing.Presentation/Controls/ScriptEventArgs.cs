using System;
using System.Data;

namespace Auditing.Presentation.Controls
{
	public class ScriptEventArgs : EventArgs
	{
		private string _scriptString = "";
		private string _result = "";
		private DataSet _dataSet = null;

		public ScriptEventArgs() : this("") { }
		public ScriptEventArgs(string scriptString)
		{
			_scriptString = scriptString;
		}

		public string ScriptString
		{
			get { return _scriptString; }
		}

		public string Result
		{
			get { return _result; }
			set { _result = value; }
		}

		public DataSet DataSet
		{
			get { return _dataSet; }
			set { _dataSet = value; }
		}
	}
}