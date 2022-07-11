// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();


    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] CopyArray(int[] arr)
{
    int size = arr.Length;
    int[] newarr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newarr[i] = arr[i];
        if (i == 1) newarr[i] = 2259;
    }
    return newarr;
}

void PrintArray(int[] array3)
{
    for (int i = 0; i < array3.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array3.Length - 1) Console.Write(array3[i] + ",");
        else Console.Write(array3[i] + "]");
    }
}

int[] array = CreateArrayRnd(8, 1, 20);
PrintArray(array);
Console.WriteLine();
int[] newArray = CopyArray(array);
PrintArray(newArray);
