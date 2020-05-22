using System;

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
            return args[0].ToLower() == "m" || args[0].ToLower() =="k";

        }

        public static bool DoesThisParamContainsDoubleValue(string args)
        {
            return Double.TryParse(args, out double result);
        }
    }
}
