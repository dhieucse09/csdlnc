namespace Auditing.Business.Entities
{
	public class Table
	{
		#region Fields --------------------------------------------------------------------------------

		private string _owner;
		private string _tableName;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public Table(string owner, string tableName)
		{
			_owner = owner;
			_tableName = tableName;
		}

		public override string ToString()
		{
			return _tableName;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public string Owner
		{
			get { return _owner; }
			set { _owner = value; }
		}

		public string TableName
		{
			get { return _tableName; }
			set { _tableName = value; }
		}

		#endregion Properties -------------------------------------------------------------------------
	}
}