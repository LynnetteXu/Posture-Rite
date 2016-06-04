using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewList.Implementations
{
    public class Employee
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        public int SeatId { get; set; }
        public int Score { get; set; }
        public int MonthlyScore { get; set; }
        public int TotalScore { get; set; }
        public Employee(string name, int monthlyscore,int totalscore )
        {
            Name = name;
            MonthlyScore = monthlyscore;
            TotalScore = totalscore;
            //hasAppointment = false;
            //AppointmentSpecID = 0;
        }
        public Employee()
        {

        }

        public override string ToString()
        {
            return string.Format("ID:{0} : {1}", ID, Name);
        }
    };
}
