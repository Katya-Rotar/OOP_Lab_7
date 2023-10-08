class Robot: IIdentifiable, IName{
    public string Name { get; set; }
    public string ID { get; set; }
    public Robot(string name, string id) {
        Name = name;
        ID = id;
    }
}