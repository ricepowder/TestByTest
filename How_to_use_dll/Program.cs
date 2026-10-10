using Calclator;

while (true)
{
    string expression = Console.ReadLine() ?? "";
    if (expression == "exit")
        break;

    double result = expression switch
    {
        var s when s.Contains('+') => Calc.Add(s),
        var s when s.Contains('-') => Calc.Dif(s),
        _ => throw new ArgumentException("それ数式？"),
    };

    Console.WriteLine(result);
}