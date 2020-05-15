namespace priv_BMI_zpliku
{
    public class FileGenerator
    {
        public static void GenerateTheFile(UserTemplate user)
        {
            string text = $"Twój wskaźnik BMI wynosi:{user.Bmi} \r {user.Evaluation} \r Źródło : https://pl.wikipedia.org/wiki/Wska%C5%BAnik_masy_cia%C5%82a";
            System.IO.File.WriteAllText(@"C:\Users\Tytus\Desktop\wyniki.txt", text);
        }
    }
}
