using SurveyApplication.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.Services.SurveyQuestions
{
    public class QuestionsService : IQuestionsService
    {
        public ResponseDTO<SurveyQuestionDTO> GetQuestions(RequestDTO requestedPage)
        {
            ResponseDTO<SurveyQuestionDTO> returnData = new ResponseDTO<SurveyQuestionDTO>();
            returnData.PageNumber = requestedPage.PageNumber;
            returnData.PageSize = requestedPage.PageSize;
            returnData.TotalNumberOfRecords = 1;

            returnData.Data = new List<SurveyQuestionDTO>() {
                new SurveyQuestionDTO{
                    QuestionId = 1,
                    Question = "How this blog is useful?",
                    Options = new List<SurveyQuestionOptionsDTO>(){
                        new SurveyQuestionOptionsDTO(){
                            OptionOrder = 1,
                            OptionText = "Very much"
                        },
                        new SurveyQuestionOptionsDTO(){
                            OptionOrder = 2,
                            OptionText = "All good"
                        },
                        new SurveyQuestionOptionsDTO(){
                            OptionOrder = 3,
                            OptionText = "Not that much"
                        }
                    }
                }
            };

            return returnData;
        }
    }
}
