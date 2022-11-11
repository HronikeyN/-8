
using System;


namespace пр8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Практическая работа №8.\nДоброво времени суток!!");
            double a, b, Y,a1;// обьявление переменных
            double v1,v2,v3;

            Console.Write("\nВведите границы диапазона [a,b] для расчета.\n");
            Console.Write("\nВедите a =отрицательное b = положительное\n");
            Console.Write("Введите a = ");
            a = Convert.ToDouble(Console.ReadLine());
            a1 = a;
            Console.Write("Введите b = ");
            b = Convert.ToDouble(Console.ReadLine());

            if (a < 0)
            {
                double sum = 0;
                while (a < b)
                {
                    sum += a;
                    v1 = Math.Pow((a), 3);
                    v2 = -0.6 * v1;
                    v3 = 7 * a;
                    Y = v2 + v3 - 10.8;
                    a += 0.5;
                    Console.WriteLine("Результат: Y = {0: #.###}", Y);
                };
                Console.WriteLine($"Ответ: решение уравнения  с диапозона [{a1} , {b}] равна. ");
                Console.ReadKey();
            }



        }
    }
}
