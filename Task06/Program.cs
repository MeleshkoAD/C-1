// Напишите программу, которая на вход принимает число и выдает, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());



if (Num % 2 == 0)
{
    Console.WriteLine("Чётное");
}
else 
{
   Console.WriteLine("Нечётное"); 
}