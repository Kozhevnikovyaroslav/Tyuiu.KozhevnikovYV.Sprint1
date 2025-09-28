namespace Tyuiu.KozhevnikovYV.Sprint1.Task6.V16.Lib
{
    using System.ComponentModel.DataAnnotations;
    using tyuiu.cources.programming.interfaces.Sprint1;
    using static System.Net.Mime.MediaTypeNames;

    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            if (value.Contains("!"))
            {
                return true;
            }
            if (value.Contains("?"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
