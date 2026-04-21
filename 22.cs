// ── Boxing (пакування) ─────────────────────────────────────────────
int value = 42;           // значення на стеку
object boxed = value;        // boxing: копія переноситься в купу (heap)


Console.WriteLine($"value:  {value}  (тип: {value.GetType()})");
Console.WriteLine($"boxed:  {boxed}  (тип: {boxed.GetType()})");
Console.WriteLine($"Рівні? {value.Equals(boxed)}");   // true
Console.WriteLine($"Однакові об'єкти? {ReferenceEquals(value, boxed)}"); // false!


// ── Unboxing (розпакування) ────────────────────────────────────────
int unboxed = (int)boxed;   // явне приведення типу
Console.WriteLine($"unboxed: {unboxed}");


// ── Небезпечний unboxing ───────────────────────────────────────────
try
{
    double wrong = (double)boxed; // InvalidCastException!
}
catch (InvalidCastException ex)
{
    Console.WriteLine($"Помилка: {ex.Message}");
}


// ── Вплив на продуктивність ────────────────────────────────────────
var sw = System.Diagnostics.Stopwatch.StartNew();
object o;
for (int i = 0; i < 10_000_000; i++) o = i;  // 10 млн boxing-операцій
sw.Stop();
Console.WriteLine($"Boxing  10M разів: {sw.ElapsedMilliseconds} мс");


sw.Restart();
int v;
for (int i = 0; i < 10_000_000; i++) v = i;  // без boxing
sw.Stop();
Console.WriteLine($"Без boxing 10M разів: {sw.ElapsedMilliseconds} мс");
