Console.Clear();

Console.WriteLine("Введите координату Х точки 1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки 1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки 1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки 2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки 2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки 2");
int z2 = Convert.ToInt32(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine(s);