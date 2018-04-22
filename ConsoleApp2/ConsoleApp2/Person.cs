
namespace ConsoleApp2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.LastName + " " + this.FirstName;
        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + " " + "("+Age+")");
        }
        public static void AverageAgeOfAll()
        {
            System.Console.WriteLine("Average Age is            :" + SumOfAllAges/4);
        }

    }
}
