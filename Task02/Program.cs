// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// а=5; b=7 -> max=7
// а=2; b=10 -> max=10
// а= -9; b= -3 -> max= -3

Console.WriteLine("Введите целое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно целое число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
if(firstNum > secondNum)
{
    Console.WriteLine($"{firstNum}, является больше чем {secondNum}");
}
else
{
    Console.WriteLine($"{firstNum}, не является больше чем {secondNum}");
}