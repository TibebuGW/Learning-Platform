using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teaching.Models
{
    public class Subject
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public int Numberofchapters { get; set; }

        public int GradeId{ get; set; }
    }
}
