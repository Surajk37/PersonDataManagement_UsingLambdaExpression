using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagementLambda
{
    public class Person
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"SSN:{SSN}  Name : {Name}  Address : {Address}  Age : {Age}";       //Overriden a method to display all data instead of displaying only name
        }
    }
}
