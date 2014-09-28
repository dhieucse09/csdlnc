using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Auditing.Business.Entities;
using Auditing.Presentation.Forms;

namespace Auditing.Presentation.Controls
{
	public partial class ExecuteScriptControl : UserControl
	{
		#region Fields --------------------------------------------------------------------------------

		private int _minScriptHeight = 100;
		private int _minOutputHeight = 100;

		#endregion Fields -----------------------------------------------------------------------------


		#region Constructors --------------------------------------------------------------------------

		public ExecuteScriptControl()
		{
			InitializeComponent();
			this.Dock = DockStyle.Fill;
		}

		#endregion Constructors -----------------------------------------------------------------------


		#region Private functions ---------------------------------------------------------------------

		private void linkClearScript_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			rtbScript.Text = "";
			rtbScript.Focus();
		}
		private void linkClearOutput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			rtbOutput.Text = "";
		}

		private void rtbScript_TextChanged(object sender, EventArgs e)
		{
			btnExecute.Enabled = linkSaveScript.Enabled = (rtbScript.Text != "");
		}
		private void rtbScript_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnExecute_Click(btnExecute, EventArgs.Empty);
			}
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			if (ExecuteScript != null)
			{
				string sqlScript = rtbScript.Text.Replace("\n", " ");
				ScriptEventArgs eventArgs = new ScriptEventArgs(sqlScript);
				ExecuteScript(this, eventArgs);
				AppendOutput(eventArgs.Result);
				if (eventArgs.DataSet != null && eventArgs.DataSet.Tables.Count > 0)
				{
					GridViewForm gridViewForm = new GridViewForm(sqlScript, eventArgs.DataSet);
					gridViewForm.ShowDialog();
				}
			}
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

		#endregion Private functions ------------------------------------------------------------------


		#region Properties ----------------------------------------------------------------------------

		public string QueryString
		{
			get { return rtbScript.Text; }
			set { rtbScript.Text = value; }
		}

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

		#endregion Properties -------------------------------------------------------------------------


		#region Methods -------------------------------------------------------------------------------

		public void AppendOutput(string message)
		{
			rtbOutput.Text += (rtbOutput.Text == "" ? "" : "\n") + message;
		}

		private void linkLoadScript_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				rtbScript.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		private void linkSaveScript_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, rtbScript.Text);
			}
		}

		#endregion Methods ----------------------------------------------------------------------------


		#region Events --------------------------------------------------------------------------------

		public event EventHandler<ScriptEventArgs> ExecuteScript = null;

		#endregion Events -----------------------------------------------------------------------------
	}
}