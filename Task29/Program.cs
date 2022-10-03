// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

FillArrayRandom(array);
PrintArray(array);


void FillArrayRandom(int[] array)
{
    for (int i = 0; i <= array.Length-1; i++) array[i] = new Random().Next(0, 99);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length-2; i++) Console.Write($"{array[i]}, ");
    Console.WriteLine($"{array[array.Length-1]}]");
}