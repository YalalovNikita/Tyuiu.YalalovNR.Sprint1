using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint1.Task5.V2.Lib;

namespace Tyuiu.YalalovNR.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32;
            DataService ds = new DataService();
            int res = ds.FahrenheitToСelsius(x);   
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}