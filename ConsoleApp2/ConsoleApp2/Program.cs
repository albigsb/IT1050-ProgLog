
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            System.Console.WriteLine("[  Information for p1 ]");
           
            System.Console.Write("Enter Your First Name            :");
            p1.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter Your Last Name             :");
            p1.LastName = System.Console.ReadLine();         
            System.Console.Write("Enter Your Age                   :");
            p1.Age = int.Parse(System.Console.ReadLine());
            p1.Spouse = new Person();
            System.Console.Write("Enter Your Spouse's First Name   :");
            p1.Spouse.FirstName = System.Console.ReadLine();
            p1.Spouse.LastName = p1.LastName;
            System.Console.Write("Enter Your spouse's Age          :");
            p1.Spouse.Age = int.Parse(System.Console.ReadLine());


            Person p2 = new Person();
            System.Console.WriteLine("[ Information for p2 ]");
            
            System.Console.Write("Enter Your First Name            :");
            p2.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter Your Last Name             :");
            p2.LastName = System.Console.ReadLine();           
            System.Console.Write("Enter Your Age                   : ");
            p2.Age = int.Parse(System.Console.ReadLine());
            p2.Spouse = new Person();
            System.Console.Write("Enter Your Spouse's First Name   :");
            p2.Spouse.FirstName = System.Console.ReadLine();
            p2.Spouse.LastName = p2.LastName;
            System.Console.Write("Enter Your Spouse's Age          : ");
            p2.Spouse.Age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("[Printing Results]");
            
            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();
            Person.SumOfAllAges = p1.Age + p2.Age + p1.Spouse.Age + p2.Spouse.Age;

            Person.AverageAgeOfAll();

            System.Console.WriteLine("press any key to continues");
            System.Console.ReadKey();
        }
    }
}
