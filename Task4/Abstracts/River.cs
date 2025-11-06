using System;

public class River : GeographicalObject 
{
    public double FlowSpeed { get; set; } 
    public double TotalLength { get; set; } 


    public River(double x, double y, string name, string description, double flowSpeed, double totalLength)
        : base(x, y, name, description) 
    {
        FlowSpeed = flowSpeed;
        TotalLength = totalLength;
    }


    public override void GetInfo()
    {
        base.GetInfo(); 
        Console.WriteLine($"Швидкість течії: {FlowSpeed} см/с");
        Console.WriteLine($"Загальна довжина: {TotalLength} км");
    }
}