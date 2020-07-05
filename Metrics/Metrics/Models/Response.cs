using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    public class Response
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public double MarksObtained { get; set; }
        public int LevelId { get; set; }
        public string QuestionId { get; set; }
        public bool Answer { get; set; }
        public string Test { get; set; }
    }
}
