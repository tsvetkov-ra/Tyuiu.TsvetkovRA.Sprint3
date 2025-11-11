using System.Diagnostics;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TsvetkovRA.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
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
            return Math.Round(multres, 3);
        }   
    }
}
