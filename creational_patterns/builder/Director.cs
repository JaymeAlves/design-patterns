class Director 
{
    public void ConstructSportsCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngine("SportsCar Engine");
        builder.SetTripComputer(true);
        builder.SetGPS(true);
    }

    public void ConstructSUV(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(4);
        builder.SetEngine("SUV Engine");
        builder.SetTripComputer(false);
        builder.SetGPS(true);
    }
}