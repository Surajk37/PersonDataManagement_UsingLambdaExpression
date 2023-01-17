using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagementLambda
{
    public class PersonDataManagement
    {
        public static void Retrieve_Top2Records_AgeBelow60(List<Person> list)     //UC2 -  Retriving Top 2 Records from list whose age is less than 60
        {
            var topRecords2 = list.Where(p => p.Age < 60).OrderBy(p => p.Age).Take(2);
            Console.WriteLine("\n\t\tTop 2 Person less than Age 60");
            Program.DisplayPersonDetails(topRecords2);
        }
        public static void RetriveAll_AgeBetween_13to18(List<Person> list)      //UC3 - Retrive all record of age between 13 - 18
        {
            var result = list.Where(p => p.Age > 13 && p.Age < 18);
            Console.WriteLine("\nRecord Between Age 13 to 18");
            Program.DisplayPersonDetails(result);
        }
    }
}
