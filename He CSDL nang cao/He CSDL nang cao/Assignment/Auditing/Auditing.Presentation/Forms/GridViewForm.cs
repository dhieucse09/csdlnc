using System;
using System.Data;
using System.Windows.Forms;

namespace Auditing.Presentation.Forms
{
	public partial class GridViewForm : Form
	{
		public GridViewForm(string sqlScript, DataSet dataSource)
		{
			InitializeComponent();

			SqlScript = sqlScript;
			DataSource = dataSource;
			DataMember = dataSource.Tables[0].TableName;
		}

		public string SqlScript
		{
			get { return rtbScript.Text; }
			set { rtbScript.Text = value; }
		}

		public DataSet DataSource
		{
			get { return (DataSet)dataGridView.DataSource; }
			set { dataGridView.DataSource = value; }
		}

		public string DataMember
		{
			get { return dataGridView.DataMember; }
			set { dataGridView.DataMember = value; }
		}
	}
}