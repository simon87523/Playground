using Playground.ClassDemo;

namespace Playground
{
    public class Program
    {
        public static void Main()
        {
            var fleet = VehicleActions.CreateVehicles(3);

            var expensiveVehicles = VehicleActions.GetVehiclesOverAveragePrice(fleet);

            VehicleActions.DisplayFleetDetails(expensiveVehicles);
          
        }
    }
}
