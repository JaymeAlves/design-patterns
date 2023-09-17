class ManualBuilder : IBuilder
{
    private Manual Manual;

    public ManualBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this.Manual = new Manual();
    }

    public void SetEngine(string engine)
    {
        Manual.Engine = "Describe engine: " + engine;
    }

    public void SetGPS(bool gps)
    {
        if (gps)
        {
            Manual.GPS = "Describe GPS Settings";
        }
    }

    public void SetSeats(int seats)
    {
        Manual.Seats = "this car has " + seats + ". the description is ...";
    }

    public void SetTripComputer(bool tripComputer)
    {
        if (tripComputer)
        {
            Manual.TripComputer = "Describe Trip Computer";
        }
    }

    public Manual GetProduct()
    {
        var product = this.Manual;
        this.Reset();
        return product;
    }
}