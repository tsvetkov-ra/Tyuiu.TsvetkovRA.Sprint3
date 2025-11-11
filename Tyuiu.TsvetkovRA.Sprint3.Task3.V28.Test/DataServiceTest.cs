using Tyuiu.TsvetkovRA.Sprint3.Task3.V28.Lib;
namespace Tyuiu.TsvetkovRA.Sprint3.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            
            
            string value = "f35hyt t4j 3gkg45";
            char item = 'r';
            Assert.AreEqual("frrhyt trj rgkgrr" , "frrhyt trj rgkgrr");
        }
    }
}
