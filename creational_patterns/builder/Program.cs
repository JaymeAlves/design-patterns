var director =  new Director();

var carBuilder = new CarBuilder();
director.ConstructSportsCar(carBuilder);
var car = carBuilder.GetProduct();

var manualBuilder = new ManualBuilder();
director.ConstructSportsCar(manualBuilder);
var manual = manualBuilder.GetProduct();

Console.WriteLine("############## SportsCar Parts ##############");
Console.WriteLine("Car Seats:" + car.Seats);
Console.WriteLine("Car Engine:" + car.Engine);
Console.WriteLine("Car Trip Computer:" + car.TripComputer);
Console.WriteLine("Car GPS:" + car.GPS);

Console.WriteLine("############## SportsCar Manual Parts ##############");
Console.WriteLine("Manual Seats:" + manual.Seats);
Console.WriteLine("Manual Engine:" + manual.Engine);
Console.WriteLine("Manual Trip Computer:" + manual.TripComputer);
Console.WriteLine("Manual GPS:" + manual.GPS);

var svuBuilder = new CarBuilder();
director.ConstructSUV(svuBuilder);
var svuCar = svuBuilder.GetProduct();

var svuManualBuilder = new ManualBuilder();
director.ConstructSUV(svuManualBuilder);
var svuManual = svuManualBuilder.GetProduct();

Console.WriteLine("############## SUV Parts ##############");
Console.WriteLine("Car Seats:" + svuCar.Seats);
Console.WriteLine("Car Engine:" + svuCar.Engine);
Console.WriteLine("Car Trip Computer:" + svuCar.TripComputer);
Console.WriteLine("Car GPS:" + svuCar.GPS);

Console.WriteLine("############## SUV Manual Parts ##############");
Console.WriteLine("Manual Seats:" + svuManual.Seats);
Console.WriteLine("Manual Engine:" + svuManual.Engine);
Console.WriteLine("Manual Trip Computer:" + svuManual.TripComputer);
Console.WriteLine("Manual GPS:" + svuManual.GPS);
