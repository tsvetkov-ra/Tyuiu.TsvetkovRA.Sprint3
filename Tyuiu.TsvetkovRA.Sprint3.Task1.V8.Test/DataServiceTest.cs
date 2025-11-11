using Tyuiu.TsvetkovRA.Sprint3.Task1.V8.Lib;
namespace Tyuiu.TsvetkovRA.Sprint3.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService(); 

            double value = 0.25;
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(res, -41852, 874);
        }
    }
}
