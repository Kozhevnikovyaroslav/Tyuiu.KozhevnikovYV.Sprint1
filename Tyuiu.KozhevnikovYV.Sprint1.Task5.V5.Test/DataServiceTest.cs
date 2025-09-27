namespace Tyuiu.KozhevnikovYV.Sprint1.Task5.V5.Test
{
    using Tyuiu.KozhevnikovYV.Sprint1.Task5.V5.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 16.936;
            DataService ds = new DataService();
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int wait = 9;

            Assert.AreEqual(wait, result);
        }
    }
}
