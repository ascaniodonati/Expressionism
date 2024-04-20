using System.Text.RegularExpressions;

namespace Expressionism
{
    public class Expressionism
    {
        public Expressionism()
        {

        }

        public string ResolveExpression(string expr)
        {
            //1. Prima risolviamo le stringhe tra parentesi graffe

        }

        double CalculateOperation(string expr)
        {

        }

        //23+45=67
        double CalculateSimpleOperation(string expr)
        {
            var result = Regex.Match(expr, Patterns.SIMPLE_OP);

            if (!result.Success)
                throw new Exception($"L'espressione {expr} ha più di due operatori");

            double op1 = double.Parse(result.Groups[1].Value);
            string sign = result.Groups[2].Value;
            double op2 = double.Parse(result.Groups[3].Value);

            switch (sign)
            {
                case "+":
                    return op1 + op2;
                case "-":
                    return op1 - op2;
                case "*":
                    return op1 * op2;
                case "/":
                    return op1 / op2;
                default:
                    throw new Exception($"Il segno <{sign}> non è riconosciuto");
            }
        }
    }
}
