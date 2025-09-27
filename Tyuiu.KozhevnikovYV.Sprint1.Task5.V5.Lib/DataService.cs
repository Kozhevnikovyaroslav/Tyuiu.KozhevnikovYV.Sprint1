namespace Tyuiu.KozhevnikovYV.Sprint1.Task5.V5.Lib
{
    using System;
    using System.Runtime.CompilerServices;
    using tyuiu.cources.programming.interfaces.Sprint1;
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int res = (int)((x * 10) % 10);
            return res;
        }
    }
}
