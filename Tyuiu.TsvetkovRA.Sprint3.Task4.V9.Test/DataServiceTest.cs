using Tyuiu.TsvetkovRA.Sprint3.Task4.V9.Lib;
namespace Tyuiu.TsvetkovRA.Sprint3.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        { 
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 1.708;
            Assert.AreEqual(wait, res);
        }
    }
}
