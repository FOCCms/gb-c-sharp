int size = 8;
double[] array = GetRandomArray(size, 0, 100);

Console.WriteLine($"{StringifyArray(array)} -> {Diff(array)}");

double[] GetRandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
    }

    return array;
}

string StringifyArray(double[] array)
{
    return $"[{string.Join(", ", array)}]";
}

double Diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max - min;
}