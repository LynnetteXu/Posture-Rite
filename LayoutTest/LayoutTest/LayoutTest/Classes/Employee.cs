using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace LayoutTest.Classes
{
    // Only Mapping class for data table
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ChairStatus { get; set; }

        public string Posture { get; set; }

        public int PostureScore { get; set; }

        public int MonthlyScore { get; set; }

        public int TodayScore { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public int BMI { get; set; }

        public int FocusHour { get; set; }

        public int Vibration { get; set; }

        public int RingDuration { get; set; }

        public bool PressureSensor { get; set; }

        public bool AngleSenssor { get; set; }

        // Store the path/file name for user avatar image
        public string Avatar { get; set; }

        public Employee()
        {

        }
    }
}
