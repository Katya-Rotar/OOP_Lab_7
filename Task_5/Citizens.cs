class Citizens : IIdentifiable{
    public string Name { get; set; }
    public int Age { get; set; }
    public string ID { get; set; }
    public Citizens(string name, int age, string id) {
        Name = name;
        Age = age;
        ID = id;
    }
}