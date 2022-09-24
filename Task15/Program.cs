// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели: ");
string numDay = Console.ReadLine();

if (numDay == "6")
{
    Console.WriteLine("Этот день выходной: да, это суббота");
}
else if (numDay == "7")
{
    Console.WriteLine("Этот день выходной: да, это воскресение");
}
else if (numDay == "1")
{
    Console.WriteLine("Этот день выходной: нет");
}
else if (numDay == "2")
{
    Console.WriteLine("Этот день выходной: нет");
}
else if (numDay == "3")
{
    Console.WriteLine("Этот день выходной: нет");
}
else if (numDay == "4")
{
    Console.WriteLine("Этот день выходной: нет");
}
else if (numDay == "5")
{
    Console.WriteLine("Этот день выходной: нет");
}
else
{
    Console.WriteLine("Это число не день недели");
}