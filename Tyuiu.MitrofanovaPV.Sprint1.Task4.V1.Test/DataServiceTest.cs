using Tyuiu.MitrofanovaPV.Sprint1.Task4.V1.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            var res = ds.Calculate(x);
            Assert.AreEqual(0.04, res);
        }
    }
}
