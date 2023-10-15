class Spy : Soldier{
    public int CodeNumber { get; set; }
    public Spy(int id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName) {
        CodeNumber = codeNumber;
    }
    public override string ToString()
    {
        return $"{base.ToString()} \nCodeNumber: {CodeNumber}";
    }
}