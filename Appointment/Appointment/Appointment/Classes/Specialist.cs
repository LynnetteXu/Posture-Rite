using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.Classes
{
    public class Specialist
    {
        
        public string Name { get; set; }

        public int Appointments { get; set; }

        public string Specialty { get; set; }

        public string toString()
        {
            return Specialty + " : " + Name;
        }
        
    }
}
