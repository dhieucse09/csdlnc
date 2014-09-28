using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Auditing.Presentation.Properties;

namespace Auditing.Presentation.Controls
{
	public partial class LoginControl : UserControl
	{
		#region Fields --------------------------------------------------------------------------------

		private const int MinInputLength = 6;
		private int _defaultHeight = 0;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public LoginControl()
		{
			InitializeComponent();

			_defaultHeight = this.Size.Height;
			/*using (SymmetricAlgorithm alg = SymmetricAlgorithm.Create("3DES"))
			{
				dataIV = alg.IV;
				dataKey = alg.Key;
			}/**/

			txtPassword.Text = CryptoLib.SymmetricDecrypt(Settings.Default.Password, Program.DataKey, Program.DataIV);
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void LoginControl_Load(object sender, EventArgs e)
		{
			lblLoginError.Text = "";
		}

		private void control_KeyUp(object sender, KeyEventArgs e)
		{
			lblLoginError.Text = "";
			if (e.KeyCode == Keys.Enter)
			{
				btnSignin_Click(btnSignin, EventArgs.Empty);
			}
		}

		private void textbox_TextChanged(object sender, EventArgs e)
		{
			btnSignin.Enabled = txtUsername.Text != "" && txtPassword.Text != "";
		}

		private void lblLoginError_TextChanged(object sender, EventArgs e)
		{
			this.Size = new Size(this.Width, _defaultHeight - (lblLoginError.Text == "" ? lblLoginError.Height : 0));
		}

		private void btnSignin_Click(object sender, EventArgs e)
		{
			if (btnSignin.Enabled && Login != null)
			{
				Login(this, EventArgs.Empty);
			}
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public string DataSourceName
		{
			get { return txtDataSourceName.Text; }
			set { txtDataSourceName.Text = value; }
		}

		public string Username
		{
			get { return txtUsername.Text; }
			set { txtUsername.Text = value; }
		}

		public string Password
		{
			get { return txtPassword.Text; }
			set { txtPassword.Text = value; }
		}

		public bool RememberInfo
		{
			get { return cbxRememberMe.Checked; }
			set { cbxRememberMe.Checked = value; }
		}

		public bool IsAdmin
		{
			get { return cbxAdmin.Checked; }
			set { cbxAdmin.Checked = value; }
		}

		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public new void Focus()
		{
			txtDataSourceName.Select();
		}

		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler Login = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}