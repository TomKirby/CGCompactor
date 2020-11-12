using System.IO;
using System.Linq;

namespace CodingGameCompactor.Service
{
    public static class FileSystemUtility
    {
        public static string[] GetFileList(string solutionPath, string[] exclusionDirectoryList)
        {
            string[] files = Directory.GetFiles(solutionPath, "*.cs", SearchOption.AllDirectories)
                                      .Where(f => !exclusionDirectoryList.Any(f.Contains)).ToArray();

            return files;
        }
    }
}