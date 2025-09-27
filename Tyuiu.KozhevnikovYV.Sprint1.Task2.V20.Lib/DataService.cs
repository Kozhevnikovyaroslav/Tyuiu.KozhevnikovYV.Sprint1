namespace Tyuiu.KozhevnikovYV.Sprint1.Task2.V20.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint1;
    public class DataService : ISprint1Task2V20
    {
        public int CalculateSquaresSumm(int value, int valueTwo)
        {
            return value * value + valueTwo * valueTwo;
        }
    }
}
