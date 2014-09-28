using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using System.Text;
using System.IO;

namespace Auditing.Data
{
	public class OracleServices
	{
		#region Fields --------------------------------------------------------------------------------

		private const string DefaultServer = "asis-founder";
		private const string ConnectionstringTemplate = "Data Source=(DESCRIPTION="
			 + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT=1521)))"
			 + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
			 + " user id = {1};password = {2};";

		private const string EnableAuditingQuery = "AUDIT ALL";
		private const string DisableAuditingQuery = "NOAUDIT ALL";

		private string _server;
		private string _username;
		private string _password;

		private OracleConnection _oracleConnection;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public OracleServices() : this(DefaultServer) { }
		public OracleServices(string server)
		{
			_server = server;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private bool setAuditingEnabled(bool value)
		{
			bool result = false;
			try
			{
				string query = (value ? EnableAuditingQuery : DisableAuditingQuery);
				OracleCommand command = new OracleCommand(query, _oracleConnection);
				command.CommandType = CommandType.Text;
				command.ExecuteNonQuery();
				result = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return result;
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public string Server
		{
			get { return _server; }
		}

		public string Username
		{
			get { return _username; }
		}

		public string Password
		{
			get { return _password; }
		}

		public OracleConnection OracleConnection
		{
			get { return _oracleConnection; }
		}

		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public bool OpenConnection(string username, string password)
		{
			bool result = false;
			try
			{
				string connectionstring = string.Format(ConnectionstringTemplate, _server, username, password);
				_oracleConnection = new OracleConnection(connectionstring);
				_oracleConnection.Open();

				_username = username;
				_password = password;
				result = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return result;
		}
		public bool CloseConnection()
		{
			bool result = false;
			try
			{
				_oracleConnection.Close();
				_oracleConnection.Dispose();
				result = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return result;
		}

		public bool IsAdmin()
		{
			//To do
			return true;
		}

		public bool ExecuteMultipleQuery(string queryString, out string errorstring)
		{
			bool result = true;
			errorstring = "";
			string[] query = queryString.Split(';');
			for (int i = 0; i < query.Length; i++)
			{
				if (query[i].Trim() != "" && !ExecuteNonQuery(query[i], out errorstring))
				{
					result = false;
					break;
				}
			}
			return result;
		}
		public bool ExecuteMultipleQuery(string queryString)
		{
			string errorstring;
			return ExecuteMultipleQuery(queryString, out errorstring);
		}

		public bool ExecuteNonQuery(string queryString, out string resultstring)
		{
			string[] query = queryString.Split(';');
			OracleCommand command = new OracleCommand(query[0], _oracleConnection);
			command.CommandType = CommandType.Text;

			bool result = false;
			try
			{
				command.ExecuteNonQuery();
				result = true;
				resultstring = "Execute query successful.";
			}
			catch (Exception ex)
			{
				resultstring = ex.Message;
			}
			return result;
		}
		public bool ExecuteNonQuery(string queryString)
		{
			string resultstring;
			return ExecuteNonQuery(queryString, out resultstring);
		}

		public OracleDataReader ExecuteReader(string queryString)
		{
			OracleCommand command = new OracleCommand(queryString, _oracleConnection);
			command.CommandType = CommandType.Text;
			
			try
			{
				OracleDataReader reader = command.ExecuteReader();
				return reader;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}

		public DataSet ExecuteQuery(string queryString)
		{
			DataSet dataset;
			ExecuteQuery(queryString, out dataset);
			return dataset;
		}
		public bool ExecuteQuery(string queryString, out DataSet dataset)
		{
			bool result = false;
			dataset = new DataSet();
			try
			{
				OracleDataAdapter dataAdapter = new OracleDataAdapter(queryString, _oracleConnection);
				dataAdapter.Fill(dataset);
				result = true;
			}
			catch { }

			return result;
		}
		public bool ExecuteQuery(string queryString, out string output)
		{
			bool result = false;
			StringBuilder builder = new StringBuilder();
			try
			{
				OracleDataReader reader = ExecuteReader(queryString);
				if (reader != null)
				{
					while (reader.Read())
					{
						builder.Append(reader.GetString(0));
					}
				}

				result = true;
				output = builder.ToString();
			}
			catch (Exception ex)
			{
				output = ex.Message;
			}

			return result;
		}

		#endregion Methods ----------------------------------------------------------------------------
	}
}