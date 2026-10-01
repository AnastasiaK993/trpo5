using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiverab
{
    internal class Program
    {
        static void Main(string[] args)
        {//вариант 16
            Console.WriteLine("Введите число состоящее минимум  из 3 цифр");
            int n = Convert.ToInt32(Console.ReadLine());

            int temp_n = n;
            int sum = 0;
            int x =0;
            int a =0;
            int lol =0;
            while (temp_n % 10>0)
                {
                lol =lol*10+ temp_n % 10;  temp_n = temp_n / 10;
              
               
            }
            temp_n = lol;
            while (temp_n % 10>0)
            {
                x = temp_n % 10;
                a = a * 10 + x;
                Console.WriteLine(a);
                temp_n = temp_n / 10;
                sum += a;
            }

            Console.WriteLine(sum+" результат сложения");
            Console.ReadKey();
        }
    }
}
