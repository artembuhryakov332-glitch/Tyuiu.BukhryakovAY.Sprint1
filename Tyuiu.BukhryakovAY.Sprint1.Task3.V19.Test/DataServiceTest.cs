using Tyuiu.BukhryakovAY.Sprint1.Task3.V19.Lib;
namespace Tyuiu.BukhryakovAY.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool wait = true;
            bool res = ds.ElephCanMove(1, 2, 3, 4);
            Assert.AreEqual(wait, res);
        }
    }
}
