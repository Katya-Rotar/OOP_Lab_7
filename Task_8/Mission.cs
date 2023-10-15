class Mission{
    public string CodeName { get; set; }
    public string State { get; set; }
    public Mission(string codeName, string state)
    {
        CodeName = codeName;
        State = state;
    }
    public override string ToString()
    {
        return $"Code Name: {CodeName} State: {State}";
    }
}