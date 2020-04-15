using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenitPolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Criptografia cripto = new Criptografia("A4n3d2r1et.()@Atds");                   
            Console.WriteLine(cripto.Criptografar());
            Console.WriteLine(cripto.Descriptografar());
            Console.ReadLine();
        }
    }
}
