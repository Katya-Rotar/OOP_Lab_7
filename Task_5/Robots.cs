class Robots : IIdentifiable{
    public string Model {  get; set; }
    public string ID { get; set; }
    public Robots(string model, string iD)
    {
        Model = model;
        ID = iD;
    }
}