using System;
using System.Collections.Generic;
using System.Text;
using CodingGameCompactor.Service.Dto;

namespace CodingGameCompactor.Service
{
    public class CodeCompactor
    {
        private readonly string _solutionPath;
        private readonly string[] _exclusionDirectoryList;
        public CodeCompactor(string solutionPath,string[] exclusionDirectoryList)
        {
            _solutionPath = solutionPath;
            _exclusionDirectoryList = exclusionDirectoryList;
        }

        public string GenerateOutput()
        {
            //Import Files
            string[] fileList = FileSystemUtility.GetFileList(_solutionPath, _exclusionDirectoryList);

            //Process File Contents
            var contents = CodeProcessor.ProcessSourceFiles(fileList);

            //Produce Output String
            return OutputGenerator.GenerateSingleFileOutputString(contents);

            return "";
        }
    }

    public class OutputGenerator
    {
        public static string GenerateSingleFileOutputString(CodeContentsDto contents)
        {
            string nl = Environment.NewLine;
            string nl2 = nl + nl;
            
            StringBuilder output = new StringBuilder();
            //Build Header Comments:
            output.Append($"//File Generated: {DateTime.Now:G}");

            output.Append(nl2);

            //Build using Statements:
            output.Append(string.Join(nl, contents.UsingStatements));

            output.Append(nl2);

            //Build Main Code Content:
            output.Append(string.Join(nl, contents.SourceCode));

            return output.ToString();
        }
    }
}
