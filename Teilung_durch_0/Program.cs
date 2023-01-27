using System;

namespace Teilung_durch_0
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1 = 1523654, zahl2 = 0, erg;

            erg = zahl1 / zahl2;

            Console.WriteLine("Ergebnis: " + erg);

            //Ganzzahlen: Exception
            //Gleitkomma-Zahlen: unendlich
        }
    }
}
