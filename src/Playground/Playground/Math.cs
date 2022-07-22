using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal static class Math
    {
        /// <summary>
        /// Ersatz für %
        /// </summary>
        /// <param name="wert">wert % ...</param>
        /// <param name="divisor">... % divisor</param>
        /// <returns>Restwert</returns>
        public static int Rest(int wert, int divisor)
        {
            int i = wert / divisor;
            return wert - (divisor * i);
        }

        /// <summary>
        /// Berechnet die Primzahlen bis zu einer stimmer Zahl
        /// </summary>
        /// <param name="primzahlenBis">Zahl bis zu dem die Primzahlen berechnet werden</param>
        /// <returns>Arrey mit allen Primzahlen</returns>
        public static int[] SiebDesEratosthenes(int primzahlenBis)
        {
            // Array mit allen Zahlen erstellen
            var zahlen = new int[primzahlenBis + 1];
            for (int i = 0; i <= primzahlenBis; i++)
            {
                if (i < 2)
                    zahlen[i] = 0;
                else
                    zahlen[i] = 1;
            }

            // Primzahlen erkennen und (primzahl als 1 sonst als 0) speichern
            for (int i = 2; i < primzahlenBis; i++)
            {
                // Wenn die Zahl nicht schon als NICHT Primzahl makiert ist
                if (zahlen[i] != 0)
                {
                    if (CheckIfPrimzahl(i) != true)
                    {
                        zahlen[i] = 0;
                        // Vielfaches der (nicht Prim)Zahl aussortieren
                        int c = i * 2;
                        for (int multiplikator = 2; c <= primzahlenBis; c = multiplikator * i)
                        {
                            zahlen[multiplikator * i] = 0;
                            multiplikator++;
                        }
                    }
                }
            }

            /// Primzahlen Speichern und ausgeben
            // Primzahlen zählen
            int counter = 0;
            for (int i = 0; i < primzahlenBis; i++)
            {
                if (zahlen[i] == 1)
                    counter++;
            }
            // Primzahlen im Arrey speichern
            var primzahlen = new int[counter];
            int number = 0;
            for (int i = 0; i < primzahlenBis; i++)
            {
                if (zahlen[i] == 1)
                {
                    primzahlen[number] = i;
                    number++;
                }
            }
            return primzahlen;
        }

        /// <summary>
        /// Überprüft ob eine Zahl eine Primzahl ist
        /// </summary>
        /// <param name="Zahl">zu überprüfende Zahl</param>
        /// <returns>true/false</returns>
        public static bool CheckIfPrimzahl(int Zahl)
        {
            bool primzahl = true;
            for (int i = 2; i < Zahl; i++)
            {
                if ((Zahl % i) == 0)
                    primzahl = false;
            }
            return primzahl;
        }

        /// <summary>
        /// Anzeige zu "SiebDesEratosthenes"
        /// </summary>
        /// <param name="primzahlenBis">Zahlbis zu dem die Primzahlen berechnet werden</param>
        public static void DisplayPrimzahlen(int primzahlenBis)
        {
            var primzahlen = Math.SiebDesEratosthenes(primzahlenBis);
            // Primzahlen ausgeben
            Console.WriteLine($"Primzahlen von 1 bis {primzahlenBis}:");
            for (int i = 0; i < primzahlen.Length; i++)
                Console.WriteLine($"{i + 1}: {primzahlen[i]}");
            Console.ReadLine();
        }
    }
}
