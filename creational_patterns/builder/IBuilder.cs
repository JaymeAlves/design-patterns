using System.Net;

public interface IBuilder
{
    void Reset();
    void SetSeats(int seats);
    void SetEngine(string engine);
    void SetTripComputer(bool tripComputer);
    void SetGPS(bool gps);
    
}