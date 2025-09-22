using Tyuiu.BukhryakovAY.Sprint1.Task5.V5.Lib;
namespace Tyuiu.BukhryakovAY.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 8275.1782;
            int res = ds.Calculate(x);
            Assert.AreEqual(1,res);
        }
    }
}
