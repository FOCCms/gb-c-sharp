int size = 8;
int[] array = GetRandomArray(size, 100, 1000);

Console.WriteLine($"{StringifyArray(array)} -> {CountEven(array)}");

int[] GetRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    return array;
}

int CountEven(int[] array)
{
    int count = 0;
    foreach (int n in array)
    {
        if (n % 2 == 0)
        {
            count += 1;
        }
    }

    return count;
}

string StringifyArray(int[] array)
{
    return $"[{string.Join(", ", array)}]";
}