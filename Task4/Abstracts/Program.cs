using System;

class Program
{
    static void Main(string[] args)
    {
        River dnipro = new River(
            x: 48.4, y: 35.0, name: "Дніпро", 
            description: "Найбільша річка України", 
            flowSpeed: 100.5, totalLength: 2201.0
        );

        Mountain hoverla = new Mountain(
            x: 48.16, y: 24.50, name: "Говерла", 
            description: "Найвища вершина Українських Карпат", 
            highestPoint: 2061.0
        );
        
        dnipro.GetInfo();
        hoverla.GetInfo();
    }
}
