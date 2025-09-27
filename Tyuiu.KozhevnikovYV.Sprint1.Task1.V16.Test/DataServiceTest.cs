namespace Tyuiu.KozhevnikovYV.Sprint1.Task1.V16.Test
{
    using Tyuiu.KozhevnikovYV.Sprint1.Task1.V16.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3.0;
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(a,x,y);
            Assert.AreEqual(19, res);

        }
    }
}
