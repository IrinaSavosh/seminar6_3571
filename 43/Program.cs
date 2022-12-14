// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (d-c)/(a-b),
// y = a*((d-c)/(a-b)) +c

Console.WriteLine("Введите число b1");
double numberB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
double numberK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2");
double numberB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double numberK2 = Convert.ToInt32(Console.ReadLine());

// если a= b - прямые параллельны. Если при этом c ≠ d,
// прямые различны и не имеют пересечений, в противном же случае прямые совпадают 

if (numberK1 != numberK2)
{
   double x = (numberB2 - numberB1) / (numberK1 - numberK2);
   double y = numberK1 * ((numberB2 - numberB1) / (numberK1 - numberK2)) + numberB1;
   Console.WriteLine($"Пересечение прямых в точке ({x};{y})");
}
else
{
   Console.Write("Прямые параллельны");
   if (numberB1 == numberB2)
   {
      Console.Write(" и совпадают");
   }
}