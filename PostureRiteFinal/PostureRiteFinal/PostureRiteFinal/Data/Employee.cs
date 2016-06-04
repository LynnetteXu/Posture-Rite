using SQLite;
using System;

namespace PostureRiteFinal.Data
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public bool hasAppointment { get; set; }

        public int AppointmentSpecID { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public string Description { get; set; }

        public string ChairStatus { get; set; }

        public string Posture { get; set; }

        public int PostureScore { get; set; }

        public int TodayScore { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public int BMI { get; set; }

        public int FocusHour { get; set; }

        public int Vibration { get; set; }

        public int RingDuration { get; set; }

        public bool PressureSensor { get; set; }

        public bool AngleSenssor { get; set; }

        public string Gender { get; set; }

        // Store the path/file name for user avatar image
        public string Avatar { get; set; }
        public int SeatId { get; set; }
        public int Score { get; set; }
        public int MonthlyScore { get; set; }
        public int TotalScore { get; set; }
        public Employee(string name, int monthlyscore, int totalscore)
        {
            Name = name;
            MonthlyScore = monthlyscore;
            TotalScore = totalscore;
        }

        public Employee(string name)
        {
            Name = name;
            hasAppointment = false;
            AppointmentSpecID = 0;
        }
        public Employee()
        {

        }

        public override string ToString()
        {
            return string.Format("ID:{0} : {1}", ID, Name);
        }

    }
}
