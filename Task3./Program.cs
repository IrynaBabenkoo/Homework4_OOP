using System;

class Program
{
    static void Main(string[] args)
    {
        decimal currentUsdRate = 41.76m;
        decimal currentEurRate = 48.66m;
        
        Converter bank = new Converter(currentUsdRate, currentEurRate);

        Console.WriteLine($"Курс USD: {currentUsdRate} грн, Курс EUR: {currentEurRate} грн.");
        Console.WriteLine("-----------------------------------");
        
        Console.WriteLine("Оберіть напрямок конвертації:");
        Console.WriteLine("  [1] З гривні (UAH) в іншу валюту (USD/EUR)");
        Console.WriteLine("  [2] З іншої валюти (USD/EUR) в гривню (UAH)");
        Console.Write("Ваш вибір (1 або 2): ");
        
        string directionChoice = Console.ReadLine()!;
        Console.WriteLine("-----------------------------------");
        
        if (directionChoice == "1")
        {
            HandleUahToCurrency(bank);
        }
        else if (directionChoice == "2")
        {
            HandleCurrencyToUah(bank);
        }
        Console.WriteLine("\nНатисніть ENTER для виходу...");
        Console.ReadKey();
    }

    static void HandleUahToCurrency(Converter bank)
    {
        Console.Write("Введіть суму в гривнях (UAH): ");

        if (decimal.TryParse(Console.ReadLine(), out decimal uahAmount))
        {
            Console.WriteLine("\nОберіть валюту призначення:");
            Console.WriteLine("  [1] USD");
            Console.WriteLine("  [2] EUR");
            Console.Write("Ваш вибір (1 або 2): ");

            string currencyChoice = Console.ReadLine()!;

            if (currencyChoice == "1")
            {
                decimal result = bank.UahToUsd(uahAmount);
                Console.WriteLine($"\nРезультат: {uahAmount:F2} грн = {result:F2} $");
            }
            else if (currencyChoice == "2")
            {
                decimal result = bank.UahToEur(uahAmount);
                Console.WriteLine($"\nРезультат: {uahAmount:F2} грн = {result:F2} €");
            }
        }    
    }

    static void HandleCurrencyToUah(Converter bank)
    {
        Console.WriteLine("\nОберіть вихідну валюту:");
        Console.WriteLine("  [1] USD");
        Console.WriteLine("  [2] EUR");
        Console.Write("Ваш вибір (1 або 2): ");
        
        string currencyChoice = Console.ReadLine()!;

        if (currencyChoice == "1")
        {
            Console.Write("Введіть суму в доларах (USD): ");
            if (decimal.TryParse(Console.ReadLine(), out decimal usdAmount))
            {
                decimal result = bank.UsdToUah(usdAmount);
                Console.WriteLine($"\nРезультат: {usdAmount:F2} $ = {result:F2} грн.");
            }
        }
        else if (currencyChoice == "2")
        {
            Console.Write("Введіть суму в євро (EUR): ");
            if (decimal.TryParse(Console.ReadLine(), out decimal eurAmount))
            {
                decimal result = bank.EurToUah(eurAmount);
                Console.WriteLine($"\n Результат: {eurAmount:F2} € = {result:F2} грн.");
            }
        }      
    }
}
















