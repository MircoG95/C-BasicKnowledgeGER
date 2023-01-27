using System;

namespace Sortieren_Von_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] liste = new int[30];

            for (int i = 0; i < liste.Length; i++)
            {
                liste[i] = rnd.Next(1, 101);
            }

            Console.Write("Vorher:");
            foreach (int item in liste)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Sortieren(liste, false);

            Console.Write("Nacher:");
            foreach (int item in liste)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        //1. Im Array der "StellenTausch" => Tauschen
        static void Tauschen(int[] li, int index1, int index2)
        {
            int temp = li[index1];
            li[index1] = li[index2];
            li[index2] = temp;
        }
        //2. Den Arry Sortieren => Sortieren
        static void Sortieren(int[] liste, bool aufsteigend)
        {
            for (int j = 0; j < liste.Length - 1; j++)
            {
                for (int i = j + 1; i < liste.Length; i++)
                {
                    if (aufsteigend)
                    {
                        if (liste[i] < liste[j])
                            Tauschen(liste, i, j);
                    }
                    else
                    {
                        if (liste[i] > liste[j])
                            Tauschen(liste, i, j);
                    }
                }
            }
        }
    }
}
