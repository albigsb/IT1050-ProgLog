namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
   
            System.Console.WriteLine("Hello, What is your First Name?");
            string firstName;
            firstName = System.Console.ReadLine();
            System.Console.Write("middle Intial.");
            string middleIntial;
            middleIntial = System.Console.ReadLine();
            System.Console.WriteLine("What is your Last Name?");
            string lastName;
            lastName = System.Console.ReadLine();
            string fullName;
            fullName = firstName + middleIntial + lastName;
            System.Console.WriteLine("Your name is : " + fullName);

            System.Console.Write("What is your height in feet(4,5,6)?");
            int heightFeet;
            heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many inches beyond your base feet height are you?");
            double heightInches;
            heightInches = double.Parse(System.Console.ReadLine());
            double totalHeightCM;
            totalHeightCM = (heightFeet * 12) + heightInches * 2.54;
            System.Console.WriteLine("Your total height in centimeters is :" + totalHeightCM);

            int age;
            System.Console.WriteLine("How old are you?");
            age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("You are a U.S citizen? (y/n):");
            bool isCitizen;
            isCitizen = System.Console.ReadLine().ToLower().StartsWith("y");
            bool canVote = isCitizen && age >= 18;

            System.Console.WriteLine(fullName);
            System.Console.WriteLine(totalHeightCM);
            System.Console.Write("You are elgible to vote?:");
            System.Console.WriteLine(canVote);









        }
    }
}
 