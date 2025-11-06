using System;
using System.Collections.Generic;

public abstract class Worker
{
    public string Name { get; set; }
    public string Position { get; set; } = ""; 
    protected List<string> actions;

    public string WorkDay => string.Join(", ", actions);

    public Worker(string name)
    {
        Name = name;
        actions = new List<string>();
    }

    public void Call()
    {
        Console.WriteLine($"{Name} робить дзвінок");
        actions.Add("Дзвінок");
    }

    public void WriteCode()
    {
        Console.WriteLine($"{Name} пише код");
        actions.Add("Пише код");
    }

    public void Relax()
    {
        Console.WriteLine($"{Name} відпочиває");
        actions.Add("Відпочинок");
    }

    public abstract void FillWorkDay();
}
