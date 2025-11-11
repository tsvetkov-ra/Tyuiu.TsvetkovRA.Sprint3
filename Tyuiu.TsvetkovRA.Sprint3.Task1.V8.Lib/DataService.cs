using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsvetkovRA.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double dot = 1.0;
            while (startValue < stopValue) 
            {
                double res =Math.Pow(1.0 / (Math.Cos(startValue) + Math.Pow(value, startValue)), startValue);
                startValue++;
                dot *= res;
            }
            return Math.Round(dot, 3);
        }
    }
}
