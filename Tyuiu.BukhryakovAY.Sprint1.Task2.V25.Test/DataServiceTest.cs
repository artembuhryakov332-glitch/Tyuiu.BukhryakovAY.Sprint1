using Tyuiu.BukhryakovAY.Sprint1.Task2.V25.Lib;
namespace Tyuiu.BukhryakovAY.Sprint1.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            var result = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(57.296, result);
        }
    }
}
