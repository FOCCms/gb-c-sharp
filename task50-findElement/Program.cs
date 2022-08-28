using System.Text;
int m = 3;
int n = 4;
Console.WriteLine($"m = {m}, n = {n}");
double[,] array = GetRandomArray(m, n, 0, 10);
Console.WriteLine(StringifyArray(array));

Console.Write("Введите номер строки (нумерация начинается с 1): ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца (нумерация начинается с 1): ");
int j = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine($"{i}, {j} -> {array[i - 1, j - 1]}");
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine($"{i}, {j} -> такого элемента в массиве нет");
}


double[,] GetRandomArray(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * (max - min) + min, 2);
        }
    }

    return array;
}

string StringifyArray(double[,] array)
{
    StringBuilder s = new StringBuilder();
    string delimeter = " ";
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            
            s.Append(array[i, j]).Append(delimeter);
        }

        s.AppendLine();
    }
    return s.ToString();
}