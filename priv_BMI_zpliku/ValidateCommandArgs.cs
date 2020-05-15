using System;
using System.Collections.Generic;
using System.Text;

namespace priv_BMI_zpliku
{
    public static class Validator
    {

        public static bool DoesItContainsThreeArguments(string[] args)
        {
            return args.Length == 3;
        }

        public static bool DoesFirstParamIsManOrWoman(string [] args)
        {
            return args[0].ToUpper() == "M" || args[0].ToUpper() =="K";

        }

        public static bool DoesThisParamContainsDoubleValue(string args)
        {
            return Double.TryParse(args, out double result);
        }
    }
}
