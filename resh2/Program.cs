Console.WriteLine("введите значение a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение c");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a}x^2+{b}x+{c}) = {b}^2-4*{a}*{c}");
int D = Convert.ToInt32(Math.Pow(b, 2) - 4 * a * c);
Console.WriteLine($"Дискриминант = {D}");
if (D == 0)
{
    Console.WriteLine($"x = {(-b) / (2 * a)}");
}
else if (D < 0)
{
    Console.WriteLine("Решений нет");
}
else if (D > 0)
{
    Console.WriteLine($"x1 = {(-b + Math.Sqrt(D)) / (2 * a)}");
    Console.WriteLine($"x2 = {(-b - Math.Sqrt(D)) / (2 * a)}");
}