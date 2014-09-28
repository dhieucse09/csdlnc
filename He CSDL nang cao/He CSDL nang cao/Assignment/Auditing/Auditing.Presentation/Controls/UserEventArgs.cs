using System;

namespace Auditing.Presentation.Controls
{
	public class UserEventArgs : EventArgs
	{
		private int _userId = 0;
		private string _username = "";
		private string _password = "";
		private string _result = "";

		public UserEventArgs(int userId, string username, string password)
		{
			_userId = userId;
			_username = username;
			_password = password;
		}
		public UserEventArgs(string username, string password) : this(-1, username, password) { }

		public int UserId
		{
			get { return _userId; }
			set { _userId = value; }
		}

		public string Username
		{
			get { return _username; }
		}

		public string Password
		{
			get { return _password; }
		}

		public string Result
		{
			get { return _result; }
			set { _result = value; }
		}
	}
}