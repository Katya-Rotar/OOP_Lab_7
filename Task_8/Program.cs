using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Private> privateList = new List<Private>();
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "end") {
                break;
            }
            int id = int.Parse(input[1]);
            string firstName = input[2];
            string lastName = input[3];
            double salary = double.Parse(input[4]);
            switch (input[0].ToLower())
            {
                case "private":
                    Private privates = new Private(id, firstName,lastName, salary);
                    privateList.Add(privates);
                    sb.Append(privates.ToString() + "\n");
                    break;
                case "spy:":
                    int codeNumber = int.Parse(input[4]);
                    Spy spy = new Spy(id, firstName, lastName, codeNumber);
                    sb.Append(spy.ToString() + "\n");
                    break;
                case "leutenantgeneral":
                    List<Private> PrivatesList = new List<Private>();
                    for(int i = 5; i < input.Length; i++)
                    {
                        int idPrivate = int.Parse(input[i]);
                        foreach (Private private_search in privateList) {
                            if (private_search.Id == idPrivate) {
                                PrivatesList.Add(private_search);
                            }
                        }
                    }
                    LeutenantGenera leutenantGenera = new LeutenantGenera(id, firstName, lastName, salary, PrivatesList);
                    sb.Append(leutenantGenera.ToString() + "\n");
                    break;
                case "engineer":
                    List<Repair> RepairList = new List<Repair>();
                    string corps = input[5];
                    for (int i = 6; i < input.Length; i += 2)
                    {
                        string partName = input[i];
                        int hoursWorked = int.Parse(input[i+1]);
                        Repair repair = new Repair(partName, hoursWorked);
                        RepairList.Add(repair);
                    }
                    Engineer engineer = new Engineer(id, firstName, lastName, salary, corps, RepairList);
                    sb.Append(engineer.ToString() + "\n");
                    break;
                case "commando":
                    List<Mission> Missions = new List<Mission>();
                    string corps_2 = input[5];
                    for (int i = 8; i < input.Length; i += 2)
                    {
                        string codeName = input[i];
                        string state = input[i+1];
                        Mission mission = new Mission(codeName, state);
                        Missions.Add(mission);
                    }
                    Commando commando = new Commando(id, firstName, lastName, salary, corps_2, Missions);
                    sb.Append(commando.ToString() + "\n");
                    break;
            }
        }
        Console.WriteLine(sb);
    }
}