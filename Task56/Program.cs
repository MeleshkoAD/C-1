// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int range = 9;

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSum = 0;
int sum = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumElements(array, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой ({sum}) элементов ");


int SumElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}