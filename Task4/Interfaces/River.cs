using System;

public class River : GeoObjectInter
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public double FlowSpeed { get; set; }
    public double TotalLength { get; set; }

    public River(double x, double y, string name, string description, double flowSpeed, double totalLength)
    {
        X = x; Y = y; Name = name; Description = description;
        FlowSpeed = flowSpeed;
        TotalLength = totalLength;
    }

    public void GetInfo()
    {
        Console.WriteLine($"\n- Річка (Інтерфейс): {Name} -");
        Console.WriteLine($"Координати: ({X}, {Y})");
        Console.WriteLine($"Опис: {Description}");
        Console.WriteLine($"Швидкість течії: {FlowSpeed} см/с");
        Console.WriteLine($"Загальна довжина: {TotalLength} км");
    }
}