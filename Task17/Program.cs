// 17. Напишите программу, 
// 1. которая принимает на вход координаты точки (X и Y), 
// 2. причём x не равно 0 и y не равно 0 и
// 3. выдаёт номер четверти плоскости, в которой нахордится эта 
// точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter (x, y);
string result = quarter > 0 ? $"указанные координаты соответствуют четверти -> {quarter.ToString()}" : "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter (int xc, int yc)
{
    if(xc > 0 && yc > 0) return 1;
    if(xc < 0 && yc > 0) return 2;
    if(xc < 0 && yc < 0) return 3;
    if(xc > 0 && yc < 0) return 4;
    return 0;
}