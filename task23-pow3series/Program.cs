Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"{n} -> ");
for (int i = 1; i <= n; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}