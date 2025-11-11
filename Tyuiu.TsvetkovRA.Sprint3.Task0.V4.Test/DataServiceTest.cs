using Tyuiu.TsvetkovRA.Sprint3.Task0.V4.Lib;
namespace Tyuiu.TsvetkovRA.Sprint3.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetMultiplySeries( startValue,  stopValue);
            res = Math.Round(res, 3);
            Assert.AreEqual(6482.439, res);
        }
    }
}
