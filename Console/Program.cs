namespace Carfleet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("VD 123 567", "Mercedes-Benz", "Vito", "SV30-0169266");
            Truck truck = new Truck("VD 123 567", "Volvo", "FH16", "VOL45-0157966");

            DisplayCar(car);
            DisplayTruck(truck);
        }

        static private void DisplayCar(Vehicle car)
        {
            Console.WriteLine(car.ToString());
        }

        static private void DisplayTruck(Truck truck)
        {
            Console.WriteLine(truck.ToString());
        }
    }
}