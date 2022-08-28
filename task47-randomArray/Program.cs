using System.Text;

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}");
Console.WriteLine(StringifyArray(GetRandomArray(m, n, 0, 10)));

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