// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Введите  число: ");
// int num = Convert.ToInt32(Console.ReadLine());
int num = int.Parse(Console.ReadLine());
int i = 1;
while (i <= num)
{
    Console.WriteLine($"|куб числа {i}   |    {i * i * i,5}|");
    i++;
}