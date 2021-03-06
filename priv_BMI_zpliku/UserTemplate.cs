﻿using System;

namespace priv_BMI_zpliku
{
    public class UserTemplate
    {
        
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Sex { get; set; }
        public double Bmi => Weight / Math.Pow(Height, 2);

        public string Evaluation
        {
            get
            {
                //Sex == m is men
                if (Sex == "m")
                {
                    if (Bmi < 18.5)
                        return "Mężczyzno! Masz niedowagę!";

                    else if (18.5 <= Bmi & Bmi < 25.0)
                        return "Mężczyzno! Twoja waga jest w sam raz!";

                    else return "Mężczyzno! Masz nadwagę!";
                }
                else  //Sex == k is women
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

    }
}