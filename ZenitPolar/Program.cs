using System;
using ZenitPolar.Service;

namespace ZenitPolar
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = PasswordGenerator.Generate(20);
            Console.WriteLine(password + "\n");
            Criptografia cripto = new Criptografia(password);
            Console.WriteLine(cripto.Criptografar());
            Console.WriteLine(cripto.Descriptografar());
            Console.ReadLine();
        }

        public static void Teste()
        {
            const string baseCripto = @"\zxcvbnm,.;/asdfgjklç~]qwertyuiop´['1234567890-=|ZXCVBNM<>:?}^ÇLKJHGFDSAQWERTYUIOP`{!@#$%¨&*()_+";
            int baseCriptoLength = baseCripto.Length;
            int passwordLength = 10;
            Random random = new Random();
            for (int i = 0; i < passwordLength; i++)
            {
                Console.Write(baseCripto[random.Next(0, baseCriptoLength)]);
            }
        }
    }
}
