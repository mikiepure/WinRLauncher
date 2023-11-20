namespace ShellLinkBinderTests
{
    public class ShellLinkTest
    {
        [Fact]
        public void CreateAndLoad()
        {
            // CreateNewFile
            var dirpath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "out");
            Directory.CreateDirectory(dirpath);
            var filepath = Path.GetFullPath(Path.Combine(dirpath, "explorer.exe.lnk"));
            var path = @"C:\Windows\explorer.exe";
            var args = @"C:\Windows\Fonts";
            var wdir = @"C:\Users";
            Assert.True(ShellLinkBinder.ShellLink.CreateNewFile(filepath, path, args, wdir));

            // LoadFromFile
            Assert.True(ShellLinkBinder.ShellLink.LoadFromFile(filepath,
                out string refPath, out string refArgs, out string refWDir));
            Assert.Equal(path, refPath);
            Assert.Equal(args, refArgs);
            Assert.Equal(wdir, refWDir);
        }
    }
}
