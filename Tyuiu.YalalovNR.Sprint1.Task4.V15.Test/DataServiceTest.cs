using Tyuiu.YalalovNR.Sprint1.Task4.V15.Lib;
namespace Tyuiu.YalalovNR.Sprint1.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.75;
            double y = 0.5;
            double wait = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
