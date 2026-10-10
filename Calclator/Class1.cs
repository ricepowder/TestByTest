using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Calculator
{
    public class Calc
    {
        public static double Calculate(string expression)
        {
            List<string> Parts = []; 
            string buffer = "";
            foreach (var c in expression)
            {
                if (char.IsWhiteSpace(c))
                {
                    continue; // Skip whitespace
                }
                else if (c is '+' or '-')
                {
                    if (buffer.Length > 0)
                    {
                        Parts.Add(buffer);
                    }
                    buffer = c.ToString();
                }
                else
                {
                    buffer += c;
                }
            }
            Parts.Add(buffer); // Add the last part
            double result = Add(Parts);
            return result; // Placeholder return statement
        }
        private static double Add(List<string> parts)
        {
            double sum = 0;
            foreach (var i in parts)
            {
                if (!double.TryParse(i, out double number))
                {
                    throw new FormatException($"なんだよこれ: {i}");
                }

                sum += number;
            }
            return sum;
        }
    }
}
