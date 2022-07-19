using Playground.ClassDemo;


var bike = new Vehicle();

bike.Name = "Charlie";
bike.Mark = "Cube";
bike.NumberOfWheels = 2;
bike.Price = 1050;

DisplayVehicleDetails(bike);


void DisplayVehicleDetails(Vehicle vehicle)
{
    //Get Type
    switch (bike.NumberOfWheels)
    {
        case 1:
            vehicle.Type = "Unicycle";
            break;
        case 2:
            vehicle.Type = "Bike";
            break;
        case 3:
            vehicle.Type = "Tricycle";
            break;
        case 4:
            vehicle.Type = "Car";
            break;
        default:
            vehicle.Type = "Unknown";
            break; 
    }

    //Write properties
    Console.WriteLine($"Vehicle-Details ({vehicle.NumberOfWheels} wheels):");
    Console.WriteLine($"  Name: {vehicle.Name}");
    Console.WriteLine($"  Mark: {vehicle.Mark}");
    Console.WriteLine($"  Price: {vehicle.Price}");
    Console.WriteLine($"  Type: {vehicle.Type}");
}