// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

int Print(int n, int m)
{
   if (n == m)
      return m;

   return Print(n, m - 1) + m;
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Print(n, m));

