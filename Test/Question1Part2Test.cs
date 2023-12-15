using System.Text.RegularExpressions;

namespace Test
{
    [TestClass]
    public class Question1Part2Test
    {
        [DataTestMethod]
        [DataRow("334478", true)]
        [DataRow("444557", true)]
        [DataRow("567889", true)]
        public void TestValidPasswords(string password, bool expected)
        {
            bool result = CheckPasswordRules(password);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("347779", false)]
        [DataRow("222222", false)]
        [DataRow("184759", false)]
        public void TestInvalidPasswords(string password, bool expected)
        {
            bool result = CheckPasswordRules(password);
            Assert.AreEqual(expected, result);
        }

        private bool CheckPasswordRules(string password)
        {
            string adjacentDigitsPattern = @"(\d)\1";
            string increasingDigitsPattern = @"^(0*1*2*3*4*5*6*7*8*9*)$";

            if (Regex.IsMatch(password, increasingDigitsPattern))
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
    }
}