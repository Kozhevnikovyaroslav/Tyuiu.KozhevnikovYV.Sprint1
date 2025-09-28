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
            double x = 30;
            double y = 60;
            double wait = -116.061;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
