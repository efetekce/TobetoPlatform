using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateAnswerRequest
    {
        public int QuestionId { get; set; }
        public string Content { get; set; }

        public int ProfileId { get; set; }
        public string? LanguageName { get; set; }
        public string? LanguageLevel { get; set; }



        public string Name { get; set; }
    }
}
