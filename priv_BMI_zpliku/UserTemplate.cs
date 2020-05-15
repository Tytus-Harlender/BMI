using System;
using System.Collections.Generic;
using System.Text;

namespace priv_BMI_zpliku
{
    //ctrl+k, ctrl+d justowanie tekstu
    public class UserTemplate
    {
        
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Sex { get; set; }
        public double Bmi
        {
            get { return Weight / Math.Pow(Height, 2); }
        }
        public string Evaluation
        {
            get
            {
                //Sex == 1 is men
                if (Sex == 1)
                {
                    if (Bmi < 18.5)
                        return "Mężczyzno! Masz niedowagę!";

                    else if (18.5 <= Bmi & Bmi < 25.0)
                        return "Mężczyzno! Twoja waga jest w sam raz!";

                    else return "Mężczyzno! Masz nadwagę!";
                }
                else  //Sex == 2 is women
                {
                    if (Bmi < 18.5)
                        return "Kobieto! Masz niedowagę!";

                    else if (18.5 <= Bmi & Bmi < 25.0)
                        return "Kobieto! Twoja waga jest w sam raz!";

                    else return "Kobieto! Masz nadwagę!";
                }





            }
        }

        public UserTemplate()
        {


        }

        public string ShowInformation()
        {
            //Sex == 1 is men
            if (Sex == 1)
            {
                if (Bmi < 18.5)
                    return "Mężczyzno! Masz niedowagę!";

                else if (18.5 <= Bmi & Bmi < 25.0)
                    return "Mężczyzno! Twoja waga jest w sam raz!";

                else return "Mężczyzno! Masz nadwagę!";
            }
            else  //Sex == 2 is women
            {
                if (Bmi < 18.5)
                    return "Kobieto! Masz niedowagę!";

                else if (18.5 <= Bmi & Bmi < 25.0)
                    return "Kobieto! Twoja waga jest w sam raz!";

                else return "Kobieto! Masz nadwagę!";
            }

        }

    }
}