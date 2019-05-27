using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.Models.DTOs
{
    public class ResponseDTO<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalNumberOfRecords { get; set; }
        public List<T> Data { get; set; }
    }
}
