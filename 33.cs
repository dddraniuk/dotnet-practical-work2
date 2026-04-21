using System;
using System.Globalization;

bool exit = false;
double? memory = null;

while (!exit)
{
    Console.Clear();
    Console.WriteLine("╔══════════════════════════════╗");
    Console.WriteLine("║       КАЛЬКУЛЯТОР C#         ║");
    Console.WriteLine("╠══════════════════════════════╣");
    Console.WriteLine("║  1. Додавання    (+)         ║");
    Console.WriteLine("║  2. Вiднiмання   (-)         ║");
    Console.WriteLine("║  3. Множення     (*)         ║");
    Console.WriteLine("║  4. Дiлення      (/)         ║");
    Console.WriteLine("║  5. Залишок      (%)         ║");
    Console.WriteLine("║  6. Степiнь      (^)         ║");
    Console.WriteLine("║  7. Квадратний корiнь        ║");
    Console.WriteLine("║  8. Абсолютне значення       ║");
    Console.WriteLine("║  9. Округлення               ║");
    Console.WriteLine("║  M. Використати пам'ять      ║");
    Console.WriteLine("║  0. Вихiд                    ║");
    Console.WriteLine("╚══════════════════════════════╝");
    Console.Write("Оберiть операцiю: ");

    string? choice = Console.ReadLine()?.ToUpper();

    if (choice == "0")
    {
        exit = true;
        break;
    }

    double a;

    while (true)
    {
        Console.Write("Введiть перше число: ");
        if (double.TryParse(Console.ReadLine(),
            NumberStyles.Any,
            CultureInfo.InvariantCulture,
            out a))
            break;

        Console.WriteLine("Невiрне число! Спробуйте ще раз.");
    }

    double b = 0;

    if (choice != "7" && choice != "8" && choice != "M")
    {
        while (true)
        {
            Console.Write("Введiть друге число: ");
            if (double.TryParse(Console.ReadLine(),
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out b))
                break;

            Console.WriteLine("Невiрне число! Спробуйте ще раз.");
        }
    }

    double? result = choice switch
    {
        "1" => a + b,
        "2" => a - b,
        "3" => a * b,
        "4" => b == 0 ? null : a / b,
        "5" => b == 0 ? null : a % b,
        "6" => Math.Pow(a, b),
        "7" => a < 0 ? null : Math.Sqrt(a),
        "8" => Math.Abs(a),
        "9" => Math.Round(a, (int)b),
        "M" => memory,
        _ => null
    };

    if (result.HasValue)
    {
        memory = result;
        Console.WriteLine($"\nРезультат = {result.Value}");
    }
    else
    {
        Console.WriteLine("\nПомилка обчислення!");
    }

    Console.Write("\nНатиснiть будь-яку клавiшу...");
    Console.ReadKey();
}