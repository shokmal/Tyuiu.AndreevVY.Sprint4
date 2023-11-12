using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AndreevVY.Sprint4.Task6.V26.Lib;

namespace Tyuiu.AndreevVY.Sprint4.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Андреев В.Ю. | Смарт-Б-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Андреев Владимир Юрьевич | Смарт-Б-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, выводящую из строкового массива элементы, длина     *");
            Console.WriteLine("* которых больше 5.                                                       *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] city = { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
            Console.WriteLine("Исходный массив: ");
            Console.WriteLine("[{0}]", string.Join(", ", city));


            string[] res = ds.Calculate(city);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Элементы, длина которых больше пяти: " + "[{0}]", string.Join(", ", res));

            Console.ReadKey();
        }
    }
}
