using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.Models.DTOs
{
    public class SurveyQuestionDTO
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public List<SurveyQuestionOptionsDTO> Options { get; set; }
    }

    public class SurveyQuestionOptionsDTO
    {
        public int OptionOrder { get; set; }
        public string OptionText { get; set; }
    }
}
