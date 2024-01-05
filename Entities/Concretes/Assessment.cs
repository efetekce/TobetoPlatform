using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Assessment : Entity<int>
    {
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfQuestions { get; set; }
        public int Duration { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
