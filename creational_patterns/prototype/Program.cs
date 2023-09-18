List<string> options = new List<string>() {"Sunroof", "Navigation", "Leather Seats"};
var c1 = new Car("Ford", "Black", "2000", options);
var c2 = c1.Clone() as Car;

Console.WriteLine(c2.Model);
Console.WriteLine(c2.Color);
Console.WriteLine(c2.Year);
Console.WriteLine(String.Join(", ", c2.Optons));