// ── Цілочисельні типи ──────────────────────────────────────────────
byte b = 255;             // 0 .. 255  (8 біт, беззнаковий)
sbyte sb = -128;            // -128 .. 127
short s = -32_768;         // 16 біт
ushort us = 65_535;          // 16 біт, беззнаковий
int i = 2_147_483_647;   // 32 біт  ← найпоширеніший
uint ui = 4_294_967_295u;  // 32 біт, беззнаковий
long l = 9_223_372_036_854_775_807L;  // 64 біт
ulong ul = 18_446_744_073_709_551_615UL;


// ── Дійсні типи ────────────────────────────────────────────────────
float f = 3.14f;          // 32 біт, ~7 знаків точності
double d = 3.14159265358;  // 64 біт, ~15 знаків ← за замовчуванням
decimal m = 3.14159265358979m; // 128 біт, фінансові розрахунки


// ── Інші примітивні типи ───────────────────────────────────────────
bool flag = true;
char ch = 'А';           // Unicode-символ (16 біт)


// ── Посилальний тип string ─────────────────────────────────────────
string name = "Привіт, .NET!";
string? nullableName = null; // може бути null


// ── Неявна типізація var ───────────────────────────────────────────
var count = 42;            // компілятор виводить int
var pi = 3.14159;       // double
var message = "текст";       // string
var arr = new int[] { 1, 2, 3 }; // int[]


// ── Виведення розмірів ─────────────────────────────────────────────
Console.WriteLine($"sizeof(int)     = {sizeof(int)} байт");
Console.WriteLine($"sizeof(double)  = {sizeof(double)} байт");
Console.WriteLine($"sizeof(decimal) = {sizeof(decimal)} байт");
Console.WriteLine($"int.MaxValue    = {int.MaxValue}");
Console.WriteLine($"double.Epsilon  = {double.Epsilon}");
Console.WriteLine($"long Min = {long.MinValue}");
Console.WriteLine($"long Max = {long.MaxValue}");

Console.WriteLine($"float Min = {float.MinValue}");
Console.WriteLine($"float Max = {float.MaxValue}");

Console.WriteLine($"decimal Min = {decimal.MinValue}");
Console.WriteLine($"decimal Max = {decimal.MaxValue}");
