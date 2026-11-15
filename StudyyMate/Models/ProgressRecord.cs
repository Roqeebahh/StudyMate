using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyyMate.Models
{
    public class ProgressRecord
    {
        public string SubjectName { get; set; }
        public int TotalHours { get; set; }
        public int HoursCompleted { get; set; }

        public int GetProgressPercentage()
        {
            if (TotalHours == 0) return 0;
            return (int)((HoursCompleted / (double)TotalHours) * 100);
        }
    }
}
