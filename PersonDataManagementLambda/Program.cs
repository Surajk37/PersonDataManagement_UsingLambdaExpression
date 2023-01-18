namespace PersonDataManagementLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----------------------------------------------------\n\t\tWelcome To Person Data Management by using Lambda Expression\n\t\t-----------------------------------------------------\n");
           //UC1- Created object of list
            List<Person> listOfPerson = new List<Person>();
            AddingPersonDetails(listOfPerson);
            //UC2-Top 2 records
            PersonDataManagement.Retrieve_Top2Records_AgeBelow60(listOfPerson);
            //UC3- Age between 13 - 18
            PersonDataManagement.RetriveAll_AgeBetween_13to18(listOfPerson);
            //UC4- Age Average
            PersonDataManagement.Retrive_AverageAge(listOfPerson);   
            Console.ReadLine();
        }
        public static void AddingPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 0, Name = "Suraj\t",Address = "Kolhapur\t",Age = 23 });     //adding data into list
            list.Add(new Person() { SSN = 1, Name = "Omkar\t",Address = "Gadhinglaj\t",Age = 12 });
            list.Add(new Person() { SSN = 2, Name = "Sourav\t",Address = "Kagal\t",Age = 15 });
            list.Add(new Person() { SSN = 3, Name = "Harshal\t",Address = "Pune\t",Age = 30 });
            list.Add(new Person() { SSN = 4, Name = "Atharva\t",Address = "Mumbai\t",Age = 70 });
            list.Add(new Person() { SSN = 5, Name = "Ishwar\t",Address = "Beed\t",Age = 14 });
            list.Add(new Person() { SSN = 6, Name = "Sanket\t",Address = "Jaipur\t",Age = 63 });
            Console.WriteLine("\t\tDisplaying data of all persons");
            DisplayPersonDetails(list);
        }

        public static void DisplayPersonDetails(IEnumerable<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}