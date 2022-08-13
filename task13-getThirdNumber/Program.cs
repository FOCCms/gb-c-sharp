Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(n) / 100 == 0)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"{n} -> {Math.Abs(n) % 1000 / 100}");
}