using Tyuiu.BukhryakovAY.Sprint1.Task4.V16.Lib;
namespace Tyuiu.BukhryakovAY.Sprint1.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService(); 
            double wait = 0.125;
            int x = 4;
            Assert.AreEqual(wait, ds.Calculate(x));
        }
    }
}
