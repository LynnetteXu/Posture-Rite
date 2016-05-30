using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.Classes
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public bool hasAppointment { get; set; }

        public int AppointmentSpecID { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public Employee(string name)
        {
            Name = name;
            hasAppointment = false;
            AppointmentSpecID = 0;
        }

        public override string ToString()
        {
            return string.Format("ID:{0} : {1}", ID, Name);
        }

    }
}
