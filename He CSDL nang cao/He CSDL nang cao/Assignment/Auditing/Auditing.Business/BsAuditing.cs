using System;
using System.Collections.Generic;
using System.Data;
using Auditing.Data;
using Auditing.Business.Entities;

namespace Auditing.Business
{
	public class BsAuditing
	{
		#region Fields --------------------------------------------------------------------------------

		private const string DefaultServer = "asis-founder";

		private string _server = "";
		private bool _isSignin = false;

		private OracleServices _oracleServices = null;
		private UserServices _userServices = null;
		private TableServices _tableServices = null;
		private AuditingServices _auditingServices = null;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public BsAuditing() : this(DefaultServer) { }
		public BsAuditing(string server)
		{
			_server = server;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------
		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public OracleServices OracleServices
		{
			get { return _oracleServices; }
		}

		#endregion Properties -------------------------------------------------------------------------


		#region Admin's Methods -----------------------------------------------------------------------

		public bool Signin(string username, string password)
		{
			_oracleServices = new OracleServices(_server);
			_userServices = new UserServices(_oracleServices);
			_tableServices = new TableServices(_oracleServices);
			_auditingServices = new AuditingServices(_oracleServices);

			_isSignin = _oracleServices.OpenConnection(username, password);
			return _isSignin;
		}

		public void Signout()
		{
			if (_isSignin)
			{
				_oracleServices.CloseConnection();
				_isSignin = false;
			}
		}

		public bool ExecuteNonQuery(string queryString, out string errorString)
		{
			return _oracleServices.ExecuteNonQuery(queryString, out errorString);
		}

		public bool ExecuteQuery(string queryString, out DataSet dataset)
		{
			return _oracleServices.ExecuteQuery(queryString, out dataset);
		}

		// ------------------------------------------------------------------------

		public string NewUser(string username, string password)
		{
			return _userServices.NewUser(username, password);
		}

		public bool DeleteUser(string username, int option)
		{
			return _userServices.DeleteUser(username, option);
		}

		public bool ChangePassword(string username, string password)
		{
			return _userServices.AlterUser(username, password);
		}

		public List<User> SearchUsers(string searchString)
		{
			List<User> result = new List<User>();
			DataSet dataset = _userServices.SearchUsers(searchString);
			if (dataset.Tables.Count > 0)
			{
				DataTable table = dataset.Tables[0];
				for (int i = 0, n = table.Rows.Count; i < n; i++)
				{
					int userId = int.Parse(table.Rows[i][0].ToString());
					string username = table.Rows[i][1].ToString();
					string password = table.Rows[i][2].ToString();
					result.Add(new User(userId, username, password));
				}
			}
			return result;
		}

		public bool SetAuditUser(string username, bool selectChecked, bool insertChecked, bool updateChecked, bool deleteChecked, bool executeProcedureChecked,
			bool wheneverSuccessfulChecked, bool wheneverUnsuccessfulChecked, bool auditChecked)
		{
			return _userServices.SetAuditUser(username, selectChecked, insertChecked, updateChecked, deleteChecked, executeProcedureChecked, wheneverSuccessfulChecked, wheneverUnsuccessfulChecked, auditChecked);
		}

		// ------------------------------------------------------------------------

		public List<Table> SearchTables(string owner, string searchString)
		{
			List<Table> result = new List<Table>();
			DataSet dataset = _tableServices.SearchTables(owner.ToUpper(), searchString);
			if (dataset.Tables.Count > 0)
			{
				DataTable table = dataset.Tables[0];
				for (int i = 0, n = table.Rows.Count; i < n; i++)
				{
					result.Add(new Table(table.Rows[i][0].ToString(), table.Rows[i][1].ToString()));
				}
			}
			return result;
		}

		public bool DeleteTable(string tableName, out string errorString)
		{
			return _tableServices.DeleteTable(tableName.ToUpper(), out errorString);
		}

		public bool SetAuditTable(string tableName, bool selectChecked, bool insertChecked, bool updateChecked, bool deleteChecked, bool alterChecked, bool grantChecked,
			bool byAccessChecked, bool bySessionChecked, bool wheneverSuccessfulChecked, bool wheneverUnsuccessfulChecked,
			bool auditChecked)
		{
			return _tableServices.SetAuditTable(tableName, selectChecked, insertChecked, updateChecked, deleteChecked, alterChecked, grantChecked, byAccessChecked, bySessionChecked, wheneverSuccessfulChecked, wheneverUnsuccessfulChecked, auditChecked);
		}

		// ------------------------------------------------------------------------

		public List<AuditInfo> SearchAuditing(string searchString)
		{
			List<AuditInfo> result = new List<AuditInfo>();
			DataSet dataset = _auditingServices.SearchAuditing(searchString);
			if (dataset.Tables.Count > 0)
			{
				DataTable table = dataset.Tables[0];
				for (int i = 0, n = table.Rows.Count; i < n; i++)
				{
					// USERNAME, TIMESTAMP, OWNER, OBJ_NAME, ACTION_NAME, OBJ_PRIVILEGE, SYS_PRIVILEGE
					DataRow row = table.Rows[i];
					string username = row["USERNAME"].ToString();
					DateTime timeStamp = DateTime.Parse(row["TIMESTAMP"].ToString());
					string owner = row["OWNER"].ToString();
					string objName = row["OBJ_NAME"].ToString();
					string action = row["ACTION_NAME"].ToString();
					string objPrivilege = row["OBJ_PRIVILEGE"].ToString();
					string sysPrivilege = row["SYS_PRIVILEGE"].ToString();

					result.Add(new AuditInfo(username, timeStamp, owner, objName, action, objPrivilege, sysPrivilege));
				}
			}

			return result;
		}

		#endregion Admin's Methods --------------------------------------------------------------------


		#region User's methods ------------------------------------------------------------------------

		public List<string> ListAllTables()
		{
			List<string> result = new List<string>();
			DataSet dataset = _tableServices.ListAllTables();
			if (dataset.Tables.Count > 0)
			{
				DataTable table = dataset.Tables[0];
				for (int i = 0, n = table.Rows.Count; i < n; i++)
				{
					result.Add(table.Rows[i][0].ToString());
				}
			}
			return result;
		}

		public string DescribeTable(string tableName)
		{
			return _tableServices.DescribeTable(tableName);
		}

		#endregion User's methods ---------------------------------------------------------------------
	}
}