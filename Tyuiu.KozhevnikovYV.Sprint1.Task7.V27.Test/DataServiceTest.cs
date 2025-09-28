namespace Tyuiu.KozhevnikovYV.Sprint1.Task7.V27.Test
{
    using Tyuiu.KozhevnikovYV.Sprint1.Task7.V27.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = -3.597;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
