class Pet: IName, IBirthdate{
    public string Name {  get; set; }
    public DateTime Birthdate { get; set; }

    public Pet(string name, DateTime birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }
}