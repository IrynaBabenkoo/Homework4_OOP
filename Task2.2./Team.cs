using System;
using System.Collections.Generic;

public class Team
{
    public string TeamName { get; private set; }
    private List<Worker> workers;

    public Team(string teamName)
    {
        TeamName = teamName;
        workers = new List<Worker>();
    }

    public void AddWorker(Worker worker)
    {
        if (worker != null)
            workers.Add(worker);
    }

    public void ShowTeamInfo()
    {
        Console.WriteLine($"Команда: {TeamName}");
        foreach (var w in workers)
        {
            Console.WriteLine(w.Name);
        }
    }

    public void ShowDetailedInfo()
    {
        Console.WriteLine($"Детальна інформація про команду: {TeamName}");
        foreach (var w in workers)
        {
            Console.WriteLine($"{w.Name} - {w.Position} - {w.WorkDay}");
        }
    }
}
