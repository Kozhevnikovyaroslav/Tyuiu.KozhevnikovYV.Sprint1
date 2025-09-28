namespace Tyuiu.KozhevnikovYV.Sprint1.Task6.V16.Test
{
    using Tyuiu.KozhevnikovYV.Sprint1.Task6.V16.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSymbols()
        {
            DataService ds = new DataService();
            string strtest = "123456?";
            bool res = ds.CheckSpecSymbols(strtest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
