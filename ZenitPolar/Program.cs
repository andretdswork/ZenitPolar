using System;
using ZenitPolar.Service;

namespace ZenitPolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Criptografia cripto = new Criptografia("am43@!asd54.,()23[/#2");
            Console.WriteLine(cripto.Criptografar());
            Console.WriteLine(cripto.Descriptografar());
            Console.ReadLine();
        }
    }
}
