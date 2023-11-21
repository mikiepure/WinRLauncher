using System;
using System.IO;
using System.Windows.Forms;

namespace WinRLauncher
{
    public partial class ShellLinkPropDialog : Form
    {
        public ShellLinkPropDialog(string filename, string path, string args, string wdir)
        {
            InitializeComponent();

            FileName = filename;
            Path = path;
            Args = args;
            WDir = wdir;
        }

        private void ShellLinkPropDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.Compare(FileName, "") == 0)
                {
                    MessageBox.Show("Blank name is not accepted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                if (0 <= FileName.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()))
                {
                    MessageBox.Show("Name has invalid charactors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void ButtonPath_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Path;
                dialog.Filter = "All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = System.IO.Path.GetFileNameWithoutExtension(dialog.FileName);
                    Path = dialog.FileName;
                    WDir = System.IO.Path.GetDirectoryName(Path);
                }
            }
        }

        private void ButtonWDir_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = WDir;
                if (dialog.ShowDialog() == DialogResult.OK)
                    WDir = dialog.SelectedPath;
            }
        }

        public string FileName
        {
            get
            {
                return textBoxName.Text;
            }
            private set
            {
                textBoxName.Text = value;
            }
        }

        public string Path
        {
            get
            {
                return textBoxPath.Text;
            }
            private set
            {
                textBoxPath.Text = value;
            }
        }

        public string Args
        {
            get
            {
                return textBoxArgs.Text;
            }
            private set
            {
                textBoxArgs.Text = value;
            }
        }

        public string WDir
        {
            get
            {
                return textBoxWDir.Text;
            }
            private set
            {
                textBoxWDir.Text = value;
            }
        }
    }
}
