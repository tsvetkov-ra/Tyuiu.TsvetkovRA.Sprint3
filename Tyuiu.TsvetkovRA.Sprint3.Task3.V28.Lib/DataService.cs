using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsvetkovRA.Sprint3.Task3.V28.Lib
{
    public class DataService : ISprint3Task3V28
    {
        string ISprint3Task3V28.ReplaceNumOnChar(string value, char item)
        {
            foreach (char c in value) 
            {
                if (Char.IsDigit(c))
                {
                    value = value.Replace(c, item);
                }
                
            }
            return value;
        }
    }
}
