using Tyuiu.BukhryakovAY.Sprint1.Task6.V13.Lib;
namespace Tyuiu.BukhryakovAY.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            String x = "ABCD";
            bool res = ds.CheckWordsAlphabet(x);
            Assert.AreEqual(res,true);
        }
    }
}
