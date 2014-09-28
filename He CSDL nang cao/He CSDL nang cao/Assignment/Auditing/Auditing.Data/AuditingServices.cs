using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace Auditing.Data
{
	public class AuditingServices
	{
		#region Fields --------------------------------------------------------------------------------

		private const string EnableAuditingQueryString = "AUDIT ALL";
		private const string DisableAuditingQueryString = "NOAUDIT ALL";

		private const string SearchAuditingQueryString = 
			"Select USERNAME, TIMESTAMP, OWNER, OBJ_NAME, ACTION_NAME, OBJ_PRIVILEGE, SYS_PRIVILEGE "
			+ " FROM dba_audit_trail WHERE USERNAME LIKE '%{0}%' OR OWNER LIKE '%{0}%'"; // username(owner)

		private OracleServices _oracleServices = null;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public AuditingServices(OracleServices oracleServices)
		{
			_oracleServices = oracleServices;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------
		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public bool AuditingEnabled
		{
			set
			{
				try
				{
					string query = (value ? EnableAuditingQueryString : DisableAuditingQueryString);
					OracleCommand command = new OracleCommand(query, _oracleServices.OracleConnection);
					command.CommandType = CommandType.Text;
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}

		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public DataSet SearchAuditing(string searchString) // searchString is owner
		{
			string queryString = string.Format(SearchAuditingQueryString, searchString);
			return _oracleServices.ExecuteQuery(queryString);
		}

		#endregion Methods ----------------------------------------------------------------------------
	}
}