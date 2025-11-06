using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("- Тестування Інтерфейсу -");
        
    
        GeoObjectInter dnister = new River(
            x: 48.0, y: 27.0, name: "Дністер", 
            description: "Велика річка на заході", 
            flowSpeed: 80.0, totalLength: 1362.0
        );

        GeoObjectInter petros = new Mountain(
            x: 48.1, y: 24.4, name: "Петрос", 
            description: "Одна з вершин Чорногори", 
            highestPoint: 2020.0
        );
        
        dnister.GetInfo();
        petros.GetInfo();
    }
}
