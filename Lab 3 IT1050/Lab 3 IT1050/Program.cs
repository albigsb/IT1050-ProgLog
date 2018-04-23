
namespace Lab_3_IT1050
{
    class Program
    {
        static void Main(string[] args)
        {


            var John = new Instructor("John", "English");
            var Mike = new Instructor("Mike", "Math");
            var Jane = new Student("Jane", John);
            var Joe = new Student("Joe", John);
            var Melissa = new Student("Melissa", Mike);
            var Matt = new Student("Matt", Mike);

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            John.Print();
            Mike.Print();

            Jane.Print();
            Joe.Print();
            Melissa.Print();
            Matt.Print();

            System.Console.WriteLine("press any key to continues");
            System.Console.ReadKey();

        }
    }
}
