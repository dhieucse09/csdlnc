using System;

namespace Auditing.Business.Entities
{
	public class AuditInfo
	{
		//Select    USERNAME, TIMESTAMP, OWNER, OBJ_NAME, ACTION_NAME, OBJ_PRIVILEGE, SYS_PRIVILEGE

		#region Fields --------------------------------------------------------------------------------

		private string _username;
		private DateTime _timeStamp;
		private string _owner;
		private string _objName;
		private string _actionName;
		private string _objPrivilege;
		private string _sysPrivilege;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public AuditInfo() : this("", DateTime.Now, "", "", "", "", "") { }
		public AuditInfo(string username, DateTime timeStamp, string owner, string objName,
												string action, string objPrivilege, string sysPrivilege)
		{
			_username = username;
			_timeStamp = timeStamp;
			_owner = owner;
			_objName = objName;
			_actionName = action;
			_objPrivilege = objPrivilege;
			_sysPrivilege = sysPrivilege;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------
		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public string Username
		{
			get { return _username; }
			set { _username = value; }
		}

		public DateTime TimeStamp
		{
			get { return _timeStamp; }
			set { _timeStamp = value; }
		}

		public string Owner
		{
			get { return _owner; }
			set { _owner = value; }
		}

		public string ObjName
		{
			get { return this._objName; }
			set { this._objName = value; }
		}

		public string ActionName
		{
			get { return _actionName; }
			set { _actionName = value; }
		}

		public string ObjPrivilege
		{
			get { return _objPrivilege; }
			set { _objPrivilege = value; }
		}

		public string SysPrivilege
		{
			get { return _sysPrivilege; }
			set { _sysPrivilege = value; }
		}

		#endregion Properties -------------------------------------------------------------------------
	}
}