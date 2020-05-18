using System;

namespace priv_BMI_zpliku
{
    public class BmiResultGenerator
    {
        public static void SaveBmiResultToFile(UserTemplate user)
        {
            string text = $"Twój wskaźnik BMI wynosi:{user.Bmi} \r {user.Evaluation} \r Źródło : https://pl.wikipedia.org/wiki/Wska%C5%BAnik_masy_cia%C5%82a";
            System.IO.File.WriteAllText(@"C:\Users\Tytus\Desktop\wyniki.txt", text);
        }

        public static void PrintBmiResult(UserTemplate user)
        {
            Console.WriteLine($"Twój wskaźnik BMI wynosi: {user.Bmi} ");
            Console.WriteLine($"{user.Evaluation}");
            Console.WriteLine("Źródło : https://pl.wikipedia.org/wiki/Wska%C5%BAnik_masy_cia%C5%82a");

        }

    }
}
