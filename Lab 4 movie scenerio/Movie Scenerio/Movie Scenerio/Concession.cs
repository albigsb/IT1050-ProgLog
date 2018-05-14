namespace Movie_Scenerio
{
    class Concession
    {
        
        const double SmallSoda = 3.50;
        const double LargeSoda = 5.99;
        const double HotDog = 3.99;
        const double Popcorn = 4.50;
        const double Candy = 1.99;

        private double addSmallSoda;
        private double addLargeSoda;
        private double addHotDog;
        private double addPopCorn;
        private double addCandy;


        public static void SnackMenu()
        {
            System.Console.WriteLine("*=======================*");
            System.Console.WriteLine("*                       *");
            System.Console.WriteLine("* Snacks & Refreshments *");
            System.Console.WriteLine("*                       *");
            System.Console.WriteLine("*   Small Soda $3.50    *");
            System.Console.WriteLine("*   Large Soda $5.99    *");
            System.Console.WriteLine("*   Hot Dogs  $3.99     *");
            System.Console.WriteLine("*   Popcorn  $4.50      *");
            System.Console.WriteLine("*   Candy     $1.99     *");
            System.Console.WriteLine("*                       *");
            System.Console.WriteLine("*=======================*");

        }
    }    }
