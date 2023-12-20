using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedAnswerResponse
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Content { get; set; }

        public int ProfileId { get; set; }
        public string? LanguageName { get; set; }
        public string? LanguageLevel { get; set; }
        public string Name { get; set; }
    }
}
