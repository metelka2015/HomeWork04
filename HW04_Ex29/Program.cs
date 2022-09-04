// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void CreateArray(int[] array)
{
    var random = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write(array[j] + " ");
    }
}
int[] array = new int[8];
CreateArray(array);
PrintArray(array);
