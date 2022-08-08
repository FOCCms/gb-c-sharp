int[] a = new int[3];
Console.Write("Введите первое число: ");
a[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
a[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
a[2] = Convert.ToInt32(Console.ReadLine());

int max = a[0];

for (int i = 1; i < a.Length; i++)
{
    if (a[i] > max)
    {
        max = a[i];
    }
}

Console.WriteLine(max);