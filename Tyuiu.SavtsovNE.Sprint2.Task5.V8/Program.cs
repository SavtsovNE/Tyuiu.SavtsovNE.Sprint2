using Tyuiu.SavtsovNE.Sprint2.Task5.V8.Lib;
namespace Tyuiu.SavtsovNE.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #2                                         *");
            Console.WriteLine("* Тема: Оператор switch                             *");
            Console.WriteLine("* Задание #5                                        *");
            Console.WriteLine("* Вариант #8                                        *");
            Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая использует оператор   *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает  *");
            Console.WriteLine("* результат.                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            var res = ds.FindDateOfPreviousDay(n, m);


            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Результат:" + res);

        }
    }
}