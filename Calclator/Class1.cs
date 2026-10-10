using System.ComponentModel;
using System.Linq.Expressions;

namespace Calclator
{
    public class Calc
    {
        public static double Add(string expression)
        {
            string[] parts = expression.Split('+');

            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[1]);

            return a + b;
        }

        public static double Dif(string expression)
        {
            string[] parts = expression.Split('-');

            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[1]);

            return a - b;
        }
    }
}
