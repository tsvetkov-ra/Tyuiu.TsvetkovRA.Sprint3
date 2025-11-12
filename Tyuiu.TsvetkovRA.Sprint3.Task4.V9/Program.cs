using Tyuiu.TsvetkovRA.Sprint3.Task4.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
        Console.WriteLine("* функции y=x/(cos(x) - x)                                                *");
        Console.WriteLine("* При х = 0 пропустить значение. Полученные значения перемножать.         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        Console.WriteLine("X = -5");


        Console.WriteLine("Y = 5");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(startValue, stopValue));
        Console.ReadKey();

    }
}