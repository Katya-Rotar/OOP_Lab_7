class Citizen: IIdentifiable, IPeople, IBirthdate, IBuyer {
    public string Name { get; set; }
    public int Age {  get; set; }
    public string ID {  get; set; }
    public DateTime Birthdate {  get; set; }
    public int Food { get; private set; }
    public Citizen(string name, int age, string iD, DateTime birthdate)
    {
        Name = name;
        Age = age;
        ID = iD;
        this.Birthdate = birthdate;
        Food = 0;
    }
    public void BuyFood() {
        Food += 10;
    }
}