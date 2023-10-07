internal class Program
{
    private static void Main(string[] args)
    {
        List<string> identifiable = new List<string>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if(input.Length == 1 && input[0].ToLower() == "end") { break; }
            if (input.Length == 2)
            {
                string model = input[0];
                string id_1 = input[1];
                Robots robots = new Robots(model, id_1);
                identifiable.Add(robots.ID);
            }
            else if (input.Length == 3) {
                string name = input[0];
                int age = int.Parse(input[1]);
                string id_2 = input[2];
                Citizens citizens = new Citizens(name, age, id_2); 
                identifiable.Add(citizens.ID);
            }
        }
        string lastDigits = Console.ReadLine();
        foreach(string index in identifiable) {
            if (index.EndsWith(lastDigits))
            {
                Console.WriteLine(index);
            }
        }
    }
}