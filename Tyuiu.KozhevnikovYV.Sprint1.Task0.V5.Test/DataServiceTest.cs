namespace Tyuiu.KozhevnikovYV.Sprint1.Task0.V5.Test
{
    using Tyuiu.KozhevnikovYV.Sprint1.Task0.V5.Lib;

    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(12, res);
     
        
        }
    }
}
