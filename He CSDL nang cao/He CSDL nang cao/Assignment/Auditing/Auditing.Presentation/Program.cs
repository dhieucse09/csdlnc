using System;
using System.Windows.Forms;

namespace Auditing.Presentation
{
	static class Program
	{
		private static byte[] _dataIV = new byte[8] { 174, 199, 59, 148, 208, 31, 167, 82 };
		public static byte[] DataIV
		{
			get { return Program._dataIV; }
		}

		private static byte[] _dataKey = new byte[24] { 24, 161, 113, 12, 169, 220, 96, 110, 58, 240, 2, 40, 142, 110, 30, 198, 110, 206, 130, 19, 3, 218, 250, 119 };
		public static byte[] DataKey
		{
			get { return Program._dataKey; }
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Forms.MainForm());
		}
	}
}