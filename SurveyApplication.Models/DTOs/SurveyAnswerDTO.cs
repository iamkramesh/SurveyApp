using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.Models.DTOs
{
    public class SurveyAnswerDTO
    {
        public int QuestionId { get; set; }
        public SurveyQuestionOptionsDTO AnsweredOption { get; set; }
    }
}
