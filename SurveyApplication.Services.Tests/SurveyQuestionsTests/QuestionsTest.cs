using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurveyApplication.Services.SurveyQuestions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.Services.Tests.SurveyQuestionsTests
{
    [TestClass]
    public class QuestionsTest
    {
        ServiceProvider provider = null;

        public QuestionsTest()
        {
            // Setup inmemory db

            // Setup service
            var service = new ServiceCollection();

            service.AddTransient<IQuestionsService, QuestionsService>();

            provider = service.BuildServiceProvider();
        }

        [TestMethod]
        public void CanGetQuestions()
        {
            var questionsService = provider.GetService<IQuestionsService>();

            var requestData = new Models.DTOs.RequestDTO()
            {
                PageNumber = 1,
                PageSize = 1
            };
            Assert.IsTrue(questionsService.GetQuestions(requestData).TotalNumberOfRecords == 1);
        }


        [TestMethod]
        public void CanGetQuestionsWithOptions()
        {
            var questionsService = provider.GetService<IQuestionsService>();

            var requestData = new Models.DTOs.RequestDTO()
            {
                PageNumber = 1,
                PageSize = 1
            };

            var result = questionsService.GetQuestions(requestData);
            Assert.IsTrue(result.Data[0].Options.Count >= 1);
        }
    }
}
