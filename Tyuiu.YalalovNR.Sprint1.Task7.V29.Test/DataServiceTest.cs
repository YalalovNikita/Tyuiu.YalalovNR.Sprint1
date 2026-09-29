using Tyuiu.YalalovNR.Sprint1.Task7.V29.Lib;
namespace Tyuiu.YalalovNR.Sprint1.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = 1.218;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z,res, 0.001);
        }
    }
}
