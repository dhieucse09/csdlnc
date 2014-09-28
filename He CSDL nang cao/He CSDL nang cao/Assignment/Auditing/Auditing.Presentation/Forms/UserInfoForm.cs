using System;
using System.Windows.Forms;

namespace Auditing.Presentation.Forms
{
	public partial class UserInfoForm : Form
	{
		#region Fields --------------------------------------------------------------------------------

		private const int MinInputLength = 6;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public UserInfoForm() : this("", true) { }
		public UserInfoForm(string username) : this(username, false) { }
		public UserInfoForm(string username, bool isNewUser)
		{
			InitializeComponent();

			txtUserName.Text = username;
			txtUserName.Enabled = isNewUser;

			this.Text = (isNewUser ? "New user" : "Change password");
			this.DialogResult = DialogResult.Cancel;
		}


		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void textbox_TextChanged(object sender, EventArgs e)
		{
			lblMessage.Visible = txtPassword1.Text != txtPassword2.Text && txtPassword1.Text.Length >= MinInputLength && txtPassword2.Text.Length >= MinInputLength;
			btnLogin.Enabled = txtUserName.Text.Length > MinInputLength && txtPassword1.Text == txtPassword2.Text && txtPassword1.Text.Length >= MinInputLength;
		}

		private void Textbox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && btnLogin.Enabled)
			{
				DialogResult = DialogResult.OK;
			}
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public string Username
		{
			get { return txtUserName.Text; }
		}

		public string Password
		{
			get { return btnLogin.Enabled ? txtPassword1.Text : txtPassword2.Text; }
		}

		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------
		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------
		#endregion Events -----------------------------------------------------------------------------
	}
}