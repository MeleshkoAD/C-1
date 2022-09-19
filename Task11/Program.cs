// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

int num = new Random().Next(100, 1000);

int numA = num % 100;
int numB = (num - 100 * numA) / 10;
int numC = (num - 100 * numA - numB * 10);

// string strA = numA.ToString;
// string strC = numC.ToString;

// int numD = Convert.ToInt32(strA + strC);

int numD = numA * 10 + numC;

Console.WriteLine($"{num} -> {numD}");