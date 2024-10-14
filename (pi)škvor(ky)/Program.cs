namespace _pi_škvor_ky_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<string> hraci_pole;
                hraci_pole = new List<string> {"1","2","3","4","5","6","7","8","9" };
                Console.WriteLine("|" + hraci_pole[0] + "|" + hraci_pole[1] + "|" + hraci_pole[2] + "|");
                Console.WriteLine("-------");
                Console.WriteLine("|" + hraci_pole[3] + "|" + hraci_pole[4] + "|" + hraci_pole[5] + "|");
                Console.WriteLine("-------");
                Console.WriteLine("|" + hraci_pole[6] + "|" + hraci_pole[7] + "|" + hraci_pole[8] + "|");
                Console.WriteLine("-------");
                Console.WriteLine("začína X");
                Console.WriteLine("kam chceš dát X");
                int x = Convert.ToInt32(Console.ReadLine());
                hraci_pole[x - 1] = "x";
                Console.WriteLine("|" + hraci_pole[0] + "|" + hraci_pole[1] + "|" + hraci_pole[2] + "|");
                Console.WriteLine("-------");
                Console.WriteLine("|" + hraci_pole[3] + "|" + hraci_pole[4] + "|" + hraci_pole[5] + "|");
                Console.WriteLine("-------");
                Console.WriteLine("|" + hraci_pole[6] + "|" + hraci_pole[7] + "|" + hraci_pole[8] + "|");
                Console.WriteLine("-------");
                Console.WriteLine("pokračuje O");
                Console.WriteLine("kam chceš dát O");
                int y = Convert.ToInt32(Console.ReadLine());
                hraci_pole[y - 1] = "O";



            }

        }
    }
}

