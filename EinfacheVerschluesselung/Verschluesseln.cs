using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinfacheVerschluesselung
{
    static class Verschluesseln
    {
        //Variablen
        static char[] keyListe = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', ',', '.', '!', '?',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
            'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        static string pfadEingabe = @"C:\Test\Test.txt";
        static string pfadAusgabe = @"C:\Test\Ausgabe.txt";
        static string pfadEntschluesselt = @"C:\Test\Entschluesselt.txt";

        //Methoden
        public static void Auswahl()
        {
            string eingabe;
            bool check;

            do
            {
                check = true;
                Console.Clear();
                Console.WriteLine("Bitte wählen Sie: ");
                Console.WriteLine("(1) Verschlüsseln");
                Console.WriteLine("(2) Entschlüsseln");
                Console.WriteLine();
                Console.Write("Ihre Wahl: ");
                eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    Encrypt();
                }
                else if (eingabe == "2")
                {
                    Decrypt();
                }
                else
                {
                    check = false;
                    Console.WriteLine("Bitte nur 1 oder 2 wählen!");
                    Console.WriteLine("Weiter mit belibiger Taste...");
                    Console.ReadKey();
                }
            } while (!check);
        }
        static int EingabeSchluessel()
        {
            bool check;
            int key;

            do
            {
                Console.Clear();
                Console.Write("Bitte geben Sie Ihren Schlüssel ein: ");
                check = int.TryParse(Console.ReadLine(), out key);

                if (!check)
                {
                    Console.WriteLine("Bitte nur Ziffern eingeben!!");
                    Console.WriteLine("Weiter mit beliebiger Taste...");
                    Console.ReadKey();
                }
            } while (!check);

            return key;
        }
        static void Encrypt()
        {
            //Variablen
            string einlesen, auslesen;
            int index, key;
            List<string> listeEin = new List<string>();
            List<string> listeAus = new List<string>();

            //Aufruf Schlüssel-Wahl
            key = EingabeSchluessel();

            //Datei einlesen
            using (StreamReader sr = new StreamReader(pfadEingabe))
            {
                while ((einlesen = sr.ReadLine()) != null)
                {
                    listeEin.Add(einlesen);
                }
            }

            //Verschlüsseln
            foreach (string item in listeEin)
            {
                auslesen = "";
                for (int i = 0; i < item.Length; i++)
                {
                    index = Array.IndexOf(keyListe, item[i]) + key;

                    while (index >= keyListe.Length)
                    {
                        index -= keyListe.Length;
                    }

                    auslesen += keyListe[index].ToString();
                }
                listeAus.Add(auslesen);
            }

            //Datei ausgeben
            using (StreamWriter sw = new StreamWriter(pfadAusgabe, false))
            {
                foreach (string item in listeAus)
                {
                    sw.WriteLine(item);
                }
            }

            //Abschluss-Ausgabe
            Console.Clear();
            Console.WriteLine("Verschlüsselung erfolgreich abgeschlossen.");
        }
        static void Decrypt()
        {
            //Variablen
            string einlesen, auslesen;
            int index, key;
            List<string> listeEin = new List<string>();
            List<string> listeAus = new List<string>();

            //Aufruf Schlüssel-Wahl
            key = EingabeSchluessel();

            //Datei einlesen
            using (StreamReader sr = new StreamReader(pfadAusgabe))
            {
                while ((einlesen = sr.ReadLine()) != null)
                {
                    listeEin.Add(einlesen);
                }
            }

            //Entschlüsseln
            foreach (string item in listeEin)
            {
                auslesen = "";
                for (int i = 0; i < item.Length; i++)
                {
                    index = Array.IndexOf(keyListe, item[i]) - key;

                    while (index < 0)
                    {
                        index += keyListe.Length;
                    }

                    auslesen += keyListe[index].ToString();
                }
                listeAus.Add(auslesen);
            }

            //Datei ausgeben
            using (StreamWriter sw = new StreamWriter(pfadEntschluesselt, false))
            {
                foreach (string item in listeAus)
                {
                    sw.WriteLine(item);
                }
            }

            //Abschluss-Ausgabe
            Console.Clear();
            Console.WriteLine("Entschlüsselung erfolgreich abgeschlossen.");
        }
    }
}
