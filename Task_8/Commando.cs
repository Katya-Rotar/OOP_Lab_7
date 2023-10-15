using System.Reflection;
using System.Text;

class Commando : Private, ISpecialisedSoldier{
    public string Corps { get; set; }
    public static List<Mission> Missions { get; set; }
    public Commando(int id, string firstName, string lastName, double salary, string corps, List<Mission> missions) : base(id, firstName, lastName, salary)
    {
        Corps = corps;
        Missions = missions;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        if (Missions != null)
        {
            foreach (Mission mission in Missions)
            {
                sb.Append(mission.ToString() + "\n");
            }
        }
        return $"{base.ToString()} \nCorps: {Corps} \nMissions: \n{sb}";
    }
}