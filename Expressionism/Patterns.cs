using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressionism
{
    public static class Patterns
    {
        public const string MUL_AND_DIV = @"[\*\/]";
        public const string SUM_AND_SUB = @"[\+\-]";

        //Simple operation (for ex., matchs only 23+45, not 23+45+67)
        public const string SIMPLE_OP = @"^(\d+)([\+\-\*\/])(\d+)$";

        //23*45*32
        public const string MORE_OPERATORS = @"\d+(?:{0}\d+)+";
        public static string MORE_OPERATORS_MD => string.Format(MORE_OPERATORS, MUL_AND_DIV);
        public static string MORE_OPERATORS_SS => string.Format(MORE_OPERATORS, SUM_AND_SUB);

        //(23+45)
        public const string INTO = @"\{0}[^\s\{1}]+\{1}";
        public static string INTO_CURLY_BRACKETS => string.Format(INTO, "{", "}");
        public static string INTO_SQUARE_BRACKETS => string.Format(INTO, "[", "]");
        public static string INTO_BRACKETS => string.Format(INTO, "(", ")");
    }
}
