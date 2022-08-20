Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{n} -> {SumOfDigits(n)}");

int SumOfDigits(int n)
{
    n = Math.Abs(n);

    int sum = 0;

    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }

    return sum;
}