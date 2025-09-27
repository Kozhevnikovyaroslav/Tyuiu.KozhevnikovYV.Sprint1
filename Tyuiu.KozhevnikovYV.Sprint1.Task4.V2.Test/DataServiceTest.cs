namespace Tyuiu.KozhevnikovYV.Sprint1.Task4.V2.Test
{ using Tyuiu.KozhevnikovYV.Sprint1.Task4.V2.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            var res = (ds.Calculate(x, y));
            Assert.AreEqual(0.5, res);

        }
    }
}
