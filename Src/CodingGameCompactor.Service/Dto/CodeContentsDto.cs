using System.Collections.Generic;

namespace CodingGameCompactor.Service.Dto
{
    public class CodeContentsDto
    {
        public List<string> UsingStatements { get; set; }
        public List<string> SourceCode { get; set; }
    }
}