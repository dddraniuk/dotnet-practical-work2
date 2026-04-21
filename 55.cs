// ── Цілочисельне ділення ──────────────────────────────────────────
int a = 10, b = 3;
int intDiv = a / b;      // 3   (дробова частина відкидається)
int intMod = a % b;      // 1   (залишок від ділення)


Console.WriteLine($"{a} / {b}  = {intDiv}  (int)");
Console.WriteLine($"{a} % {b}  = {intMod}  (залишок)");


// ── Дійсне ділення ────────────────────────────────────────────────
double dDiv = (double)a / b;    // 3.3333...
double dDiv2 = a / (double)b;    // теж 3.3333...
double dDiv3 = 10.0 / 3;        // теж 3.3333...
double dDiv4 = a / b;            // УВАГА: 3.0 (спочатку int/int, потім cast!)


Console.WriteLine($"(double)a / b  = {dDiv:F10}");
Console.WriteLine($"a / (double)b  = {dDiv2:F10}");
Console.WriteLine($"10.0 / 3       = {dDiv3:F10}");
Console.WriteLine($"(double)(a/b)  = {dDiv4:F10}"); // помилка починаючих!
// ── Ділення на нуль ───────────────────────────────────────────────
// int    zeroInt = 10 / 0;    // DivideByZeroException (час виконання)
double zeroD = 10.0 / 0.0; // Infinity (не виняток!)
double nanVal = 0.0 / 0.0;  // NaN


Console.WriteLine($"10.0 / 0.0 = {zeroD}");   // Infinity
Console.WriteLine($"0.0  / 0.0 = {nanVal}");   // NaN
Console.WriteLine($"IsInfinity: {double.IsInfinity(zeroD)}");
Console.WriteLine($"IsNaN:      {double.IsNaN(nanVal)}");


// ── Точність decimal vs double ────────────────────────────────────
double d1 = 0.1 + 0.2;         // 0.30000000000000004 (IEEE 754)
decimal d2 = 0.1m + 0.2m;       // 0.3 (точно)
Console.WriteLine($"double:  0.1+0.2 = {d1}");
Console.WriteLine($"decimal: 0.1+0.2 = {d2}");

