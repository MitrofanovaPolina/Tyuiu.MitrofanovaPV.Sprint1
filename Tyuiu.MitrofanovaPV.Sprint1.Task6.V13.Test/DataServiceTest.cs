using Tyuiu.MitrofanovaPV.Sprint1.Task6.V13.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "абв";
            DataService ds = new DataService();
            var res = ds.CheckWordsAlphabet( strTest );
            Assert.AreEqual(res, true );
        }
    }
}
