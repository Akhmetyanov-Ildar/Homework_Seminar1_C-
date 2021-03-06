// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] array = new int[8];
// Array.Reverse();

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

void PrintArray(int[] array3)
{
    for (int i = 0; i < array3.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array3.Length - 1) Console.Write(array3[i] + ",");
        else Console.Write(array3[i] + "]");
    }
}

void Reverse(int[] arr)
{
    int size = arr.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
        index1++;
        index2--;
    }
}

int[] array = CreateArrayRnd(10, 1, 9);

PrintArray(array);
Reverse(array);
Console.WriteLine();
PrintArray(array);
