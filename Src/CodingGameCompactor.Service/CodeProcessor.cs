using System.IO;
using System.Linq;
using CodingGameCompactor.Service.Dto;

namespace CodingGameCompactor.Service
{
    public static class CodeProcessor
    {
        public static CodeContentsDto ProcessSourceFiles(string[] fileList)
        {
            CodeContentsDto contents = new CodeContentsDto();

            contents.SourceCode = fileList.SelectMany(f => File.ReadAllLines(f)).ToList();
            contents.UsingStatements = contents.SourceCode.Where(f => f.StartsWith("using")).Distinct().ToList();
            contents.SourceCode.RemoveAll(u => u.StartsWith("using"));

            return contents;
        }
    }
}