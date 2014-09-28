using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Auditing.Presentation.Controls;

namespace Auditing.Presentation.Forms
{
	public partial class NewTableForm : Form
	{
		#region Fields --------------------------------------------------------------------------------

		private int _minScriptHeight = 100;
		private int _minOutputHeight = 100;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public NewTableForm()
		{
			InitializeComponent();
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void appendOutput(string text)
		{
			rtbOutput.Text = (rtbOutput.Text == "" ? text : "\n" + text);
		}

		private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
		{
			if (_minScriptHeight + _minOutputHeight < splitContainer.Height)
			{
				if (splitContainer.SplitterDistance < _minScriptHeight)
				{
					splitContainer.SplitterDistance = _minScriptHeight;
				}
				if (splitContainer.SplitterDistance + _minOutputHeight > splitContainer.Height)
				{
					splitContainer.SplitterDistance = splitContainer.Height - _minOutputHeight;
				}
			}
			else
			{
				splitContainer.SplitterDistance = (int)(splitContainer.Height / 2);
			}
		}

		private void rtbScript_KeyUp(object sender, KeyEventArgs e)
		{
			btnExecuteScript.Enabled = (rtbScript.Text != "");
			if (e.KeyCode == Keys.Enter)
			{
				btnExecuteScript_Click(btnExecuteScript, EventArgs.Empty);
			}
		}

		private void btnExecuteScript_Click(object sender, EventArgs e)
		{
			if (ExecuteScript != null && btnExecuteScript.Enabled)
			{
				ScriptEventArgs eventArgs = new ScriptEventArgs(rtbScript.Text);
				ExecuteScript(this, eventArgs);
				appendOutput(eventArgs.Result);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		[Browsable(true), DefaultValue(100)]
		public int MinScriptHeight
		{
			get { return _minScriptHeight; }
			set { _minScriptHeight = value; }
		}

		[Browsable(true), DefaultValue(100)]
		public int MinOutputHeight
		{
			get { return _minOutputHeight; }
			set { _minOutputHeight = value; }
		}

		public string ScriptString
		{
			get { return rtbScript.Text; }
			set { rtbScript.Text = value; }
		}

		#endregion Properties -------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler<ScriptEventArgs> ExecuteScript = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}