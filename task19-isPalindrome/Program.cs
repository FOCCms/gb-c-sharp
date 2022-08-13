Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Boolean isPalindrome = true;

int numSize = n == 0 ? 1 : (int)Math.Log10(Math.Abs(n)) + 1;

var middleNumIndex = Math.Floor((double)numSize / 2);

for (int i = 0; i < middleNumIndex; i++)
{
    int n1 = GetNumber(i, numSize, n);

    int n2 = GetOppositeNumber(i, n);

    if (n1 != n2)
    {
        isPalindrome = false;
    }
}

if (isPalindrome)
{
    Console.WriteLine($"{n} -> да");
}
else
{
    Console.WriteLine($"{n} -> нет");
}


int GetNumber(int index, int size, int n)
{
    int value = n / Convert.ToInt32(Math.Pow(10, size - index - 1)) % 10;
    return value;
}

int GetOppositeNumber(int index, int n)
{
    int value = n % Convert.ToInt32(Math.Pow(10, index + 1)) / Convert.ToInt32(Math.Pow(10, index));
    return Convert.ToInt32(value);
}