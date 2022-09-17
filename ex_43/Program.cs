//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

void Points(double k1, double b1, double k2, double b2)
{
   
        double x = (b2-b1)/(k1-k2); 
        double y = (k1*(b2-b1))/(k1-k2)+b1;
        if( k1 == k2) Console.WriteLine("Прямые не пересекаются");
        else Console.WriteLine($"Точка пересечения: ({x}; {y})");

}

Console.WriteLine("Enter b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k2: ");
double k2 = double.Parse(Console.ReadLine());

Points(k1,b1,k2,b2);
