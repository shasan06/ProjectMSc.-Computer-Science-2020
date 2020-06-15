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
        public int Speed { get; set; }
        public int Timestamp { get; set; }
        public string QuestionId { get; set; }
        public string LevelId { get; set; }
        public bool Answer { get; set; }
    }
}
