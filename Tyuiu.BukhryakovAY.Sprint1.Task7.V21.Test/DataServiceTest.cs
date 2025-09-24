using Tyuiu.BukhryakovAY.Sprint1.Task7.V21.Lib;
namespace Tyuiu.BukhryakovAY.Sprint1.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 1,66);
        }
    }
}
