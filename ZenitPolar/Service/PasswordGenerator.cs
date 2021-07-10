using System;

namespace ZenitPolar.Service
{
    public static class PasswordGenerator
    {
        private const string BASE_CRIPTO = @"\zxcvbnm,.;/asdfgjklç~]qwertyuiop´['1234567890-=|ZXCVBNM<>:?}^ÇLKJHGFDSAQWERTYUIOP`{!@#$%¨&*()_+";

        public static string Generate(int passwordLength)
        {
            string passwordGenereted = string.Empty;
            Random random = new Random();
            for (int i = 0; i < passwordLength - 1; i++)
            {
                passwordGenereted += BASE_CRIPTO[random.Next(0, BASE_CRIPTO.Length)];
            }
            return passwordGenereted;
        }        
    }
}
