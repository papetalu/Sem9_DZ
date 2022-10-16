// Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int PrintAnk(int m, int n)
{
   if (m == 0)
   {
      return n + 1;
   }

   if (m > 0 && n == 0)
   {
      return PrintAnk(m - 1, 1);
   }

   return PrintAnk(m - 1, PrintAnk(m, n - 1));
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintAnk(m, n));

