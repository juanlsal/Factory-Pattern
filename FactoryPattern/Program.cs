namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels would you like your created vehicle to have?");
            int numOfWheels = Convert.ToInt32(Console.ReadLine());
            IVehicle vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();

        }
    }
}
