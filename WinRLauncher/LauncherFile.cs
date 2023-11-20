using System;
using System.Collections.Generic;

namespace WinRLauncher
{
    internal abstract class LauncherFile : IComparable<LauncherFile>
    {
        public string FilePath
        {
            get;
            protected set;
        }

        public string Name
        {
            get
            {
                return System.IO.Path.GetFileNameWithoutExtension(FilePath);
            }
        }

        public string Ext
        {
            get
            {
                return System.IO.Path.GetExtension(FilePath);
            }
        }

        public string Path
        {
            get;
            protected set;
        }

        public string Args
        {
            get;
            protected set;
        }

        public string WDir
        {
            get;
            protected set;
        }

        public abstract System.Drawing.Color ForeColor { get; }

        public string[] GetSameNamePaths()
        {
            string[] userPaths = EnvHelper.GetUserValues("PATH", Microsoft.Win32.RegistryValueOptions.None);
            string[] machinePaths = EnvHelper.GetMachineValues("PATH", Microsoft.Win32.RegistryValueOptions.None);

            var pathList = new List<string>();
            if (userPaths != null) pathList.AddRange(userPaths);
            if (machinePaths != null) pathList.AddRange(machinePaths);

            var duplicatePathList = new List<string>();
            foreach (var path in pathList)
            {
                var filepath = System.IO.Path.Combine(path, Name);

                List<string> supportedExts = new List<string>();
                supportedExts.AddRange(ShellLinkFile.SupportedExts);
                supportedExts.AddRange(BatchFile.SupportedExts);
                supportedExts.AddRange(ExeFile.SupportedExts);

                foreach (var pattern in supportedExts)
                    if (System.IO.File.Exists($"{filepath}{pattern}"))
                        duplicatePathList.Add($"{filepath}{pattern}");
            }

            return duplicatePathList.ToArray();
        }

        public int CompareTo(LauncherFile obj)
        {
            return FilePath.CompareTo(obj.FilePath);
        }
    }


    internal class ShellLinkFile : LauncherFile
    {
        private ShellLinkFile(string filepath, string path, string args, string wdir)
        {
            FilePath = filepath;
            Path = path;
            Args = args;
            WDir = wdir;
        }

        public static ShellLinkFile Create(string filepath, string path = "", string args = "", string wdir = "")
        {
            ShellLinkBinder.ShellLink.CreateNewFile(filepath, path, args, wdir);
            return new ShellLinkFile(filepath, path, args, wdir);
        }

        public static ShellLinkFile Load(string filepath)
        {
            ShellLinkBinder.ShellLink.LoadFromFile(filepath, out string path, out string args, out string wdir);
            return new ShellLinkFile(filepath, path, args, wdir);
        }

        public override System.Drawing.Color ForeColor
        {
            get { return System.Drawing.Color.Black; }
        }

        public static string[] SupportedExts
        {
            get { return new string[] { ".lnk" }; }
        }

        public static string[] SupportedPatterns
        {
            get { return new string[] { "*.lnk" }; }
        }
    }

    internal class BatchFile : LauncherFile
    {
        public BatchFile(string filepath)
        {
            FilePath = filepath;
            Path = "";
            Args = "";
            WDir = "";
        }

        public override System.Drawing.Color ForeColor
        {
            get { return System.Drawing.Color.Gray; }
        }

        public static string[] SupportedExts
        {
            get { return new string[] { ".com", ".bat", ".cmd" }; }
        }

        public static string[] SupportedPatterns
        {
            get { return new string[] { "*.com", "*.bat", "*.cmd" }; }
        }
    }

    internal class ExeFile : LauncherFile
    {
        public ExeFile(string filepath)
        {
            FilePath = filepath;
            Path = "";
            Args = "";
            WDir = "";
        }

        public override System.Drawing.Color ForeColor
        {
            get { return System.Drawing.Color.Gray; }
        }

        public static string[] SupportedExts
        {
            get { return new string[] { ".exe" }; }
        }

        public static string[] SupportedPatterns
        {
            get { return new string[] { "*.exe" }; }
        }
    }
}
