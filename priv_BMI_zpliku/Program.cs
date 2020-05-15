using System;
using priv_BMI_zpliku;

namespace priv_BMI_zpliku

{
    class Program
    {
        static void Main(string[] args)
        {


            BmiCalculation bmiCalculation = new BmiCalculation();

            bmiCalculation.ChooseTheSource(args);

            
            
        }
    }
}
