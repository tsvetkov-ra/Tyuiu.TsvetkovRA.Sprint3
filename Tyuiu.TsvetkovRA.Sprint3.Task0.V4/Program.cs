using Tyuiu.TsvetkovRA.Sprint3.Task0.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 1;
        int y = 7;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("*Написать программу используя цикл for, которая вычисляет произведение    *");
        Console.WriteLine("* ряда по формуле                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        Console.WriteLine("X = 1 ");
      

        Console.WriteLine("Y = 7");
     
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetMultiplySeries(x, y));
        Console.ReadKey();
      

    }
}