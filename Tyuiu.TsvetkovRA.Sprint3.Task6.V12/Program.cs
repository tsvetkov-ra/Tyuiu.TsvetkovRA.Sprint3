using Tyuiu.TsvetkovRA.Sprint3.Task6.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = 9;
        int endValue = 18;
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
        Console.WriteLine("*принадлежащих числовому отрезку [9, 18] сумму  всех делителей            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        Console.WriteLine("[9, 18]");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetSumTheDivisors(startValue, endValue));
        Console.ReadKey();
    }
}