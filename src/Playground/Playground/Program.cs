using Playground.ClassDemo;

namespace Playground
{
    public class Program
    {
        public static void Main()
        {


            for (var wert = 1; wert < 500; wert++)
            { 
                for (var divisor = 3; divisor < 15; divisor++)
                {

                    var ergebnis = wert % divisor;
                    var unserErgebnis = Math.Rest(wert, divisor);

                    if (ergebnis != unserErgebnis)
                        throw new Exception("falsches Ergebnis");

                }
            }

            Console.WriteLine("alles richtig");
            Console.ReadLine();


        //    int accuracy = 20;
        //    double goldenerSchnitt = Formeln.GoldenerSchnitt(accuracy);
        //    Console.WriteLine($"Golderner Schnitt (mit Genauigkeit {accuracy}): {goldenerSchnitt}");
        //    Console.ReadLine();
        }
    }
}
