using System;
using System.Windows.Forms;

namespace WinRLauncher
{
    public partial class DialogShellLinkFile : Form
    {
        public DialogShellLinkFile(FormMain baseForm, string command, string path, string arguments, string workingDirectory)
        {
            InitializeComponent();
            BaseForm = baseForm;
            Command = command;
            Path = path;
            Arguments = arguments;
            WorkingDirectory = workingDirectory;
        }

        private void DialogShellLinkFile_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonPath_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Path;
                dialog.Filter = "All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Command = System.IO.Path.GetFileNameWithoutExtension(dialog.FileName);
                    Path = dialog.FileName;
                    WorkingDirectory = System.IO.Path.GetDirectoryName(dialog.FileName);
                }
            }
        }

        private void buttonWorkingDirectory_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = WorkingDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                    WorkingDirectory = dialog.SelectedPath;
            }
        }

        private FormMain BaseForm { get; set; }

        public string Command
        {
            get { return this.textBoxCommand.Text; }
            private set { this.textBoxCommand.Text = value; }
        }

        public string Path
        {
            get { return this.textBoxPath.Text; }
            private set { this.textBoxPath.Text = value; }
        }

        public string Arguments
        {
            get { return this.textBoxArguments.Text; }
            private set { this.textBoxArguments.Text = value; }
        }

        public string WorkingDirectory
        {
            get { return this.textBoxWorkingDirectory.Text; }
            private set { this.textBoxWorkingDirectory.Text = value; }
        }
    }
}
