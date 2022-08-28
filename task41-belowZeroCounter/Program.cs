Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int tmp = Convert.ToInt32(Console.ReadLine());

    if (tmp > 0)
    {
        count++;
    }

    array[i] = tmp;
}

Console.WriteLine($"{StringifyArray(array)} -> {count}");


string StringifyArray(int[] array)
{
    return $"{string.Join(", ", array)}";
}