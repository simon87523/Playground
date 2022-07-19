namespace Playground
{
    internal class ConditionsDemo
    {


        public void IfDemo()
        {

            // wird nur ausgeführt wenn Bedingung zutrifft
            if (true)
            {
                Console.WriteLine("condition is true");
            }





            // unterschiedliche ausführungen für bedingung
            // erfüllt oder nicht erfüllt
            if (DateTime.Today.Day == 19)
            {
                Console.WriteLine("Today is the 19th");
            }
            else
            {
                Console.WriteLine("any other day");
            }

        }

        public void SwitchCaseDemo()
        {

            string? name = "Flo";


            switch (name)
            {
                case "Anna":
                    Console.WriteLine("Falsches Kind weil Anna");
                    break;

                case "Fabi":
                    Console.WriteLine("Nicht Tom weil Fabi.");
                    break;

                case "Tom":
                    Console.WriteLine("RICHIGES KIND");
                    break;

                default:
                    Console.WriteLine("kenne ich nicht");
                    break;
            }

        }

        public void ForLoopDemo()
        {

            for (int nr = 5; nr <= 10; nr++)
            {
                Console.WriteLine(nr);
            }
        }

        public void ForEachLoopDemo()
        {
            string[]? names = new[] { "Anna", "Tom", "Flo", "Andi" };

            foreach (string? child in names)
            {
                Console.WriteLine(child);
            }
        }


    }
}
