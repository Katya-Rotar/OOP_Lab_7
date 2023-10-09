using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Citizen> citizen = new List<Citizen>();
        List<Rebel> rebel = new List<Rebel>();
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string name = input[0].ToLower();
            if (input.Length == 4 && !citizen.Any(c => c.Name.ToLower() == name.ToLower()))
            {
                int age = int.Parse(input[1]);
                string id = input[2];
                DateTime birthdate = DateTime.Parse(input[3]);
                Citizen citizens = new Citizen(name, age, id, birthdate);
                citizen.Add(citizens);
            }
            else if (input.Length == 3 && !rebel.Any(r => r.Name.ToLower() == name.ToLower()))
            {
                int age = int.Parse(input[1]);
                string group = input[2];
                Rebel rebels = new Rebel(name, age, group);
                rebel.Add(rebels);
            }
            else
            {
                Console.WriteLine("Ім'я вже існує");
            }
        }
        int totalFood = 0;
        while (true) {
            string name_people = Console.ReadLine();
            if(name_people.ToLower() == "end") { break; }
            foreach (Citizen citizen1 in citizen) {
                if(citizen1.Name.ToLower() == name_people.ToLower()) { 
                    citizen1.BuyFood();  
                }
            }
            foreach (Rebel rebel1 in rebel){
                if (rebel1.Name.ToLower() == name_people.ToLower()) {
                    rebel1.BuyFood();
                }
            }
        }
        foreach(Citizen citizen2 in citizen)
        {
            totalFood += citizen2.Food;
        }
        foreach(Rebel rebel2 in rebel)
        {
            totalFood += rebel2.Food;
        }
        Console.WriteLine(totalFood);
    }
}