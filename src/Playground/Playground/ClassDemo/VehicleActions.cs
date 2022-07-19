namespace Playground.ClassDemo
{
    /// <summary>
    /// Diese Klasse stellt Aktionen rund um die Fahrzeugflotte bereit
    /// </summary>
    internal class VehicleActions
    {
        /// <summary>
        /// Ermittelt den Preis des teuersten Fahrzeugs
        /// </summary>
        /// <param name="fleet">liste der Fahrzeuge deren Preis untersucht werden soll</param>
        /// <returns>Preis des teuersten Fahrzeugs</returns>
        public static int GetGighestPrice(Vehicle[] fleet)
        {

            int max = 0;

            foreach (Vehicle? vehicle in fleet)
            {
                if (vehicle.Price > max)
                {
                    max = vehicle.Price;
                }
            }

            return max;
        }

        /// <summary>
        /// Erstellt Fahrzeuge aus Benutzereingaben
        /// </summary>
        /// <param name="vehicleCount">Anzahl der zu erstellenden Fahrzeuge</param>
        /// <returns>Liste von Fahrzeugen basierend auf Benutzereingaben</returns>
        public static Vehicle[] CreateVehicles(int vehicleCount)
        {

            //Fuhrpark
            Vehicle[] fleet = new Vehicle[vehicleCount];

            //Fuhrpark durch Benutzereingaben anlegen
            for (int i = 0; i < vehicleCount; i++)
            {
                Vehicle? vehicle = new();

                //Enter Variables
                Console.WriteLine($"Vehicle {i}");
                Console.WriteLine("Enter name:");
                vehicle.Name = Console.ReadLine() ?? "";
                Console.WriteLine("Enter mark:");
                vehicle.Mark = Console.ReadLine() ?? "";
                Console.WriteLine("Enter number of wheels:");
                vehicle.NumberOfWheels = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine("Enter price:");
                vehicle.Price = int.Parse(Console.ReadLine() ?? "0");

                //Get Type
                vehicle.Type = vehicle.NumberOfWheels switch
                {
                    1 => "Unicycle",
                    2 => "Bike",
                    3 => "Tricycle",
                    4 => "Car",
                    _ => "Unknown",
                };

                //Save Information
                fleet[i] = vehicle;

            }

            return fleet;

        }


        public static void DisplayFleetDetails(Vehicle[] fleet)
        {
            foreach (var vehicle in fleet)
            {
                DisplayVehicleDetails(vehicle);
            }

        }

        /// <summary>
        /// Gibt ein Fahrzeug auf der Komandozeile aus
        /// </summary>
        /// <param name="vehicle">Fahrzeug, das angezeigt werden soll.</param>
        public static void DisplayVehicleDetails(Vehicle vehicle)
        {
            //Get Type
            vehicle.Type = vehicle.NumberOfWheels switch
            {
                1 => "Unicycle",
                2 => "Bike",
                3 => "Tricycle",
                4 => "Car",
                _ => "Unknown",
            };

            //Write properties
            DisplayProperties(vehicle);

            static void DisplayProperties(Vehicle vehicle)
            {
                Console.WriteLine($"Vehicle-Details ({vehicle.NumberOfWheels} wheels):");
                Console.WriteLine($"  Name: {vehicle.Name}");
                Console.WriteLine($"  Mark: {vehicle.Mark}");
                Console.WriteLine($"  Price: {vehicle.Price}");
                Console.WriteLine($"  Type: {vehicle.Type}");
            }
        }

        /// <summary>
        /// Gibt den Durchschnitzpreis von Fahrzeugen aus
        /// </summary>
        /// <param name="fleet">Fahrzeuge aus denen der Durchschnitzperis berechtet wird</param>
        /// <param name="vehicleCount">Anzahl der Fahrzeuge</param>
        /// <returns>Druchschnitzpreis der Fahrzeuge</returns>
        public static int GetAvargePrice(Vehicle[] fleet, int vehicleCount)
        {
            int AvargePrice;
            int totalPrice = 0;
            // Berechnet Gesamtpreis der Fahrzeuge
            for (int i = 0; i < vehicleCount; i++)
            {
                totalPrice += fleet[i].Price;
            }
            // Berechnet Durchschnitzpreis
            AvargePrice = totalPrice / vehicleCount;
            return AvargePrice;
        }

        /// <summary>
        /// Gibt Fahreuge über dem Durchschnitzpreis aus
        /// </summary>
        /// <param name="fleet">Fahrzeuge</param>
        /// <param name="AvargePrice">Durchschnitzpreis der Fahrzeuge</param>
        /// <param name="vehicleCount">Anzahl der Fahrzeuge</param>
        /// <returns></returns>
        public static Vehicle[] GetVehiclesOverAveragePrice(Vehicle[] fleet)
        {
            int fleetSize = fleet.Length;
            int avargePrice = GetAvargePrice(fleet, fleetSize);
            int overpricedVehicleCount = HowManyVehiclesOverCertainPrice(fleetSize, avargePrice, fleet);

            Vehicle[]? overPricedVehicles = new Vehicle[overpricedVehicleCount];
            int alreadySavedVehicles = 0;


            // Speichert die Fahrzeuge über dem Durchschnitzpreis
            foreach (Vehicle vehicle in fleet)
            {
                if (vehicle.Price > avargePrice)
                {
                    overPricedVehicles[alreadySavedVehicles] = vehicle;
                    alreadySavedVehicles++;
                }
            }



            //for (int i = 0; i < overpricedVehicleCount; i++)
            //{
            //    if (fleet[i].Price > AvargePrice)
            //    {
            //        overPricedVehicles[i] = fleet[i];
            //    }
            //}
            return overPricedVehicles;
        }

        /// <summary>
        /// Gibt die Anzahl der Farzeuge über dme Durchschnitzpreis aus
        /// </summary>
        /// <param name="vehicleCount">Anzahl der Fahrzeuge</param>
        /// <param name="AvargePrice">Durchschnitzpreis der Fahrzeuge</param>
        /// <param name="fleet">Fahrzeuge</param>
        /// <returns></returns>
        public static int HowManyVehiclesOverCertainPrice(int vehicleCount, int AvargePrice, Vehicle[] fleet)
        {
            int overpricedVehicleCount = 0;
            // Zählt wie viele Fahrzeuge über Durchschnitzpreis
            for (int i = 0; i < vehicleCount; i++)
            {
                if (fleet[i].Price > AvargePrice)
                {
                    overpricedVehicleCount++;
                }
            }
            return overpricedVehicleCount;
        }
    }
}
