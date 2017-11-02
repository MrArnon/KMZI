using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMZI_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime_numbers prime = new Prime_numbers();
            long mode = -1;
            Console.WriteLine("Для генерации простых чисел введите 0");
            Console.WriteLine("Для проверки числа на простоту введите 1");
            mode = prime.durak();
            switch (mode)
            {
                case 0:
                    Console.WriteLine("Введите до какого числа искать простые числа");
                    long n = prime.durak();
                        prime.Eratosfen(n);
                        break;
                case 1:
                    Console.WriteLine("Введите число для проверки");
                    long x = prime.durak();
                    if (prime.IsPrime(x))
                        Console.WriteLine("Число " + x + " простое");
                    else Console.WriteLine("Число " + x + " не является простым");
                    break;



                default: Console.WriteLine("Неверный ввод"); break;
            }
           
            Console.ReadLine();
        }
    }
}
