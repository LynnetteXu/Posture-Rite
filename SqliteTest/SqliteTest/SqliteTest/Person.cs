using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteTest
{
    public class Person
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("[Person: ID={0}, FirstName={1}, LastName={2}]", FirstName, LastName);
        }
    }
}
