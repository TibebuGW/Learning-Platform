using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teaching.Models
{
    public class Quiz
    {
        public int Id{ get; set; }

        public string Question { get; set; }

        public string Choices { get; set; }

        public string Answer { get; set; }

        public int ChapterId { get; set; }
    }
}
