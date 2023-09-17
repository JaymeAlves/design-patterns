class CarBuilder : IBuilder
{
    private Car car;

    public CarBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this.car = new Car();
    }

    public void SetEngine(string engine)
    {
        car.Engine = "Car engine= " + engine;
    }

    public void SetGPS(bool gps)
    {
        if (gps)
        {
            car.GPS = "GPS set";
        }
    }

    public void SetSeats(int seats)
    {
        car.Seats = "Car seats= " + seats;
    }

    public void SetTripComputer(bool tripComputer)
    {
        if (tripComputer)
        {
            car.TripComputer = "TripComputer set";
        }
    }

    public Car GetProduct()
    {
        var product = this.car;
        this.Reset();
        return product;
    }
}