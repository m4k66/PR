//Вариант № 21 
//1. Даны два целых положительных числа A и B (A < B). Вывести все целые числа, расположенные между данными числами (не включая сами эти числа),
//в порядке их убывания, а также количество этих чисел. 
//2. Проверить истинность высказывания: "Данные целые числа X и Y являются координатами точки, лежащей во второй координатной четверти". 
//3. Дано целое положительное число K в диапазоне от 1 до 7. Вывести строку - название дня недели, соответствующее данному числу
//(1 - «понедельник», 2 - «вторник», ..., 7 - «воскресенье»). Если K не лежит в диапазоне 1–7, то вывести строку с сообщением "Ошибка"/"Error".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 \n");
        m1:
            int A = 0;
            int B = 0;
            int kol = 0;

            try
            {
                Console.WriteLine("Введите число A: ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число B: ");
                B = Convert.ToInt32(Console.ReadLine());
                if (A > B)
                {
                    Console.WriteLine("Ошибка: A > B\n");
                    goto m1;
                }
                if (A < 0 || B < 0)
                {
                    Console.WriteLine("Числа должны быть >= 0\n");
                }
                Console.WriteLine("");
                for (int i = B; i > A; i--)
                {
                    if (i == B || i == A)
                    {
                        i--;
                    }
                    Console.WriteLine("{0}", i);
                    kol++;
                }
                Console.WriteLine("\nЧисел между A и B: {0}\n", kol);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m1;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m1;
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m1;
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m1;
            }
            Console.WriteLine("Задание 2 \n");
        m2:
            int X = 0;
            int Y = 0;

            try
            {
                Console.WriteLine("Введите X: ");
                X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Y: ");
                Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Высказывание верно \n");
                }
                else
                    Console.WriteLine("Высказывание не верно \n");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m2;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m2;
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m2;
            }

            Console.WriteLine("Задание 3 \n");
        m3:
            int K = 0;

            try 
            {
            Console.WriteLine("Введите число от 1 до 7");
            K = Convert.ToInt32(Console.ReadLine());

            switch(K)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m3;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m3;
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Ошибка ввода \n");
                goto m3;
            }
        }
    }
}
