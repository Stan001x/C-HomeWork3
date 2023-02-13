Console.Clear();

Console.WriteLine("Введите пятизначное число");

int a = Convert.ToInt32(Console.ReadLine());

while (a < 10000 || a > 99999) 
{
    Console.WriteLine("Ошибка!!!\nВведите пятизначное число");
    a = Convert.ToInt32(Console.ReadLine());
}
int a1 = a / 10000;
int a2 = (a - (a1 * 10000)) / 1000;
int a4 = (a / 10) % 10;
int a5 = a % 10;
if (a1 == a5 & a2 == a4)
Console.WriteLine("Число является палиндромом");
else
Console.WriteLine("Нет, это не палиндром");