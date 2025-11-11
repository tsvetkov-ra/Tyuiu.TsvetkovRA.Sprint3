using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsvetkovRA.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sinus = Math.Sin(0.1);
            double res = 1.0;
            for (double k = startValue; k <= stopValue; k++)
            {
                res *= (sinus + k);
            }
            return Math.Round(res, 3);
        }
    }
}
