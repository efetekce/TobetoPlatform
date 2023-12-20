﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateQuestionRequest
    {
        public int AssessmentId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionCategoryId { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
    }
}
