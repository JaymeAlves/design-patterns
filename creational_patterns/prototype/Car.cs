public class Car : Prototype
{
    public string Model { get; set; }
    public string Color { get; set; }
    public string Year { get; set; }
    public List<string> Optons { get; set; }

    public Car( string model, string color, string year, List<string> optons )
    {
        Model = model;
        Color = color;
        Year = year;
        Optons = optons;
    }

    public override Prototype Clone()
    {
        return new Car( Model, Color, Year, new List<string>(Optons));
    }
}