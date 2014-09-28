using System;
using System.Collections.Generic;

namespace Auditing.Presentation.Controls
{
	public class SearchEventArgs<T> : EventArgs
	{
		private string _searchString = "";
		private List<T> _result = new List<T>();

		public SearchEventArgs() : this("") { }
		public SearchEventArgs(string searchString)
		{
			_searchString = searchString;
		}

		public string SearchString
		{
			get { return _searchString; }
		}

		public List<T> Result
		{
			get { return _result; }
			set { _result = value; }
		}
	}
}