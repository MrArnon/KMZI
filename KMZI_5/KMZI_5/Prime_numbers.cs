using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMZI_5
{
    class Prime_numbers
    {
        public bool IsPrime(long x)
        {
            if (x < 1) return false;
            for (long i = 2; i * i <= x; i++)
                if ((x % i) == 0) return false;
            return true;
        }
        public long durak()
        {
            bool flag = false;
            long R = 0;
            // Console.WriteLine("Введите число");
            string str;
            str = Console.ReadLine();
            try
            {
                R = Convert.ToInt64(str);
                flag = true;
            }
            catch (Exception) { flag = false; Console.WriteLine("Неверный ввод"); }
            if (flag) { return R; }
            else { durak(); return 0; }
        }
   
        public void Eratosfen(long n)
        {
            //int n = int.Parse(Console.ReadLine());
            bool[] A = new bool[n];
            // Инициализация и вывод массива
            for (long i = 2; i < n; i++)
            {
                A[i] = true;
            //    Console.Write("{0} ", i);
            }
            
            // Обработка
            for (long i = 2; i < Math.Sqrt(n) + 1; ++i)
            {
                if (A[i])
                {
                    for (long j = i * i; j < n; j += i)
                    {
                        A[j] = false;
                    }
                }
            }
            Console.WriteLine();
            // Повторный вывод
            for (long i = 2; i < n; i++)
            {
                if (A[i])
                    Console.Write("{0} ", i);
            }
        }
        }
}
