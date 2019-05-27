using SurveyApplication.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.Services.SurveyQuestions
{
    public interface IQuestionsService
    {
        ResponseDTO<SurveyQuestionDTO> GetQuestions(RequestDTO requestedPage);
    }
}
