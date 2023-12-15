using System.Text.RegularExpressions;
namespace Question1
{
    public class Question1Part1
    {
        private bool CheckPasswordRules(string password)
        {
            string adjacentDigitsPattern = @"(\d)\1";
            string increasingDigitsPattern = @"^(0*1*2*3*4*5*6*7*8*9*)$";

            if (Regex.IsMatch(password, adjacentDigitsPattern)
                && Regex.IsMatch(password, increasingDigitsPattern))
            {
                return true;
            }

            return false;
        }
        public void Result()
        {
            int count = 0;

            for (int password = 184759; password <= 856920; password++)
            {
                count = CheckPasswordRules(password.ToString()) ? count + 1 : count;
            }

            Console.WriteLine("Question 1 - Part 1 - Number of possible combinations : {0}", count);
        }
    }
}