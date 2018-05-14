namespace Movie_Scenerio
{
    class Movie
    {

        string Title;
        double MatAdult;
        double MatChild;
        double MatSenior;
        double EveAdult;
        double EveChild;
        double EveSenior;

        public static void TheCinema()
        {
            System.Console.WriteLine("=============================");
            System.Console.WriteLine("+   Welcome to The Cinema   +");
            System.Console.WriteLine("=============================");

        }

        public static void Movietitles()
        {
            System.Console.WriteLine("*================================*");
            System.Console.WriteLine("*                                *");
            System.Console.WriteLine("*   1. Avengers: Infinity War    *");
            System.Console.WriteLine("*   2. Dead Pool 2               *");
            System.Console.WriteLine("*   3. Den of Thieves            *");
            System.Console.WriteLine("*                                *");
            System.Console.WriteLine("*================================*");
        }

        public static void MatineePrices()
        {
            System.Console.WriteLine("*=====================*");
            System.Console.WriteLine("*                     *");
            System.Console.WriteLine("*   Matinee Prices    *");
            System.Console.WriteLine("*   Children $3.99    *");
            System.Console.WriteLine("*   Adults   $5.99    *");
            System.Console.WriteLine("*   Seniors  $4.50    *");
            System.Console.WriteLine("*                     *");
            System.Console.WriteLine("*=====================*");
        }

        public static void EveningPrices()
        {
            System.Console.WriteLine("*=====================*");
            System.Console.WriteLine("*                     *");
            System.Console.WriteLine("*   Evening Prices    *");
            System.Console.WriteLine("*   Children $6.99    *");
            System.Console.WriteLine("*   Adults  $10.99    *");
            System.Console.WriteLine("*   Seniors  $8.50    *");
            System.Console.WriteLine("*                     *");
            System.Console.WriteLine("*=====================*");
        }



    }
}
