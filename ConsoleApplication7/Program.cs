using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void task_1409()
        {
            Console.WriteLine("Задача № 1409. Два бандита");
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if ((x + y) > 11) Console.WriteLine("Ошибка. Повторите ввод.");
            Console.WriteLine("Количество банок, не прострелянных Гарри = " + ((x + y - 1)- x));
            Console.WriteLine("Количество банок, не прострелянных Ларри = " + ((x + y - 1) - y));
        }

        static void task_1079()
        {
            Console.WriteLine("Задача № 1079. Максимум");
            int[] m = new int[10];
            int n, i = 0, max = 0, max_m = 0;
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                m[i] = n;
                i = i + 1;

                if (n > max) { max = n; } 
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] mas = new int[max + 1];
            mas[0] = 0; mas[1] = 1;
            for (i = 2; i <= max; i++)
            {
                if(i % 2 == 0) { mas[i] = mas[i / 2]; }
                else { mas[i] = mas[i / 2] + mas[(i / 2) + 1]; }
            }
            for (i = 1; i <= max; i++)
            {
                if (mas[i] > max_m) { max_m = mas[i]; }
                for (int j = 0; j < 10; j++)
                {
                    if (m[j] == i) { Console.WriteLine("Для числа "+ m[j] + " максимум = " + max_m); }
                }
            }
        }
        

        static void task_1068()
        {
            Console.WriteLine("Задача № 1068. Сумма");
            int n, sum = 1;
            n = Convert.ToInt32(Console.ReadLine());
                while (n != 1)
                {
                    sum = sum + n;
                    if (n > 1)
                    {
                        n = n - 1;
                    }
                    else
                    {
                        n = n + 1;
                    }
                }
            Console.WriteLine(sum);
        }

            static void Main(string[] args)
        {
            task_1409();
            task_1068();
            task_1079();
            Console.ReadKey();
        }
    }
}
