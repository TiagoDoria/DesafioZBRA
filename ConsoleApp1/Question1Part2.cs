using System.Text.RegularExpressions;

namespace Question1
{
    public class Question1Part2
    {
        private bool CheckPasswordRules(string password)
        {
            string adjacentDigitsPattern = @"(\d)\1";
            string increasingDigitsPattern = @"^(0*1*2*3*4*5*6*7*8*9*)$";

            if(Regex.IsMatch(password, increasingDigitsPattern))
            {
                string newPassword = RemoveMoreThanTwoRepetitions(password);
                if (Regex.IsMatch(newPassword, adjacentDigitsPattern))
                {
                    return true;
                }
            }
            
            return false;
        }

        private string RemoveMoreThanTwoRepetitions(string password)
        {
            return Regex.Replace(password, @"(\d)\1{2,}", "");
        }


        public void Result()
        {

            int count = 0;

            for (int password = 184759; password <= 856920; password++)
            {
                count = CheckPasswordRules(password.ToString()) ? count + 1 : count;
            }

            Console.WriteLine("Question 1 - Part 2 - Number of possible combinations : {0}", count);
        }
       
    }
}
