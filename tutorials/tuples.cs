var pt = (X: 1, Y: 2);

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");

var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}");

var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);

var namedData = (Name: "Morning observation", Temp: 17, WindowsAccountType: 4);
var person = (FirstName: "", LastName: "");
var order = (ProductHeaderValue: "guitar picks", style: "triangle", quantity: 500, unitPrice: 0.10M);

Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
Console.WriteLine($"The two points are {pt3} and {pt4}");

double slopeResult = pt4.Slope();
Console.WriteLine($"The slope of {pt4} is {slopeResult}");

public record struct Point(int X, int Y)
{
    public double Slope() => (double)Y / (double)X;
}