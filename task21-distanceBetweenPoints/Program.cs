Console.Write("Введите Ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Az: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите By: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)), 2);
Console.WriteLine($"A ({ax},{ay},{az}); B ({bx},{by},{bz}) -> {distance}");