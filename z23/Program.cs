Console.Clear();

Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine()), b = 1;

while (b <= a) {
Console.Write($"{Math.Pow(b, 3)}, ");
b++;
};
