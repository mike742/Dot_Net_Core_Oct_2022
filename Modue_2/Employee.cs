using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modue_2.Sample
{
    [Serializable()]
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} has ${Salary}";
        }
    }
}
