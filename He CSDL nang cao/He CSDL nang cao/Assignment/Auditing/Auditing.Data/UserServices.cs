using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;

namespace Auditing.Data
{
	public class UserServices
	{
		#region Fields --------------------------------------------------------------------------------

		private const string NewUserQueryString = "CREATE USER {0} identified by {1}; GRANT CREATE SESSION, CREATE TABLE TO {2}; ALTER USER {2} QUOTA 100M ON USERS;"; // username, password, username.ToUpper()

		private const string AlterUserQueryString = "ALTER USER {0} IDENTIFIED BY {1}"; // username, newPassword

		private const string DeleteUserQuery0 = "DROP USER {0}"; // username
		private const string DeleteUserQuery1 = "DROP USER {0} CASCADE"; // username

		private const string IsAuditUserQuery = "SELECT isAuditPassword FROM system.AuditingUsers WHERE username = '{0}'"; // username

		private const string SetAuditWhenChangePasswordQuery = "UPDATE AuditingUsers SET isauditpassword = '{0}' WHERE username = '{1}'"; // option, username

		private const string InsertAuditUserQuery = "INSERT INTO system.AuditingUsers VALUES ('{0}', '{1}', '{2}')"; // username, password, isAuditPassword

		private const string SearchUserQuerystring = "SELECT USER_ID, USERNAME, PASSWORD FROM dba_users WHERE username LIKE '%{0}%'"; // searchstring

		private OracleServices _oracleServices = null;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public UserServices(OracleServices oracleServices)
		{
			_oracleServices = oracleServices;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------
		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------
		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public string NewUser(string username, string password)
		{
			string result = "";
			string queryString = string.Format(NewUserQueryString, username, password, username.ToUpper());
			string errorString = "";

			if (_oracleServices.ExecuteMultipleQuery(queryString, out errorString))
			{
				result = "Create user '" + username + "' successful";
				InsertAuditUser(username, password, 0);
			}
			else
			{
				result = "Create user fail: " + errorString;
			}
			return result;
		}

		public bool AlterUser(string username, string password)
		{
			string query = string.Format(AlterUserQueryString, username, password);
			return _oracleServices.ExecuteNonQuery(query);
		}

		public bool DeleteUser(string username, int option)
		{
			string query = string.Format((option == 0 ? DeleteUserQuery0 : DeleteUserQuery1), username);
			return _oracleServices.ExecuteNonQuery(query);
		}

		public bool IsAuditUser(string username)
		{
			bool result = false;
			string queryString = string.Format(IsAuditUserQuery, username.ToUpper());
			OracleDataReader reader = _oracleServices.ExecuteReader(queryString);
			if (reader != null && reader.Read())
			{
				result = (int.Parse(reader.GetString(0)) == 1);
			}
			return result;
		}

		public bool SetAuditWhenChangePassword(string username, int option)
		{
			string query = string.Format(SetAuditWhenChangePasswordQuery, option, username);
			return _oracleServices.ExecuteNonQuery(query);
		}

		public bool InsertAuditUser(string username, string password, int isAuditPassword)
		{
			string queryString = string.Format(InsertAuditUserQuery, username, password, isAuditPassword);
			return _oracleServices.ExecuteNonQuery(queryString);
		}

		public DataSet SearchUsers(string searchString)
		{
			string queryString = string.Format(SearchUserQuerystring, searchString.ToUpper());
			return _oracleServices.ExecuteQuery(queryString);
		}

		public bool SetAuditUser(string username, bool selectChecked, bool insertChecked, bool updateChecked, bool deleteChecked, bool executeProcedureChecked,
			bool wheneverSuccessfulChecked, bool wheneverUnsuccessfulChecked, bool auditChecked)
		{
			bool result = false;
			try
			{
				_oracleServices.ExecuteNonQuery("Noaudit all by " + username);

				if (auditChecked)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("Audit ");
					// Statement
					stringBuilder.Append(selectChecked ? "Select table, " : "");
					stringBuilder.Append(insertChecked ? "Insert table, " : "");
					stringBuilder.Append(updateChecked ? "Update table, " : "");
					stringBuilder.Append(deleteChecked ? "Delete table, " : "");
					stringBuilder.Append(executeProcedureChecked ? "Execute procedure, " : "");
					
					if (stringBuilder.ToString().EndsWith(", "))
					{
						stringBuilder.Remove(stringBuilder.Length - 2, 2);
					}
					// By
					stringBuilder.Append(" By " + username);

					// Execute query string
					if (wheneverSuccessfulChecked)
					{
						_oracleServices.ExecuteNonQuery(stringBuilder.ToString() + " Whenever successful");
					}
					if (wheneverUnsuccessfulChecked)
					{
						_oracleServices.ExecuteNonQuery(stringBuilder.ToString() + " Whenever not successful");
					}
				}
				
				result = true;
			}
			catch { }

			return result;
		}

		#endregion Methods ----------------------------------------------------------------------------
	}
}