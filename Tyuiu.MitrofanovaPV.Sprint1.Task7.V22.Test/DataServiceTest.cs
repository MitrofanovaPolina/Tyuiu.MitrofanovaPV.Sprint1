using Tyuiu.MitrofanovaPV.Sprint1.Task7.V22.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 45;
            double y = 45;
            double z = 1;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(z, res);
        }
    }
}
