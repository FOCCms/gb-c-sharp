Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a}^{b} -> {Pow(a,b)}");

ulong Pow(int a, int b)
{
    ulong pow = 1;
    for (int i = 0; i < b; i++)
    {
        pow *= (ulong) a;
    }
    return pow;
}