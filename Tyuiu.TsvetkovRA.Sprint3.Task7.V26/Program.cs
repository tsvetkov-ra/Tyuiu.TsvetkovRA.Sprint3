using Tyuiu.TsvetkovRA.Sprint3.Task7.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
       DataService ds = new DataService();
        int startValue = -5;

        int stopValue = 5;

        int len = ds.GetMassFunction(startValue,stopValue).Length;

        double[] valueArray;

        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Напишите программу, которая которая выводит таблицу значения функции    *");
        Console.WriteLine("* на диапазоне [-5, 5]                                                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+-----------+------------+");
        Console.WriteLine("|    X      |   f(x)     |");
        Console.WriteLine("+-----------+------------+");


        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}      |   {1, 5:f2}    |"      , startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+-----------+------------+");
        Console.ReadKey();
    }
}