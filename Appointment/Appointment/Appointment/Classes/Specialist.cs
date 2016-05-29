using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.Classes
{
    public class Specialist
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public int Appointments { get; set; }

        public string Specialty { get; set; }

        public Specialist()
        {

        }
        
        public override string ToString()
        {
            return string.Format("{0} : {1}", Specialty, Name);
        }

    }
}
