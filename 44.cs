// ── Оголошення nullable-типiв ─────────────────────────────────────
int? age = null;   // Nullable<int>
double? score = null;
bool? isActive = null;


// ── Перевiрка та розпакування ──────────────────────────────────────
if (age.HasValue)
    Console.WriteLine($"Вiк: {age.Value}");
else
    Console.WriteLine("Вiк не вказано");


// ── Оператор ?? (null-coalescing) ─────────────────────────────────
int result1 = age ?? 0;          // якщо null → 0
Console.WriteLine($"Вiк (або 0): {result1}");


// ── Оператор ??= (null-coalescing assignment) ──────────────────────
age ??= 18;   // якщо age == null, присвоїти 18
Console.WriteLine($"Вiк пiсля ??=: {age}");


// ── Оператор ?. (null-conditional) ───────────────────────────────
string? text = null;
int? len = text?.Length;  // не кидає NullReferenceException
Console.WriteLine($"Довжина: {len ?? -1}");


// ── Практичний приклад: оцiнка студента ───────────────────────────
double? grade = null;
Console.Write("Введiть оцiнку (або Enter для пропуску): ");
string? input = Console.ReadLine();
if (double.TryParse(input, out double parsed))
    grade = parsed;


string status = grade switch
{
    null => "Оцiнку не виставлено",
    >= 90 => "Вiдмiнно",
    >= 75 => "Добре",
    >= 60 => "Задовiльно",
    _ => "Незадовiльно"
};
Console.WriteLine($"Статус: {status}");
static double? SafeDivide(double? a, double? b)
{
    return (a == null || b == null || b == 0) ? null : a / b;
}

Console.WriteLine($"SafeDivide(10, 2) = {SafeDivide(10, 2)}");
Console.WriteLine($"SafeDivide(10, 0) = {SafeDivide(10, 0)}");
Console.WriteLine($"SafeDivide(null, 2) = {SafeDivide(null, 2)}");
string? city = null;
Console.WriteLine(city ?? "Пирятин");

city ??= "Київ";
Console.WriteLine(city);

string? word = "test";
Console.WriteLine(word?.Length);


