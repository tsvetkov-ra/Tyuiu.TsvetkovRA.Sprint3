using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsvetkovRA.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                
                double step1 = 2 * x - 0.5;
                double step2 = 1 + Math.Sin(x);
                double step3 = step2 / step1;
                double step4 = 5 - x * 3 + step3;
                y = step4;
                if (x == 0.25)
                {
                    y = 0;
                }

                valueArray[count] = Math.Round(y, 2);
                count++;
                
            }
            return valueArray;
        }
    }
}
