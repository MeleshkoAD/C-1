// напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

// 1 1
// 2 4
// 3 9
// 4 16
// 5 25

Console.Write("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());

int counter = 1;

string SrtingOfSqure (int num)
{
    return $"{num} {num*num}";
}

while (counter <= numX)
{
    Console.WriteLine(SrtingOfSqure(counter));
    counter++;
}