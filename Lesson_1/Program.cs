using System;

namespace Lesson_1
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Programm p = new Programm();
            //int first, second, third;

            //Console.Write("Введите первое число: ");
            //first = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //second = Convert.ToInt32(Console.ReadLine());

            //third = first + second;

            //Console.WriteLine(first + " + " + second + " = " + third);

            p.Task2();
        }


        private void Task1()
        {
            int variable;
            Console.WriteLine("\nЗадача 1.");
            
                Console.Write("Введите число от 1 до 100: ");
                variable = Convert.ToInt32(Console.ReadLine());
            if (variable >= 0 && variable <= 100)
            {
                if (variable % 3 == 0)
                {
                    Console.Write("FIZZ");
                    if (variable % 5 == 0)
                    {
                        Console.WriteLine("BAZZ");
                    }
                }
                else if (variable % 5 == 0)
                {
                    Console.WriteLine("BAZZ");
                }
                else
                {
                    Console.WriteLine(variable);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неправильные данные!");
            }

        }

        private void Task2()
        {
            double variable;
            double percent;

            Console.WriteLine("\nЗадача 2.");
            Console.Write("Введите число: ");
            variable = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите процент: ");
            percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + (variable / 100) * percent);
        }

    }

    

    
}

