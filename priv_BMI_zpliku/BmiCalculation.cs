using System;

namespace priv_BMI_zpliku
{
    public class BmiCalculation
    {
        public void ChooseTheSource(string[] args)
        {

            if (ValidateIfCommandArgsAreCorrect(args))
            {
                Console.WriteLine(SharedResources.CorrectValuesInArgs);
                CalculateFromArgs(args);
            }
            else
            {
                Console.WriteLine(SharedResources.IncorrectValuesInArgs);

                int answer = GetUserAnswerOfCalculationMethod();

                if (answer == 1)
                {
                    CalculateFromConsole();
                }
                else
                {
                    CalculateFromFile();
                }
            }
        }

        private int GetUserAnswerOfCalculationMethod()
        {
            int answer = 0;

            do
            {
                Console.WriteLine(SharedResources.ChoiceOfDataSource);

                Int32.TryParse(Console.ReadLine(), out int result);

                if (result != 1 && result != 2)
                    Console.WriteLine(SharedResources.WrongAnswerFormatOne);
                else
                    answer = result;
            } while (answer == 0);

            return answer;
        }

        private bool ValidateIfCommandArgsAreCorrect(string[] args)
        {
            return Validator.DoesItContainsThreeArguments(args) &&
                   Validator.DoesFirstParamIsManOrWoman(args) &&
                   Validator.DoesThisParamContainsDoubleValue(args[1]) &&
                   Validator.DoesThisParamContainsDoubleValue(args[2]);
        }

        public void CalculateFromConsole()
        {
            UserTemplate user = new UserTemplate();

            Console.WriteLine(SharedResources.ExpectationOfConsoleDataSource);

            AssignTheSexFromConsole(user);
            AssignTheWeightFromConsole(user);
            AssignTheHeightFromConsole(user);

            BmiResultGenerator.PrintBmiResult(user);
            BmiResultGenerator.SaveBmiResultToFile(user);

        }

        public void CalculateFromFile()
        {
            UserTemplate user = new UserTemplate();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Tytus\Desktop\PoliczMojeBmi.txt");

            if (lines.Length < 4)
            {
                Console.WriteLine(SharedResources.WrongAnswerFormatThree);
                return;
            }

            string result1 = lines[1].ToLower();
            Double.TryParse(lines[2], out double result2);
            Double.TryParse(lines[3], out double result3);

            if (result1 == null || result2 == 0 || result3 == 0)
            {

                Console.WriteLine(SharedResources.WrongAnswerFormatThree);
                return;
            }


            BmiResultGenerator.PrintBmiResult(user);
            BmiResultGenerator.SaveBmiResultToFile(user);

        }

        public void CalculateFromArgs(string[] args)
        {

            UserTemplate user = new UserTemplate();

            if (args[0].ToLower() == "m")
                user.Sex = "m";
            else if (args[0].ToLower() == "k")
                user.Sex = "k";

            user.Weight = Convert.ToDouble(args[2]);
            user.Height = Convert.ToDouble(args[1]);


            BmiResultGenerator.PrintBmiResult(user);
            BmiResultGenerator.SaveBmiResultToFile(user);

        }

        public void AssignTheSexFromConsole(UserTemplate user)
        {

            string sexLetter;

            do
            {
                Console.WriteLine(SharedResources.ExpectationOfConsoleDataSourceSexAssignment);
                sexLetter = Console.ReadLine();
                if (sexLetter.ToLower() != "m" & sexLetter.ToLower() != "k")
                    Console.WriteLine(SharedResources.WrongAnswerFormatOne);
                else
                    user.Sex = sexLetter;
            } while (user.Sex == null);
        }

        public void AssignTheWeightFromConsole(UserTemplate user)
        {
            double number;

            do
            {
                Console.WriteLine(SharedResources.ExpectationOfConsoleDataSourceWeightAssignment);
                Double.TryParse(Console.ReadLine(), out number);
                if (number <= 0)
                    Console.WriteLine(SharedResources.WrongAnswerFormatTwo);
                else
                    user.Weight = number;
            } while (user.Weight == 0);
        }

        public void AssignTheHeightFromConsole(UserTemplate user)
        {
            double number;

            do
            {
                Console.WriteLine(SharedResources.ExpectationOfConsoleDataSourceHeightAssignment);
                Double.TryParse(Console.ReadLine(), out number);
                if (!(number > 0))
                    Console.WriteLine(SharedResources.WrongAnswerFormatTwo);
                else
                    user.Height = number;
            } while (user.Height == 0);
        }


    }
}
