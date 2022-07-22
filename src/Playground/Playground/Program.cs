using Playground.ClassDemo;

namespace Playground
{
    public class Program
    {
        public static void Main()
        {
            int accuracy = 20;
            double goldenerSchnitt = Formeln.GoldenerSchnitt(accuracy);
            Console.WriteLine($"Golderner Schnitt (mit Genauigkeit {accuracy}): {goldenerSchnitt}");
            Console.ReadLine();
        }
    }
}
