Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string answer = a % 2 == 0 ? "да" : "нет";
Console.WriteLine(answer);