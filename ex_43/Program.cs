//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

void Points(int k1, int b1, int k2, int b2)
{
    try
    {
        int x = (b2-b1)/(k1-k2); 
        int y = k1*((b2-b1)/(k1-k2)) + b1;

        Console.WriteLine($"Точка пересечения: ({x}; {y})");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
}

Console.WriteLine("Enter b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter k2: ");
int k2 = int.Parse(Console.ReadLine());

Points(k1,b1,k2,b2);
