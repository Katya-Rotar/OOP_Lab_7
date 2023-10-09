class Rebel: IPeople, IBuyer{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Food { get; private set; }
    public string Group { get; set; }
    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Food = 0;
        Group = group;
    }
    public void BuyFood()
    {
        Food += 5;
    }
}
