Boolean isNumberValid = false;
int n;
do
{
    Console.Write("Введите трёхзначное число: ");
    n = Convert.ToInt32(Console.ReadLine());

    if (Math.Abs(n) / 100 > 0 && Math.Abs(n) / 100 < 10)
    {
        isNumberValid = true;
    }
} while (!isNumberValid);

Console.WriteLine($"{n} -> {Math.Abs(n) % 100 / 10}");