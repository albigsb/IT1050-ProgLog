namespace Movie_Scenerio
{
    class Program
    {
        static void Main(string[] args)
        {
            double MatAdultPrice = 5.99;
            double MatChildPrice = 3.99;
            double MatSeniorPrice = 4.50;
            double EveAdultPrice = 10.99;
            double EveChildPrice = 6.99;
            double EveSeniorPrice = 8.50;


            int MatAdult;
            int MatChild;
            int MatSenior;
            int EveAdult;
            int EveChild;
            int EveSenior;

            Movie.TheCinema();
           
            System.Console.WriteLine();


            System.Console.WriteLine("Today's movie selections are: ");


            System.Console.WriteLine();

            Movie.Movietitles();

            System.Console.WriteLine();

            System.Console.WriteLine("Which movie would you like to see?");

            string User = System.Console.ReadLine();
            bool ContainsAvengers = (User.ToLower().Contains("veng"));
            bool ContainsDead = (User.ToLower().Contains("ead"));
            bool ContainsDen = (User.ToLower().Contains("ieves"));



            int NumbUser;
            int.TryParse(User, out NumbUser);
          
            System.Console.WriteLine();

            if (NumbUser == 1 || NumbUser == 2 || NumbUser == 3 || ContainsAvengers || ContainsDead || ContainsDen)
            {

                System.Console.WriteLine("Matinee or Evening?(M or E)");


                User = System.Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("Not A Valid Entry, Try Again");
            }
            System.Console.WriteLine();


            bool ContainsE = (User.ToUpper().Contains("E"));
            bool ContainsM = (User.ToUpper().Contains("M"));

            if (ContainsM)
            {

                Movie.MatineePrices();

                System.Console.WriteLine();
                System.Console.WriteLine("How many adults tickets?");
                MatAdult = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine();
                System.Console.WriteLine("How many Senior tickets?");
                MatSenior = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine();
                System.Console.WriteLine("How many children tickets?");
                MatChild = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine();
               
            }
            else if (ContainsE)
            {

                Movie.EveningPrices();




                System.Console.WriteLine();
                System.Console.WriteLine("How many adults tickets?");
                EveAdult = int.Parse(System.Console.ReadLine());


                System.Console.WriteLine();
                System.Console.WriteLine("How many children tickets?");
                EveChild = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine();
                System.Console.WriteLine("How many Senior tickets?");
                EveSenior = int.Parse(System.Console.ReadLine());


            }

                System.Console.WriteLine();
                System.Console.WriteLine("Would like any snacks and/or refreshments?");

            Concession TheStand = new Concession();
            

            User = System.Console.ReadLine();

            bool ContainsY = (User.ToUpper().Contains("Y"));
            System.Console.WriteLine();

            if (ContainsY)
            {
                Concession.SnackMenu();
                System.Console.WriteLine();
                System.Console.WriteLine("How many small sodas?");
                
                System.Console.WriteLine("How many large sodas?");
                System.Console.WriteLine("How many Hot Dogs?");
                System.Console.WriteLine("How many popcorns?");
                System.Console.WriteLine("How many candies?");

            }
            else
            {




            }
            

         













        }
    }
   
}

