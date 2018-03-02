using System.IO.Abstractions.TestingHelpers;
using System.Linq;

namespace System.IO.Abstractions._277
{
    public static class Program
    {
        public static void Main()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddFile("/foo/bar.txt", "baz");

            var files = fileSystem.Directory.EnumerateFiles("/foo", "*", SearchOption.AllDirectories).ToList();

            Console.WriteLine($"Enumerated {files.Count} file(s): {string.Join(", ", files)}");
            if (files.Count != 1) throw new Exception("Should have enumerated one file, but did not");
        }
    }
}