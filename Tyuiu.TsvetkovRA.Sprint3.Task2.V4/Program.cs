using Tyuiu.TsvetkovRA.Sprint3.Task2.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
       DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 9;
        double multres = 1.0;
        double step1 = Math.Sin(1);
        double step2 = Math.Pow(step1, -7);
        double step3 = 1.0;
        double step4 = 1.0;


        do

        {
            step3 = startValue / step2;
            step4 = Math.Pow(step3, -2);
            multres *= step4;
            startValue++;
    
        } while (startValue <= stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("*Написать программу используя цикл do while, которая вычисляет произведениe*");
        Console.WriteLine("* ряда по формуле                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        Console.WriteLine("X = 1 ");


        Console.WriteLine("Y = 9");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(Math.Round(multres, 3));
        Console.ReadKey();
    }  

}