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
            Criptografia cripto = new Criptografia("263738");
            string fraseCriptografada = cripto.Criptografar();
            Console.WriteLine(fraseCriptografada);            
            Console.ReadLine();
        }
    }
}
