using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyyMate.Models
{
    public class Subject 
    {
        public string Name { get; set; }
        public string HoursPerWeek { get; set; } 
        public string Priority { get; set; }
        public int HoursLeft { get; set; }
    }
}
