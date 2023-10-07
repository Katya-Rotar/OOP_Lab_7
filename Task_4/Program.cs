internal class Program
{
    private static void Main(string[] args)
    {
        Smartphone smartphone = new Smartphone();
        string[] numbers = Console.ReadLine().Split(' ');
        string[] sites = Console.ReadLine().Split(' ');

        foreach (string number in numbers) {
            Console.WriteLine(smartphone.Call(number));
        }
        foreach (string site in sites)
        {
            Console.WriteLine(smartphone.Browse(site));
        }
    }
}