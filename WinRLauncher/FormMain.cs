using Microsoft.Win32;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRLauncher
{
    public partial class FormMain : Form
    {
        private readonly string _launcherDirPath;
        private readonly List<LauncherFile> _launcherFiles = new List<LauncherFile>();

        public FormMain()
        {
            InitializeComponent();

            // Create folder to store launcher files
            _launcherDirPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile, Environment.SpecialFolderOption.Create),
                ".WinRLauncher");
            if (!Directory.Exists(_launcherDirPath))
            {
                Directory.CreateDirectory(_launcherDirPath);
            }

            // Add launcher folder to PATH of environment variable
            bool rebootRequired = false;
            var envPathArray = EnvHelper.GetUserValues("PATH", RegistryValueOptions.DoNotExpandEnvironmentNames);
            if (envPathArray == null)
            {
                EnvHelper.SetUserValue("PATH", _launcherDirPath, RegistryValueKind.ExpandString);
                rebootRequired = true;
            }
            else if (Array.IndexOf(envPathArray, _launcherDirPath) < 0)
            {
                var envPathList = new List<string>(envPathArray)
                {
                    _launcherDirPath
                };
                EnvHelper.SetUserValues("PATH", envPathList, RegistryValueKind.ExpandString);
                rebootRequired = true;
            }

            if (rebootRequired)
                MessageBox.Show(
                    $"The value of environment variable PATH was changed.{Environment.NewLine}Please reboot Windows to apply it.",
                    "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------------------------------------------------
        // Event Handlers
        //---------------------------------------------------------------------

        private void FormMain_Load(object sender, EventArgs e)
        {
            ReloadFromFileSystem();
        }

        private void ToolStripButtonCreateNewFile_Click(object sender, EventArgs e)
        {
            CreateNewFile("");
        }

        private void ToolStripButtonEditSelectedFile_Click(object sender, EventArgs e)
        {
            EditSelectedFile(listViewMain);
        }

        private void ToolStripButtonRemoveSelectedFile_Click(object sender, EventArgs e)
        {
            RemoveSelectedFile(listViewMain);
        }

        private void ToolStripButtonReload_Click(object sender, EventArgs e)
        {
            ReloadFromFileSystem();
        }

        private void ToolStripButtonOpenLauncherFolder_Click(object sender, EventArgs e)
        {
            OpenLauncherFolder();
        }

        private void ToolStripButtonAbout_Click(object sender, EventArgs e)
        {
            ShowAboutDialog();
        }

        private void ListViewMain_KeyDown(object sender, KeyEventArgs e)
        {
            var listViewMain = (ListView)sender;
            switch (e.KeyData)
            {
                case Keys.Enter:
                    EditSelectedFile(listViewMain);
                    break;
                case Keys.Delete:
                    RemoveSelectedFile(listViewMain);
                    break;
                case Keys.F5:
                    ReloadFromFileSystem();
                    break;
            }
        }

        private void ListViewMain_DoubleClick(object sender, EventArgs e)
        {
            var listViewMain = (ListView)sender;
            EditSelectedFile(listViewMain);
        }

        private void ListViewMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private async void ListViewMain_DragDrop(object sender, DragEventArgs e)
        {
            var pathlist = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (pathlist.Length != 1)
            {
                MessageBox.Show("Multiple files are not accepted.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Release thread context once to exit context of drag & drop
            await Task.Yield();

            CreateNewFile(pathlist[0]);
        }

        //---------------------------------------------------------------------
        // Procedures
        //---------------------------------------------------------------------

        private void CreateNewFile(string sourceFilePath)
        {
            if (sourceFilePath == "")
            {
                ShowShellLinkPropDialog("", "", "", "");
            }
            else if (Path.GetExtension(sourceFilePath) == ".lnk")
            {
                ShellLinkBinder.ShellLink.LoadFromFile(sourceFilePath,
                    out string path, out string args, out string wdir);
                ShowShellLinkPropDialog(sourceFilePath, path, args, wdir);
            }
            else
            {
                ShowShellLinkPropDialog(
                    Path.Combine(_launcherDirPath, Path.GetFileName(sourceFilePath)),
                    sourceFilePath, "", Path.GetDirectoryName(sourceFilePath));
            }
        }

        private void EditSelectedFile(ListView view)
        {
            var file = GetSelectedFile(view);
            if ((file != null) && (file.Ext == ".lnk"))
                ShowShellLinkPropDialog(file.FilePath, file.Path, file.Args, file.WDir, true);
        }

        private void ShowShellLinkPropDialog(string filepath, string path, string args, string wdir, bool edit = false)
        {
            var filename = Path.GetFileNameWithoutExtension(filepath);
            using (var dialog = new ShellLinkPropDialog(filename, path, args, wdir))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Create new file
                    var newFilePath = Path.Combine(_launcherDirPath, $"{dialog.FileName}.lnk");
                    if (!ShellLinkBinder.ShellLink.CreateNewFile(
                        newFilePath, dialog.Path, dialog.Args, dialog.WDir))
                    {
                        MessageBox.Show("Failed to create file by error.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Remove old file
                    if (edit)
                        File.Delete(filepath);

                    ReloadFromFileSystem();
                }
            }
        }

        private void RemoveSelectedFile(ListView view)
        {
            var file = GetSelectedFile(view);
            if (file != null)
            {
                File.Delete(file.FilePath);
                ReloadFromFileSystem();
            }
        }

        private void ReloadFromFileSystem()
        {
            _launcherFiles.Clear();
            foreach (var pattern in ShellLinkFile.SupportedPatterns)
                foreach (var filepath in Directory.GetFiles(_launcherDirPath, pattern))
                    _launcherFiles.Add(ShellLinkFile.Load(filepath));
            foreach (var pattern in BatchFile.SupportedPatterns)
                foreach (var filepath in Directory.GetFiles(_launcherDirPath, pattern))
                    _launcherFiles.Add(new BatchFile(filepath));
            foreach (var pattern in ExeFile.SupportedPatterns)
                foreach (var filepath in Directory.GetFiles(_launcherDirPath, pattern))
                    _launcherFiles.Add(new ExeFile(filepath));
            _launcherFiles.Sort();

            var items = new List<ListViewItem>();
            foreach (var launcherFile in _launcherFiles)
            {
                var item = new ListViewItem(launcherFile.Name);
                item.SubItems.Add(launcherFile.Ext);
                item.SubItems.Add(launcherFile.Path);
                item.SubItems.Add(launcherFile.Args);
                item.SubItems.Add(launcherFile.WDir);
                item.ForeColor = launcherFile.ForeColor;
                var sameNamePaths = launcherFile.GetSameNamePaths();
                if (sameNamePaths.Length > 1)
                {
                    item.BackColor = System.Drawing.Color.Yellow;

                    var text = $"The following files have the same name on the PATH:\n";
                    foreach (var path in sameNamePaths)
                        text += $"- {path}\n";
                    item.ToolTipText = text;
                }
                items.Add(item);
            }

            listViewMain.Items.Clear();
            listViewMain.Items.AddRange(items.ToArray());
        }

        private void OpenLauncherFolder()
        {
            if (Directory.Exists(_launcherDirPath))
                Process.Start(_launcherDirPath);
            else
                MessageBox.Show(
                    $"Failed to open directory '{_launcherDirPath}' by error: not exists.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowAboutDialog()
        {
            var version = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            MessageBox.Show($"WinR Launcher ver {version.ProductVersion}{Environment.NewLine}{version.LegalCopyright}",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //---------------------------------------------------------------------
        // Properties
        //---------------------------------------------------------------------

        private LauncherFile GetSelectedFile(ListView view)
        {
            if (view.SelectedItems.Count != 1)
                return null;

            return _launcherFiles[view.SelectedItems[0].Index];
        }
    }
}
