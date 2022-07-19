using Playground.ClassDemo;


// Fahrzeugflotte beim Benutzer erfragen
Vehicle[]? fleet = CreateVehicles(4);

// Preis des teuersten Fahrzeugs ermitteln
int maxPrice = GetGighestPrice(fleet);

// Fahrzeuge die den höchsten Preis haben ausgeben
foreach (Vehicle? vehicle in fleet)
    if (vehicle.Price == maxPrice)
        DisplayVehicleDetails(vehicle);



static int GetGighestPrice(Vehicle[] fleet)
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

static Vehicle[] CreateVehicles(int vehicleCount)
{

    //Fuhrpark
    Vehicle[] fleet = new Vehicle[vehicleCount];

    //Fuhrpark durch Benutzereingaben anlegen
    for (int i = 0; i < vehicleCount; i++)
    {
        var vehicle = new Vehicle();

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

static void DisplayVehicleDetails(Vehicle vehicle)
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
