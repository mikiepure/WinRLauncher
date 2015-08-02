using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WinRLauncher
{
    public partial class FormMain : Form
    {
        public static string EV_PATH = "PATH";
        public static string EV_WINR_LAUNCHER_PATH = "WINR_LNCH_PATH";
        public static string EV_REF_WINR_LAUNCHER_PATH = "%" + EV_WINR_LAUNCHER_PATH + "%";

        public FormMain()
        {
            InitializeComponent();

            this.LauncherFiles = new List<File.LauncherFile>();

            // Create directory for launcher files
            if (!System.IO.Directory.Exists(this.LauncherFilesDirectoryPath))
                System.IO.Directory.CreateDirectory(this.LauncherFilesDirectoryPath);

            // Create WinRLauncher environment variable
            string evWinRLauncherPath = Util.EnvironmentVariable.getUserValue(EV_WINR_LAUNCHER_PATH, RegistryValueOptions.None);
            if (evWinRLauncherPath != LauncherFilesDirectoryPath)
                Util.EnvironmentVariable.setUserValue(EV_WINR_LAUNCHER_PATH, LauncherFilesDirectoryPath, RegistryValueKind.String);

            // Set WinRLauncher environment variable to Path
            string[] evPathValues = Util.EnvironmentVariable.getUserValues(EV_PATH, RegistryValueOptions.DoNotExpandEnvironmentNames);
            if (evPathValues == null)
            {
                Util.EnvironmentVariable.setUserValue(EV_PATH, EV_REF_WINR_LAUNCHER_PATH, RegistryValueKind.ExpandString);
            }
            else if (Array.IndexOf<string>(evPathValues, EV_REF_WINR_LAUNCHER_PATH) < 0)
            {
                var evPathList = new List<string>(evPathValues);
                evPathList.Add(EV_REF_WINR_LAUNCHER_PATH);
                Util.EnvironmentVariable.setUserValue(EV_PATH, string.Join(";", evPathList.ToArray()), RegistryValueKind.ExpandString);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            userControlReload();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Uninstalling)
                Properties.Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlExit();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            userControlExit();
        }

        private void userControlExit()
        {
            Application.Exit();
        }

        private void newLinkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlNewLinkFile();
        }

        private void toolStripButtonNewLinkFile_Click(object sender, EventArgs e)
        {
            userControlNewLinkFile();
        }

        private void userControlNewLinkFile()
        {
            showShellLinkFileDialog();
        }

        private void newBatchFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlNewBatchFile();
        }

        private void toolStripButtonNewBatchFile_Click(object sender, EventArgs e)
        {
            userControlNewBatchFile();
        }

        private void userControlNewBatchFile()
        {
            showBatchFileDialog();
        }

        private void editSelectedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlEditSelectedFile();
        }

        private void toolStripButtonEditSelectedFile_Click(object sender, EventArgs e)
        {
            userControlEditSelectedFile();
        }

        private void userControlEditSelectedFile()
        {
            if (1 != listViewMain.SelectedItems.Count)
                return;

            var launcherFile = LauncherFiles[listViewMain.SelectedItems[0].Index];
            if (launcherFile is File.ShellLinkFile)
                showShellLinkFileDialog(launcherFile.Command, launcherFile.Action, launcherFile.Arguments, launcherFile.WorkingDirectory);
            else if (launcherFile is File.BatchFile)
                showBatchFileDialog(launcherFile.Command, launcherFile.Action);
        }

        private void removeSelectedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlRemoveSelectedFile();
        }

        private void toolStripButtonRemoveSelectedFile_Click(object sender, EventArgs e)
        {
            userControlRemoveSelectedFile();
        }

        private void userControlRemoveSelectedFile()
        {
            if (0 == listViewMain.SelectedItems.Count)
                return;
            
            if (MessageBox.Show("Are you sure you want to permanently delete selected file?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            foreach (ListViewItem selectedItem in listViewMain.SelectedItems)
                System.IO.File.Delete(LauncherFiles[selectedItem.Index].FilePath);

            userControlReload();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlReload();
        }

        private void toolStripButtonReload_Click(object sender, EventArgs e)
        {
            userControlReload();
        }

        private void userControlReload()
        {
            this.LauncherFiles.Clear();
            foreach (var lnkFilePath in System.IO.Directory.GetFiles(this.LauncherFilesDirectoryPath, "*.lnk"))
                this.LauncherFiles.Add(File.ShellLinkFile.load(lnkFilePath));
            foreach (var batFilePath in System.IO.Directory.GetFiles(this.LauncherFilesDirectoryPath, "*.bat"))
                this.LauncherFiles.Add(File.BatchFile.load(batFilePath));
            foreach (var exeFilePath in System.IO.Directory.GetFiles(this.LauncherFilesDirectoryPath, "*.exe"))
                this.LauncherFiles.Add(new File.ExeFile(exeFilePath));
            this.LauncherFiles.Sort();

            var items = new List<ListViewItem>();
            foreach (var launcherFile in this.LauncherFiles)
            {
                var item = new ListViewItem(launcherFile.Command);
                item.SubItems.Add(launcherFile.Action);
                item.SubItems.Add(launcherFile.WorkingDirectory);
                item.SubItems.Add(launcherFile.Arguments);
                item.ForeColor = launcherFile.ForeColor;
                item.BackColor = launcherFile.BackColor;
                items.Add(item);
            }
            this.listViewMain.Items.Clear();
            this.listViewMain.Items.AddRange(items.ToArray());
        }

        private void openLauncherFilesPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlOpenLauncherFilesPath();
        }

        private void toolStripButtonOpenLauncherFilesPath_Click(object sender, EventArgs e)
        {
            userControlOpenLauncherFilesPath();
        }

        private void userControlOpenLauncherFilesPath()
        {
            if (System.IO.Directory.Exists(LauncherFilesDirectoryPath))
                System.Diagnostics.Process.Start(LauncherFilesDirectoryPath);
            else
                MessageBox.Show("Failed to open directory ' " + LauncherFilesDirectoryPath + " ' : Directory is not exists.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void uninstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlUninstall();
        }

        private void userControlUninstall()
        {
            if (MessageBox.Show("Are you sure you want to uninstall the application?", "Confirm to unistall", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            if (MessageBox.Show("Are you sure?", "Confirm to unistall", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // Remove ' %WINR_LAUNCHER_PATH% ' from environment variable ' PATH '
            var evPaths = Util.EnvironmentVariable.getUserValues(FormMain.EV_PATH, RegistryValueOptions.DoNotExpandEnvironmentNames);
            if (evPaths != null)
            {
                var evPathList = new List<string>(evPaths);
                if (evPathList.Remove(FormMain.EV_REF_WINR_LAUNCHER_PATH))
                {
                    if (0 < evPathList.Count)
                    {
                        Util.EnvironmentVariable.setUserValues(FormMain.EV_PATH, evPathList.ToArray(), RegistryValueKind.ExpandString);
                    }
                    else
                    {
                        Util.EnvironmentVariable.deleteUserKey(FormMain.EV_PATH);
                    }
                }
            }

            // Remove environment variable ' PATH_LNKS '
            string evWinRLauncherPath = Util.EnvironmentVariable.getUserValue(FormMain.EV_WINR_LAUNCHER_PATH, RegistryValueOptions.None);
            if (evWinRLauncherPath != null)
            {
                Util.EnvironmentVariable.deleteUserKey(FormMain.EV_WINR_LAUNCHER_PATH);
            }

            // Remove configuration directory
            if (System.IO.Directory.Exists(ConfigurationDirectoryPath))
            {
                System.IO.Directory.Delete(ConfigurationDirectoryPath, true);
            }

            Uninstalling = true;
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAbout();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            userControlAbout();
        }

        private void userControlAbout()
        {
            var version = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            MessageBox.Show("Win+R Launcher ver " + version.ProductVersion + Environment.NewLine + version.LegalCopyright, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    userControlEditSelectedFile();
                    break;

                case Keys.Delete:
                    userControlRemoveSelectedFile();
                    break;
            }
        }

        private void listViewMain_DoubleClick(object sender, EventArgs e)
        {
            userControlEditSelectedFile();
        }

        private void listViewMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listViewMain_DragDrop(object sender, DragEventArgs e)
        {
            var filepaths = (string[])(e.Data.GetData(DataFormats.FileDrop, false));
            if (filepaths.Length != 1)
            {
                MessageBox.Show("Can not accept multiple files.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filepath = filepaths[0];
            backgroundWorkerDragDrop.RunWorkerAsync(filepath);  // For releasing drag context.
        }

        private void backgroundWorkerDragDrop_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            e.Result = e.Argument;
        }

        private void backgroundWorkerDragDrop_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.Activate();
            var filepath = (string)(e.Result);

            var command = "";
            var path = "";
            var args = "";
            var wdir = "";
            if (System.IO.Path.GetExtension(filepath) == ".lnk")
            {
                var shellLinkFile = File.ShellLinkFile.load(filepath);
                command = shellLinkFile.Command;
                path = shellLinkFile.Action;
                args = shellLinkFile.Arguments;
                wdir = shellLinkFile.WorkingDirectory;

            }
            else
            {
                command = System.IO.Path.GetFileNameWithoutExtension(filepath);
                path = filepath;
                wdir = System.IO.Path.GetDirectoryName(filepath);
            }

            showShellLinkFileDialog(command, path, args, wdir);
        }

        // -- Helper Functions -- //

        private void showShellLinkFileDialog(string command = "", string path = "", string arguments = "", string workingDirectory = "")
        {
            using (var dialog = new DialogShellLinkFile(this, command, path, arguments, workingDirectory))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var newFilePath = LauncherFilesDirectoryPath + System.IO.Path.DirectorySeparatorChar + dialog.Command + ".lnk";
                    File.ShellLinkFile.create(newFilePath, dialog.Path, dialog.Arguments, dialog.WorkingDirectory);
                    userControlReload();
                }
            }
        }

        private void showBatchFileDialog(string command = "", string action = "")
        {
            using (var dialog = new DialogBatchFile(this, command, action))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var filepath = LauncherFilesDirectoryPath + System.IO.Path.DirectorySeparatorChar + dialog.Command + ".bat";
                    File.BatchFile.create(filepath, dialog.Action);
                    userControlReload();
                }
            }
        }

        // -- Properties -- //

        public bool Uninstalling { get; set; } = false;

        public string ConfigurationDirectoryPath
        {
            get
            {
                var configFilePath = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
                return System.IO.Path.GetDirectoryName(configFilePath);
            }
        }

        private string LauncherFilesDirectoryPath
        {
            get
            {
                return ConfigurationDirectoryPath + System.IO.Path.DirectorySeparatorChar + "LauncherFiles";
            }
        }

        public List<File.LauncherFile> LauncherFiles { get; private set; }
    }
}
