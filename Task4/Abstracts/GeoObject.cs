using System;

public abstract class GeographicalObject
{
    public double XCoordinate { get; set; }
    public double YCoordinate { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }


    public GeographicalObject(double x, double y, string name, string description)
    {
        XCoordinate = x;
        YCoordinate = y;
        Name = name;
        Description = description;
    }


    public virtual void GetInfo()
    {
        Console.WriteLine($"\n--- Об'єкт: {Name} ---");
        Console.WriteLine($"Координати: ({XCoordinate}, {YCoordinate})");
        Console.WriteLine($"Опис: {Description}");
    }
}