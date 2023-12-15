using System.Text.RegularExpressions;

namespace Test
{
    [TestClass]
    public class Question1Part1Test
    {
        [DataTestMethod]
        [DataRow("222222", true)]
        [DataRow("189999", true)]
        [DataRow("567899", true)]
        public void TestValidPasswords(string password, bool expected)
        {
            bool result = CheckPasswordRules(password);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("236775", false)]
        [DataRow("345789", false)]
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

            if (Regex.IsMatch(password, adjacentDigitsPattern)
                && Regex.IsMatch(password, increasingDigitsPattern))
            {
                return true;
            }

            return false;
        }
    }
}