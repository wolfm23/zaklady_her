using Microsoft.VisualBasic;

namespace zaklady_her
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Hráč 1 vyber se kámen ,nůžky ,nebo papír");
                string x = Console.ReadLine();
                //if (x ! "kámen" && x ! "nůžky" && x ! "papír")
                //{
                //    Console.WriteLine("musíš si vybrat KÁMEN ,NŮŽKY ,NEBO PAPÍR");
                //    y = Console.ReadLine();
                //}
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine("hráč 2 vyber se kámen ,nůžky ,nebo papír");
                string y = Console.ReadLine();

               //if (y = !"kámen" && y = !"nůžky" && y = !"papír")
               //{
               //     Console.WriteLine("musíš si vybrat KÁMEN ,NŮŽKY ,NEBO PAPÍR");
               //     y = Console.ReadLine(); 
               //}

                if (y == "kámen" && x == "kámen")
                    {
                        Console.WriteLine(".");
                        Console.WriteLine("Remíza");
                        Console.WriteLine(".");
                    }

                if (y == "nůžky" && x == "nůžky")
                    {
                        Console.WriteLine(".");
                        Console.WriteLine("Remíza");
                        Console.WriteLine(".");
                    }

                if (y == "kámen" && x == "kámen")
                    {
                        Console.WriteLine(".");
                        Console.WriteLine("Remíza");
                        Console.WriteLine(".");
                    }


                if (y == "kámen" && x == "nůžky")
                    {
                        Console.WriteLine(".");
                        Console.WriteLine("hráč 2 vyhrál");
                        Console.WriteLine(".");
                    }

                if (y == "kámen" && x == "papír")
                    {
                        Console.WriteLine(".");
                        Console.WriteLine("hráč 1 vyhrál");
                        Console.WriteLine(".");
                    }

                if (y == "nůžky" && x == "kámen")
                    {
                        Console.WriteLine(".");
                        Console.WriteLine("hráč 1 vyhrál");
                        Console.WriteLine(".");
                    }

                if (y == "nůžky" && x == "papír")
                    {
                        Console.WriteLine(".");
                        Console.WriteLine("hráč 2 vyhrál");
                        Console.WriteLine(".");

                    }

                if (y == "papír" && x == "kámen")
                    {
                        Console.WriteLine(".");
                        Console.WriteLine("hráč 2 vyhrál");
                        Console.WriteLine(".");
                    }

                if (y == "papír" && x == "nůžky")
                    {
                        Console.WriteLine(".");
                        Console.WriteLine("hráč 1 vyhrál");
                        Console.WriteLine(".");
                    }
            }
        }
    }
}
