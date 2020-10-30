using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK01
            Console.WriteLine("Ввести пять различных ненулевых целых чисел. Найти два наибольших числа");
            int[] vMas = new int[5];
            int max1 = 0;           //вспомогательная переменная
            int max2 = 0;           //вспомогательная переменная
            int max = 0;
            int max_1 = 0;
           t1:
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите число ", i + 1);
                try
                {
                    vMas[i] = Convert.ToInt32(Console.ReadLine());
                    if (vMas[i] <= 0)
                    {
                        throw new ArgumentException("Число не должно быть равно нулю и меньше его");
                        goto t1;
                    }
                }
                catch (System.FormatException exception)
                {
                    Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
                    Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
                    goto t1;  
                }
                catch (System.ArgumentException exception)
                {
                    Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
                    Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
                    goto t1;  
                }
                catch (System.IndexOutOfRangeException exception)
                {
                    Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
                    Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
                } 
            }

            for (int i = 0; i < 5; i++)
            {
                max1 = vMas[i];
                if (i == 4)
                {
                    max1 = 0;
                    max2 = 0;
                    goto m1;
                }
                if (max < max1)
                {
                    max = max1;
                    max1 = 0;
                }
                else
                {
                    max1 = 0;
                }
            }
            m1:
            for (int i = 0; i < 5; i++)
            {
                max1 = vMas[i];
                if (i == 4)
                {
                    goto m2;
                }
                max2 = vMas[i + 1];
                if (max1 < max2 && max_1 < max2)
                {
                    max1 = 0;
                    if (max2 != max)
                    {
                        max_1 = max2;
                    }
                    else
                    {
                        max2 = 0;
                    }
                }
                if (max2 < max1 && max_1 < max1)
                {
                    max2 = 0;
                    if (max1 != max)
                    {
                        max_1 = max1;
                    }
                    else
                    {
                        max1 = 0;
                    }
                }
            }
        m2:
            Console.WriteLine("Ответ: {0}, {1} \n\n", max, max_1);
        //TASK02
            int num = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Проверить истинность высказывания: \nЦифры данного целого положительного трехзначного числа, введенного с клавиатуры,\nобразуют убывающую последовательность");
        n1:
            Console.WriteLine("Введите число: ");
        try
        {
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 100 || num > 1000)
            {
                throw new ArgumentException("Число должно быть только трехзначным и положительным");
                goto n1;
            }
        }
        catch (System.FormatException exception)
        {
            Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
            Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
            goto n1;
        }
        catch (System.ArgumentException exception)
        {
            Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
            Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
            goto n1;
        }
        catch (System.IndexOutOfRangeException exception)
        {
            Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
            Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
        } 
            a = num % 10;
            num = num / 10;
            b = num % 10;
            num = num / 10;
            c = num % 10;
            num = num / 10;
            if (a < b && b < c)
            {
                Console.WriteLine("Ответ: ДА\n\n");
            }
            else
            {
                Console.WriteLine("Ответ: НЕТ\n\n");
            }



        //TASK03
            int day = 0;
            int mounth = 0;
            Console.WriteLine("Даны два целых положительных числа: D (день, от 1 до 31) и M (месяц, от 1 до 12),\nопределяющие правильную дату не високосного года.\nВывести значения D и M для даты, следующей за указанной.");
           t3:
            Console.WriteLine("Введите день(от 1 до 31): ");
            try
            {
                day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 31)
                {
                    throw new ArgumentException("День должен быть в пределах от 1 до 31");
                    goto t3;
                }
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
                Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
                goto t3;
            }
            catch (System.ArgumentException exception)
            {
                Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
                Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
                goto t3;
            }
        t4:
            Console.WriteLine("Введите месяц (от 1 до 12): ");
        try
        {
            mounth = Convert.ToInt32(Console.ReadLine());
            if (mounth < 1 || mounth > 12)
            {
                throw new ArgumentException("Месяц должен быть в пределах от 1 до 12");
                goto t4;
            }
        }
        catch (System.FormatException exception)
        {
            Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
            Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
            goto t4;
        }
        catch (System.ArgumentException exception)
        {
            Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
            Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
            goto t4;
        }  
            switch (mounth)
            {
                case 1:
                    if (day == 31)
                    {
                        Console.WriteLine("1.02");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.0{1}", day, mounth);
                        break;
                    }
                case 2:
                    if (day == 28)
                    {
                        Console.WriteLine("1.03");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.0{1}", day, mounth);
                        break;
                    }
                case 3:
                    if (day == 31)
                    {
                        Console.WriteLine("1.04");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.0{1}", day, mounth);
                        break;
                    }
                case 4:
                    if (day == 30)
                    {
                        Console.WriteLine("1.05");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.0{1}", day, mounth);
                        break;
                    }
                case 5:
                    if (day == 31)
                    {
                        Console.WriteLine("1.06");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.0{1}", day, mounth);
                        break;
                    }
                case 6:
                    if (day == 30)
                    {
                        Console.WriteLine("1.07");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.0{1}", day, mounth);
                        break;
                    }
                case 7:
                    if (day == 31)
                    {
                        Console.WriteLine("1.08");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.0{1}", day, mounth);
                        break;
                    }
                case 8:
                    if (day == 31)
                    {
                        Console.WriteLine("1.09");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.0{1}", day, mounth);
                        break;
                    }
                case 9:
                    if (day == 30)
                    {
                        Console.WriteLine("1.10");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.0{1}", day, mounth);
                        break;
                    }
                case 10:
                    if (day == 31)
                    {
                        Console.WriteLine("1.11");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.{1}", day, mounth);
                        break;
                    }
                case 11:
                    if (day == 30)
                    {
                        Console.WriteLine("1.12");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.{1}", day, mounth);
                        break;
                    }
                case 12:
                    if (day == 31)
                    {
                        Console.WriteLine("УЖЕ ГОД ПРОШЕЛ!");
                        break;
                    }
                    else
                    {
                        day = day + 1;
                        Console.WriteLine("{0}.{1}", day, mounth);
                        break;
                    }
            }
        
}

    }
}
