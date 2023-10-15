using System.Text;

class Engineer : Private, ISpecialisedSoldier{
    public static List<Repair> RepairList { get; set; }
    public string Corps { get; set; }
    public Engineer(int id, string firstName, string lastName, double salary, string corps, List<Repair> repairList) : base(id, firstName, lastName, salary)
    {
        Corps = corps;
        RepairList = repairList;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Repair repair in RepairList)
        {
            sb.Append(repair.ToString() + "\n");
        }
        return $"{base.ToString()} \nCorps: {Corps} \nRepair: \n{sb}";
    }
}