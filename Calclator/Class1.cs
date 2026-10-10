using System.ComponentModel;
using System.Linq.Expressions;

namespace Calculator
{
    public class Calc
    {
        public static double Calculate(string expression)
        {
            var Parts = new List<string>(); 
            var buffer = "";
            foreach (var c in expression)
            {
                if (c is '+' or '-')
                {
                    Parts.Add(buffer);
                    buffer = c.ToString();
                }
                else
                {
                    buffer += c;
                }
            }
            Parts.Add(buffer); // Add the last part
            return 0; // Placeholder return statement
        }
    }
}
