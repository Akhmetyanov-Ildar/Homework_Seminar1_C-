// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 100)
{
    Console.WriteLine("третьей цифры нет");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(num.ToString()[2]);