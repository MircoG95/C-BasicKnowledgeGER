using System;

namespace ZufallZahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random zufall = new Random();
            int zahl;

            for (int i = 0; i < 100; i++)
            {
                zahl = zufall.Next(1, 101);
                
                Console.WriteLine(zahl);
            }
        }
    }
}
