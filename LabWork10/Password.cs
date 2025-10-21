using System.Text.RegularExpressions;

namespace LabWork10
{
    public class Password
    {
        public static bool ValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            return password.Any(char.IsDigit) && password.Any(ch =>
                   (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'));
        }
    }
}
