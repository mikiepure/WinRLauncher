
namespace WinRLauncher.File
{
    public class ExeFile : LauncherFile
    {
        public ExeFile(string filepath)
            : base(filepath)
        {
            // Do nothing
        }

        public override System.Drawing.Color ForeColor
        {
            get { return System.Drawing.Color.Red; }
        }

        public override System.Drawing.Color BackColor
        {
            get
            {
                if (this.HasInvalidCommand)
                    return System.Drawing.Color.Magenta;
                else if (this.HasDuplicatedCommand)
                    return System.Drawing.Color.Yellow;
                else
                    return System.Drawing.Color.White;
            }
        }
    }
}
