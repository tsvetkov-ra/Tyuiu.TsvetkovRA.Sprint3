using Tyuiu.TsvetkovRA.Sprint3.Task5.V22.Lib;
namespace Tyuiu.TsvetkovRA.Sprint3.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;
            int x = 2;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = -1.009;
            Assert.AreEqual(res, wait);
        }
    }
}
