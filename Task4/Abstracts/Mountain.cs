public class Mountain : GeographicalObject
{
    public double HighestPoint { get; set; } 

    public Mountain(double x, double y, string name, string description, double highestPoint)
        : base(x, y, name, description)
    {
        HighestPoint = highestPoint;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Найвища точка: {HighestPoint} м");
    }
}