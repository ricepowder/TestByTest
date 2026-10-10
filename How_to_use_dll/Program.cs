using Calculator;

namespace How_to_use_dll
{
    class Program
    {
        static int Main(string[] args)
        {
            while (true)
            {
                string expression = Console.ReadLine() ?? "";
                if (expression.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                double result = Calc.Calculate(expression);
                Console.WriteLine(result);
                continue; //意図的だから何も言うな
            }
            return 0;
        }
    }
}


