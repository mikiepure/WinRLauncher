using System;
using System.Collections.Generic;

namespace WinRLauncher.File
{
    public abstract class LauncherFile : IComparable<LauncherFile>
    {
        public LauncherFile(string filepath)
        {
            this.FilePath = filepath;
        }

        public string FilePath { get; set; }
        public string Command
        {
            get { return System.IO.Path.GetFileNameWithoutExtension(this.FilePath); }
        }

        public abstract string Action { get; set; }
        public abstract string Arguments { get; set; }
        public abstract string WorkingDirectory { get; set; }

        public abstract System.Drawing.Color ForeColor { get; }
        public abstract System.Drawing.Color BackColor { get; }

        protected bool HasInvalidCommand
        {
            get { return (0 <= this.Command.IndexOf(" ") || 255 < (this.Command).Length); }
        }

        protected bool HasDuplicatedCommand
        {
            get
            {
                string[] userPaths = Util.EnvironmentVariable.getUserValues("PATH", Microsoft.Win32.RegistryValueOptions.None);
                string[] machinePaths = Util.EnvironmentVariable.getMachineValues("PATH", Microsoft.Win32.RegistryValueOptions.None);

                var pathList = new List<string>();
                if (userPaths != null) pathList.AddRange(userPaths);
                if (machinePaths != null) pathList.AddRange(machinePaths);

                int count = 0;
                foreach (string path in pathList)
                {
                    string filepathWithoutExtension = removeLastDirectorySeparator(path) + System.IO.Path.DirectorySeparatorChar + this.Command;
                    if (System.IO.File.Exists(filepathWithoutExtension + ".lnk"))
                        count++;
                    if (System.IO.File.Exists(filepathWithoutExtension + ".bat"))
                        count++;
                    if (System.IO.File.Exists(filepathWithoutExtension + ".exe"))
                        count++;
                }

                return (1 < count);
            }
        }

        private static string removeLastDirectorySeparator(string filepath)
        {
            int index = filepath.LastIndexOf(System.IO.Path.DirectorySeparatorChar);
            if (0 < index && filepath.Length - 1 <= index)
                return removeLastDirectorySeparator(filepath.Substring(0, index));
            else
                return filepath;
        }

        public int CompareTo(LauncherFile obj)
        {
            return this.FilePath.CompareTo(obj.FilePath);
        }
    }
}
