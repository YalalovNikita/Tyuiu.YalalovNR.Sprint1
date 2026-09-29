using Tyuiu.YalalovNR.Sprint1.Task3.V1.Lib;
namespace Tyuiu.YalalovNR.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double h = 2;
            double r = 3;
            double wait = 56.52;
            var res = ds.CylinderVolume(r,h);
            Assert.AreEqual(wait, res);
        }
    }
}
