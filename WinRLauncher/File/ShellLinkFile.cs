
namespace WinRLauncher.File
{
    public class ShellLinkFile : LauncherFile
    {
        private ShellLinkFile(string filepath)
            : base(filepath)
        {
            this.ShellLink = ShellLinkBinding.ShellLinkBinding.load(filepath);
        }

        private ShellLinkFile(string filepath, string path, string arguments, string workingDirectory)
            : base(filepath)
        {
            this.ShellLink = ShellLinkBinding.ShellLinkBinding.create(filepath, path, arguments, workingDirectory);
        }

        public static ShellLinkFile create(string filepath, string path = "", string arguments = "", string workingDirectory = "")
        {
            return new ShellLinkFile(filepath, path, arguments, workingDirectory);
        }

        public static ShellLinkFile load(string filepath)
        {
            return new ShellLinkFile(filepath);
        }

        public override string Action
        {
            get { return this.ShellLink.Path; }
            set { this.ShellLink.Path = value; }
        }

        public override string Arguments
        {
            get { return this.ShellLink.Arguments; }
            set { this.ShellLink.Arguments = value; }
        }

        public override string WorkingDirectory
        {
            get { return this.ShellLink.WorkingDirectory; }
            set { this.ShellLink.WorkingDirectory = value; }
        }

        public override System.Drawing.Color ForeColor
        {
            get { return System.Drawing.Color.Black; }
        }

        public override System.Drawing.Color BackColor
        {
            get
            {
                if (this.HasInvalidCommand)
                    return System.Drawing.Color.Magenta;
                else if (this.HasDuplicatedCommand)
                    return System.Drawing.Color.Yellow;
                else if (!System.IO.File.Exists(this.Action) && !System.IO.Directory.Exists(this.Action))
                    return System.Drawing.Color.Aqua;
                else
                    return System.Drawing.Color.White;
            }
        }

        private ShellLinkBinding.ShellLinkBinding ShellLink { get; set; }
    }
}
