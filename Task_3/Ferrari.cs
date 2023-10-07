class Ferrari : ICar
{
    public string model;
    public string DriverName { get; set; }

    public Ferrari(string driverName) {
        this.model = "488-Spider";
        this.DriverName = driverName;
    }
    public string PushBrakePedal()
    {
        return "Brakes!";
    }

    public string PushGasPedal()
    {
        return "Zadu6avam sA!";
    }
}