using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyyMate.Models
{
    public class SavedTimetable
    {
        public string[] TimeSlots { get; set; } = new string[6]; // "8-9", etc.
        public List<List<string>> Table { get; set; } = new List<List<string>>(); // 6 rows of 5 days
    }
}

