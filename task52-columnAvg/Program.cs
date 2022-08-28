using System.Text;
int m = 3;
int n = 4;
Console.WriteLine($"m = {m}, n = {n}");
int[,] array = GetRandomArray(m, n, 0, 10);
Console.WriteLine(StringifyArray(array));

Console.WriteLine($"Среднее арифметическое каждого столбца: {GetColumnAvg(array)}");

string GetColumnAvg(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            avgArray[i] += array[j, i];
        }

        avgArray[i] = Math.Round(avgArray[i] / array.GetLength(0), 2);
    }

    return string.Join("; ", avgArray);
}

int[,] GetRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(min, max);
        }
    }

    return array;
}

string StringifyArray(int[,] array)
{
    StringBuilder s = new StringBuilder();
    string delimeter = " ";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            s.Append(array[i, j]).Append(delimeter);
        }

        s.AppendLine();
    }
    return s.ToString();
}