namespace Auditing.Business.Entities
{
	public class User
	{
		#region Fields --------------------------------------------------------------------------------
		
		private int _userId;
		private string _username;
		private string _password;
		private int _isAuditPassword;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public User(int userId, string userName, string password)
		{
			_userId = userId;
			_username = userName;
			_password = password;
		}
		public User(string userName, string password, int isAuditPassword)
		{
			_username = userName;
			_password = password;
			_isAuditPassword = isAuditPassword;
		}

		public override string ToString()
		{
			return _username;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public int UserId
		{
			get { return _userId; }
			set { _userId = value; }
		}

		public string UserName
		{
			get { return _username; }
			set { _username = value; }
		}

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		public int IsAuditPassword
		{
			//get { return _isAuditPassword; }
			set { _isAuditPassword = value; }
		}

		#endregion Properties -------------------------------------------------------------------------
	}
}