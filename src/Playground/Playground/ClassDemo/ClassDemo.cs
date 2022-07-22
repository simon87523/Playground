namespace Playground.ClassDemo
{
    /// <summary>
    /// Diese Klasse stellt Aktionen rund um die Fahrzeugflotte bereit
    /// </summary>
    internal class VehicleActions
    {
        /// <summary>
        /// Gibt den Fahrzeugtyp anhand der Anzahl der Räder aus
        /// </summary>
        /// <param name="vehicle">Fahrzeug</param>
        /// <returns>Fahrzeugtyp als string</returns>
        public static string GetType(Vehicle vehicle)
        {
            switch (vehicle.NumberOfWheels)
            {
                case 1:
                    vehicle.Type = "Unicycle";
                    return vehicle.Type;
                case 2:
                    vehicle.Type = "Bike";
                    return vehicle.Type;
                case 3:
                    vehicle.Type = "Tricycle";
                    return vehicle.Type;
                case 4:
                    vehicle.Type = "Car";
                    return vehicle.Type;
                default:
                    vehicle.Type = "Unknown";
                    return vehicle.Type;
            }
        }

        /// <summary>
        /// Ermittelt den Preis des teuersten Fahrzeugs
        /// </summary>
        /// <param name="fleet">liste der Fahrzeuge deren Preis untersucht werden soll</param>
        /// <returns>Preis des teuersten Fahrzeugs</returns>
        public static int GetHighestPrice(Vehicle[] fleet)
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
        /// Gibt die teuersten Fahrzeuge aus
        /// </summary>
        /// <param name="fleet">Fahrzeuge</param>
        /// <returns>teuerste Fahrzeuge</returns>
        public static Vehicle[] GetMostExpensiveVehicles(Vehicle[] fleet)
        {
            int highesPrice = GetHighestPrice(fleet);
            int count = VehicleActions.HowManyVehiclesWithCertainPrice(fleet.Length, highesPrice, fleet);
            Vehicle[]? expensiveVehicles = new Vehicle[count];
            int i = 0;
            foreach (Vehicle? vehicle in fleet)
            {
                if (vehicle.Price == highesPrice)
                {
                    expensiveVehicles[i] = vehicle;
                    i++;
                }
            }
            return expensiveVehicles;
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

        /// <summary>
        /// Gibt die Werte einer Ansammlung von Fahrzeugen in der Console aus
        /// </summary>
        /// <param name="fleet">Fahrzeuge</param>
        public static void DisplayFleetDetails(Vehicle[] fleet)
        {
            foreach (Vehicle? vehicle in fleet)
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
        /// Gibt die Anzahl der Farzeuge über einem Bestimmten Preis aus
        /// </summary>
        /// <param name="vehicleCount">Anzahl der Fahrzeuge</param>
        /// <param name="Price">Preis zum Vergleichen</param>
        /// <param name="fleet">Fahrzeuge</param>
        /// <returns></returns>
        public static int HowManyVehiclesOverCertainPrice(int vehicleCount, int Price, Vehicle[] fleet)
        {
            int overpricedVehicleCount = 0;
            // Zählt wie viele Fahrzeuge über Durchschnitzpreis
            for (int i = 0; i < vehicleCount; i++)
            {
                if (fleet[i].Price > Price)
                {
                    overpricedVehicleCount++;
                }
            }
            return overpricedVehicleCount;
        }

        /// <summary>
        /// Gibt die Anzahl der Farzeuge unter einem Bestimmten Preis aus
        /// </summary>
        /// <param name="vehicleCount">Anzahl der Fahrzeuge</param>
        /// <param name="Price">Preis zum Vergleichen</param>
        /// <param name="fleet">Fahrzeuge</param>
        /// <returns></returns>
        public static int HowManyVehiclesUnderCertainPrice(int vehicleCount, int Price, Vehicle[] fleet)
        {
            int overpricedVehicleCount = 0;
            // Zählt wie viele Fahrzeuge über Durchschnitzpreis
            for (int i = 0; i < vehicleCount; i++)
            {
                if (fleet[i].Price < Price)
                {
                    overpricedVehicleCount++;
                }
            }
            return overpricedVehicleCount;
        }

        /// <summary>
        /// Gibt die Anzahl der Farzeuge mit einem Bestimmten Preis aus
        /// </summary>
        /// <param name="vehicleCount">Anzahl der Fahrzeuge</param>
        /// <param name="Price">Preis zum Vergleichen</param>
        /// <param name="fleet">Fahrzeuge</param>
        /// <returns></returns>
        public static int HowManyVehiclesWithCertainPrice(int vehicleCount, int Price, Vehicle[] fleet)
        {
            int VehicleCount = 0;
            // Zählt wie viele Fahrzeuge über Durchschnitzpreis
            for (int i = 0; i < vehicleCount; i++)
            {
                if (fleet[i].Price == Price)
                {
                    VehicleCount++;
                }
            }
            return VehicleCount;
        }

        /// <summary>
        /// Erstellt Fahrzeuge aus einer Textdatei
        /// </summary>
        /// <param name="filename">Name der Datei</param>
        /// <returns>Fahrzeuge</returns>
        public static Vehicle[] LoadFromFile(string filename)
        {
            string[]? lines = File.ReadAllLines(filename);
            Vehicle[]? vehicles = new Vehicle[lines.Length - 1];
            for (int i = 1; i < lines.Length; i++)
            {
                string? currentLine = lines[i];
                string[]? parts = currentLine.Split('|');

                Vehicle? newVehile = new()
                {
                    Name = parts[0],
                    Mark = parts[1],
                    Price = int.Parse(parts[2]),
                    NumberOfWheels = int.Parse(parts[3])
                };
                newVehile.Type = VehicleActions.GetType(newVehile);

                vehicles[i - 1] = newVehile;


            }
            return vehicles;
        }

        /// <summary>
        /// Gibt Fahreuge über dem Durchschnitzpreis aus
        /// </summary>
        /// <param name="fleet">Fahrzeuge</param>
        /// <returns>Fahrzeuge unter dem Durchschnitzpreis</returns>
        public static Vehicle[] GetVehiclesUnderAvargePrice(Vehicle[] fleet)
        {
            Vehicle[]? vehicles = new Vehicle[fleet.Length];
            // Wie viel Fahrzeuge unter Durchschnitzpreis -> int c
            for (int i = 0; i < fleet.Length; i++)
            {
                vehicles[i] = new Vehicle();
                vehicles[i] = fleet[i];
            }
            int avargePrice = GetAvargePrice(vehicles, fleet.Length);
            int c = HowManyVehiclesUnderCertainPrice(vehicles.Length, avargePrice, vehicles);

            // Speichert die Fahrzeuge unter dem Durchschnitzpreis
            Vehicle[]? cheapVehicles = new Vehicle[c];
            int alreadySavedVehicles = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Price < avargePrice)
                {
                    cheapVehicles[alreadySavedVehicles] = vehicle;
                    alreadySavedVehicles++;
                }
            }
            return cheapVehicles;
        }

        /// <summary>
        /// Gibt die teuersten Fahrzeuge unter dem Durchschnitzpreis in der Console aus
        /// </summary>
        /// <param name="vehicles">Fahrzeuge</param>
        public static void DisplayMostExpensiveVehiclesUnderAvagrePrice(Vehicle[] vehicles)
        {
            int avargePrice = VehicleActions.GetAvargePrice(vehicles, vehicles.Length);
            vehicles = VehicleActions.GetVehiclesUnderAvargePrice(vehicles);
            vehicles = VehicleActions.GetMostExpensiveVehicles(vehicles);
            Console.WriteLine($"Teuerstes Fahrzeug unter dem Durchschnitzpreis ({avargePrice} Euro):");
            VehicleActions.DisplayFleetDetails(vehicles);
        }
    }

    internal class Schach
    {
        /// <summary>
        /// Zeichnet ein Schachbrett in die Console
        /// </summary>
        /// <param name="8">Größe des Feldes (max 7)</param>
        public static void DrawField()
        {
            for (int x = 0; x < 8; x++)
            {

                for (int y = 0; y < 8; y++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("o ");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Zeichnet Quadrat in einem Quadat welches eine bestimmte entfernung vom Mittelpunkt hat
        /// </summary>
        /// <param name="size">Größe</param>
        /// <param name="range">Entfernung vom Mitelpunkt</param>
        public static void DrawInRange(int size, int range)
        {

            for (int x = 0; x < size; x++)
            {

                for (int y = 0; y < size; y++)
                {
                    if (CheckIfInRange(range, y, x, size) == true)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("o ");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Überprüft die Entfernung zum Mittelpunkt (DrawInRange)
        /// </summary>
        /// <param name="range">Reichweite</param>
        /// <returns>true/false</returns>
        public static bool CheckIfInRange(int range, int y, int x, int size)
        {
            double vergleichswert = (size / 2) - 0.5;
            bool inRange = y - vergleichswert <= range && y - vergleichswert >= (range * -1) && x - vergleichswert <= range && x - vergleichswert >= (range * -1);
            return inRange;
        }
    }
}
