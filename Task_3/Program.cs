internal class Program
{
    private static void Main(string[] args)
    {
        string driver_name = Console.ReadLine();
        Ferrari ferrari = new Ferrari(driver_name);
        Console.WriteLine($"{ferrari.model}/{ferrari.PushBrakePedal()}/{ferrari.PushGasPedal()}/{ferrari.DriverName}");
    }
}