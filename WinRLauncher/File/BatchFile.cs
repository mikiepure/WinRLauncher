
namespace WinRLauncher.File
{
    public class BatchFile : LauncherFile
    {
        private BatchFile(string filepath)
            : base(filepath)
        {
            // Do nothing
        }

        public static BatchFile create(string filepath, string action)
        {
            System.IO.File.WriteAllText(filepath, action);
            return new BatchFile(filepath);
        }

        public static BatchFile load(string filepath)
        {
            return new BatchFile(filepath);
        }

        public override string Action
        {
            get
            {
                string action = "";
                using (var streamReader = new System.IO.StreamReader(this.FilePath))
                {
                    action = streamReader.ReadLine();
                }
                return action;
            }
            set { }
        }

        public override System.Drawing.Color ForeColor
        {
            get { return System.Drawing.Color.Blue; }
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
