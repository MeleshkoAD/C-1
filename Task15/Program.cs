// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
string numDay = Console.ReadLine();

if (numDay == "6" | numDay == "7")
{
    Console.WriteLine("Этот день выходной: да");
} 
else if (numDay < 1 | numDay > 7)
{
    Console.WriteLine("Этот день выходной: нет");
}
else 
{
  Console.WriteLine("Это число не день недели");
}