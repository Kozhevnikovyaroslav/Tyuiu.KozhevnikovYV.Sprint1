namespace Tyuiu.KozhevnikovYV.Sprint1.Task3.V1.Test
{
    using Newtonsoft.Json.Linq;
    using Tyuiu.KozhevnikovYV.Sprint1.Task3.V1.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 3;
            double h = 6;
            double pi = 3.14159;
            double wait = 169.646;
            var res = (ds.CylinderVolume(r, h));
            Assert.AreEqual(wait, res);
        }
    }
}
