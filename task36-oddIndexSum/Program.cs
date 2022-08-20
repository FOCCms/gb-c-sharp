int size = 8;
int[] array = GetRandomArray(size, 0, 100);

Console.WriteLine($"{StringifyArray(array)} -> {OddIndexSum(array)}");

int[] GetRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    return array;
}

string StringifyArray(int[] array)
{
    return $"[{string.Join(", ", array)}]";
}

int OddIndexSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}