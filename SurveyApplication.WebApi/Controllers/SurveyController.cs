using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyApplication.Models.DTOs;
using SurveyApplication.Services.SurveyQuestions;

namespace SurveyApplication.Controllers
{
    public class SurveyController : Controller
    {
        IQuestionsService _questionsService { get; set; }

        public SurveyController(IQuestionsService questionsService)
        {
            _questionsService = questionsService;
        }

        [HttpPost]
        [Route("api/Survey/GetSurveyQuestions")]
        public IActionResult GetSurveyQuestions([FromBody] RequestDTO pageData)
        {
            try
            {
                return Ok(_questionsService.GetQuestions(pageData));
            }
            catch (Exception ex)
            {
                return new ContentResult() { StatusCode = 500 };
            }
        }
    }
}
