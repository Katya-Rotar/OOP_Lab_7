using System.Text;

class LeutenantGenera : Private{
    public List<Private> Privates { get; set; }
    public LeutenantGenera(int id, string firstName, string lastName, double salary, List<Private> privates) : base(id, firstName, lastName, salary) {
        Privates = privates;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        if (Privates != null)
        {
            foreach (Private priv in Privates)
            {
                sb.Append(priv.ToString() + "\n");
            }
        }
        return $"{base.ToString()} \nPrivates: \n{sb}";
    }
}