using System;

public class Manager : Worker
{
    private Random random;

    public Manager(string name) : base(name)
    {
        Position = "Менеджер";
        random = new Random();
    }

    public override void FillWorkDay()
    {
        int callsBeforeRelax = random.Next(1, 11); 
        for (int i = 0; i < callsBeforeRelax; i++)
            Call();

        Relax();

        int callsAfterRelax = random.Next(1, 6); 
        for (int i = 0; i < callsAfterRelax; i++)
            Call();
    }
}
