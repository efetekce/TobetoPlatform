using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Question : Entity<int>
    {
        public int TestId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionCategoryId { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }

    }
}
