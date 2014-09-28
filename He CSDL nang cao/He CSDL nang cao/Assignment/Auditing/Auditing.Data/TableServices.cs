using System;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace Auditing.Data
{
	public class TableServices
	{
		#region Fields --------------------------------------------------------------------------------

		private const string SearchTablesQueryString = "SELECT OWNER, TABLE_NAME FROM ALL_TABLES WHERE OWNER LIKE  '%{0}%' AND TABLE_NAME LIKE  '%{1}%'"; // owner, tableName

		private const string DeleteTableQueryString = "DROP TABLE {0} cascade constraints;"; // tableName

		private const string ListAllTablesQueryString = "SELECT TABLE_NAME FROM USER_TABLES";

		private const string DescribeTableQueryString = "DESCRIBE {0}"; //tableName

		private OracleServices _oracleServices = null;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public TableServices(OracleServices oracleServices)
		{
			_oracleServices = oracleServices;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------
		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------
		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public DataSet SearchTables(string owner, string searchString)
		{
			string queryString = string.Format(SearchTablesQueryString, owner, searchString);
			return _oracleServices.ExecuteQuery(queryString);
		}

		public bool DeleteTable(string tableName, out string errorString)
		{
			string queryString = string.Format(DeleteTableQueryString, tableName);
			return _oracleServices.ExecuteNonQuery(queryString, out errorString);
		}

		public DataSet ListAllTables()
		{
			return _oracleServices.ExecuteQuery(ListAllTablesQueryString);
		}

		public string DescribeTable(string tableName)
		{
			string queryString = string.Format(DescribeTableQueryString, tableName);
			string result = "";
			if (!_oracleServices.ExecuteQuery(queryString, out result))
			{
				result = "Describe table has some errors.";
			}
			return result;
		}

		public bool SetAuditTable(string tableName, bool selectChecked, bool insertChecked, bool updateChecked, bool deleteChecked, bool alterChecked, bool grantChecked,
			bool byAccessChecked, bool bySessionChecked, bool wheneverSuccessfulChecked, bool wheneverUnsuccessfulChecked,
			bool auditChecked)
		{
			bool result = false;
			try
			{
				_oracleServices.ExecuteNonQuery("NOAUDIT SELECT, INSERT, UPDATE, DELETE, ALTER, GRANT ON " + tableName);

				if (auditChecked)
				{
					StringBuilder stringBuilder = new StringBuilder();
					// Audit
					stringBuilder.Append("Audit ");
					stringBuilder.Append(selectChecked ? "select, " : "");
					stringBuilder.Append(insertChecked ? "insert, " : "");
					stringBuilder.Append(updateChecked ? "update, " : "");
					stringBuilder.Append(deleteChecked ? "delete, " : "");
					if (stringBuilder.ToString().EndsWith(", "))
					{
						stringBuilder.Remove(stringBuilder.Length - 2, 2);
					}
					// On
					stringBuilder.Append(" On " + tableName);
					// By access/session
					stringBuilder.Append(byAccessChecked ? " By access" : bySessionChecked ? " By session" : "");

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