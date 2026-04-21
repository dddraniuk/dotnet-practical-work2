using System;

class Program
{
    static void Main()
    {
        Console.Write("Введiть ПiБ студента: ");
        var name = Console.ReadLine();

        Console.Write("Введiть групу: ");
        var group = Console.ReadLine();

        Console.Write("Введiть рiк вступу: ");
        var year = int.Parse(Console.ReadLine());

        Console.Write("Введiть середнiй бал (або Enter): ");
        var input = Console.ReadLine();

        double? average = string.IsNullOrWhiteSpace(input)
            ? null
            : double.Parse(input);

        var studyYears = DateTime.Now.Year - year;

        var status = average switch
        {
            null => "не атестований",
            >= 90 => "вiдмiнно",
            >= 75 => "добре",
            >= 60 => "задовiльно",
            _ => "незадовiльно"
        };

        Console.WriteLine("\n----------------------------------------------------------------------------");
        Console.WriteLine($"{"ПiБ",-30} {"Група",-10} {"Рокiв",-8} {"Бал",-8} {"Статус",-15}");
        Console.WriteLine("----------------------------------------------------------------------------");

        Console.WriteLine($"{name,-30} {group,-10} {studyYears,-8} {(average?.ToString() ?? "null"),-8} {status,-15}");

        Console.ReadKey();
    }
}