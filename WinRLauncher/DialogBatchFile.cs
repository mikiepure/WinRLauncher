using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRLauncher
{
    public partial class DialogBatchFile : Form
    {
        public DialogBatchFile(FormMain baseForm, string command, string action)
        {
            InitializeComponent();
            BaseForm = baseForm;
            Command = command;
            Action = action;
        }

        private void DialogBatchFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (string.Compare(Command, "") == 0)
                {
                    MessageBox.Show("Command can not be blank.", "Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                    return;
                }
                else if (0 <= Command.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()))
                {
                    MessageBox.Show("Command has invalid charactors.", "Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                    return;
                }

                if (Array.Exists(BaseForm.LauncherFiles.ToArray(), delegate (File.LauncherFile launchFile) { return string.Compare(launchFile.Command, Command, true) == 0; }))
                {
                    if (MessageBox.Show("Command '" + Command + "' is already exists. Do you want to replace it?", "Check Override", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private FormMain BaseForm { get; set; }

        public string Command
        {
            get { return this.textBoxCommand.Text; }
            private set { this.textBoxCommand.Text = value; }
        }

        public string Action
        {
            get { return this.textBoxAction.Text; }
            private set { this.textBoxAction.Text = value; }
        }
    }
}
