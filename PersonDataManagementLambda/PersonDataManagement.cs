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
            Console.WriteLine("\n\t\tRecord Between Age 13 to 18");
            Program.DisplayPersonDetails(result);
        }
        public static void Retrive_AverageAge(List<Person> list)      //UC4 - Retrive average age in the list
        {
            var resAverage = list.Average(p => p.Age);
            Console.WriteLine("\n\tAverage of Age is : {0}", Math.Round(resAverage, 2));   // in thid case answer having two number after decimal point
            Console.WriteLine("\tAverage of Age is : {0}", Math.Floor(resAverage));   // in thid case answer is  integer value
        }
        public static void ToCheck_NameisPresentorNot(List<Person> list, string input)     //UC5 - Checking for specific name present or not
        {
            var result = list.Where(p => p.Name == input).ToList();

            if (result.Count > 0)
            {
                Console.WriteLine("\n" + input + " -  Name is Present in list");
            }

            else
            {
                Console.WriteLine("\n" + input + " -  Name is not Present in list");
            }
        }
        public static void ToSkipAge_Lessthan60(List<Person> list)      //UC6 - To get age which is greater than 60
        {
            var skip = list.OrderBy(p => p.Age).SkipWhile(p =>  p.Age < 60);
           Console.WriteLine("\nGreater than 60 Age are");
            Program.DisplayPersonDetails(skip);

        }
    }
}
