using Calculator;

while (true)
{
    Console.Write("Calc> ");
    string expression = Console.ReadLine() ?? "";
    if (expression.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    try
    {
        double result = Calc.Calculate(expression);
        Console.WriteLine(result);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    continue; //意図的だから何も言うな
}