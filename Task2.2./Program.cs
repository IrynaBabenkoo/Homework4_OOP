using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Team> teams = new List<Team>();

        Console.Write("Введіть кількість команд: ");
        int teamCount = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < teamCount; i++)
        {
            Console.WriteLine($"\n=== Команда №{i + 1} ===");
            Console.Write("Введіть назву команди: ");
            string teamName = Console.ReadLine()!;

            Team team = new Team(teamName);

            Console.Write("Скільки співробітників у цій команді? ");
            int workersCount = int.Parse(Console.ReadLine()!);

            for (int j = 0; j < workersCount; j++)
            {
                Console.WriteLine($"\nСпівробітник №{j + 1}");
                Console.Write("Введіть ПІБ співробітника: ");
                string name = Console.ReadLine()!;

                Console.Write("Хто це? (1 - Розробник, 2 - Менеджер): ");
                int type = int.Parse(Console.ReadLine()!);

                Worker worker = (type == 1) ? new Developer(name) : new Manager(name);

                worker.FillWorkDay();

                team.AddWorker(worker);
            }

            teams.Add(team);
        }

        Console.WriteLine("\n=== ІНФОРМАЦІЯ ПРО ВСІ КОМАНДИ ===");
        foreach (var team in teams)
        {
            team.ShowTeamInfo();
            team.ShowDetailedInfo();
        }

        Console.WriteLine("\nНатисніть Enter, щоб вийти...");
        Console.ReadLine();
    }
}
