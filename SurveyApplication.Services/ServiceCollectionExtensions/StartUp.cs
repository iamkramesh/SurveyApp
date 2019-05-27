using Microsoft.Extensions.DependencyInjection;
using SurveyApplication.DAL.ServiceCollectionExtensions;
using SurveyApplication.Services.SurveyQuestions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.Services.ServiceCollectionExtensions
{
    public static class StartUp
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddDAL();


            service.AddTransient<IQuestionsService, QuestionsService>();
        }
    }
}
