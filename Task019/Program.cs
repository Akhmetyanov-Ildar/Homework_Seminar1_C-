// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("введите пятизначное число");
int number = int.Parse(Console.ReadLine());
if (number < 10000 || number > 99000)
{
    Console.Write("Вы ввели не пятизначное число");
}
int pal = 0, num = number;
while (number > 0) { pal = pal * 10 + number % 10; number /= 10; }
Console.WriteLine(num == pal ? "палиндром" : "не палиндром");
