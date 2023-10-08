internal class Program
{
    private static void Main(string[] args)
    {
        List<DateTime> birthdate = new List<DateTime>();
        bool exit = true;
        while (exit)
        {
            string[] input = Console.ReadLine().Split(' ');
            switch (input[0].ToLower()) {
                case "end":
                    exit = false;
                    break;
                case "citizen":
                    string name_citizen = input[1];
                    int age_citizen = int.Parse(input[2]);
                    string id_1 = input[3];
                    DateTime date_citizen = DateTime.Parse(input[4]);
                    Citizen citizens = new Citizen(name_citizen, age_citizen, id_1, date_citizen);
                    birthdate.Add(citizens.Birthdate);
                    break;
                case "pet":
                    string name_pet = input[1];
                    DateTime date_pet = DateTime.Parse(input[2]);
                    Pet pet = new Pet(name_pet, date_pet);
                    birthdate.Add(pet.Birthdate);
                    break;
                case "robot":
                    string name_robot = input[1];
                    string id_2 = input[2];
                    Robot robot = new Robot(name_robot, id_2);
                    break;
            }
        }
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        foreach(DateTime dateTime in birthdate)
        {
            if (dateTime.Year == year) {
                Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
            }
        }
    }
}