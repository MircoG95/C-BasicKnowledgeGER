using System;
using System.Collections;
using System.Collections.Generic;

namespace DieListe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int>();

            liste.Add(15);
            liste.Add(36);
            liste.Add(42);

            Console.WriteLine(liste.Count);         //15, 36, 42

            liste.Add(12);
            liste.Add(36);

            Console.WriteLine(liste.Count);         //15, 36, 42, 12, 36
            Console.WriteLine("Zahl: " + liste[1]);

            liste.Remove(36);                       //15, 42, 12, 36

            Console.WriteLine("Zahl: " + liste[1]);
            Console.WriteLine("Zahl: " + liste[3]);

            //bool check = true;
            //while (check)
            //{
            //    check = liste.Remove(36);
            //}

            liste.RemoveAt(0);                      //42, 12, 36

            //Console.WriteLine(liste[3]);          //Vorsicht: Exception !!!

            List<Kontakt> telefonbuch = new List<Kontakt>();

            ArrayList li = new ArrayList();
            li.Add(15);
            li.Add("Hallo");
            li.Add(new Kontakt());
            li.Add(new List<string>());

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            var zahl = "Hallo";

            List<List<int>> li2 = new List<List<int>>();
            li2.Add(new List<int>());

            List<int>[] li3 = new List<int>[5];
            li3[0] = new List<int>();

            li3[0].Add(15);
        }
    }
}
