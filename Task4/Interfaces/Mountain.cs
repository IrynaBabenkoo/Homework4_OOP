using System;

public class Mountain : GeoObjectInter
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public double HighestPoint { get; set; }

    public Mountain(double x, double y, string name, string description, double highestPoint)
    {
        X = x; Y = y; Name = name; Description = description;
        HighestPoint = highestPoint;
    }
    public void GetInfo()
    {
        Console.WriteLine($"\n- Гора (Інтерфейс): {Name} -");
        Console.WriteLine($"Координати: ({X}, {Y})");
        Console.WriteLine($"Опис: {Description}");
        Console.WriteLine($"Найвища точка: {HighestPoint} м");
    }
}