// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22, 3, 9 -> 22





Console.WriteLine("Введите первое целое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());

if(Num1 > Num2 && Num1 > Num3)
{
    Console.WriteLine(Num1);
}
else 
if(Num2 > Num1 && Num2 > Num3)
{
    Console.WriteLine(Num2);
}
else
if(Num3 > Num2 && Num3 > Num1)
{
    Console.WriteLine(Num3);
}
