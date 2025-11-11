using Tyuiu.TsvetkovRA.Sprint3.Task3.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Используя цикл foreach заменить цифры на букву r в строке:              *");
        Console.WriteLine("* f35hyt t4j 3gkg45                                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
      

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string value = "f35hyt t4j 3gkg45";
        char item = 'r';

        foreach (char c in value)
        {
            if (Char.IsDigit(c))
            {
                value = value.Replace(c, item);
            }

        }
        Console.WriteLine(value);
    }
}