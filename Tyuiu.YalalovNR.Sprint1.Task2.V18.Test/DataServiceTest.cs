using Tyuiu.YalalovNR.Sprint1.Task2.V18.Lib;
namespace Tyuiu.YalalovNR.Sprint1.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 3;
            int c = 4;
            var res = ds.CalculateSideSquareParallelepiped(a,b,c);
            Assert.AreEqual(40, res);
        }
    }
}
