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
            Criptografia cripto = new Criptografia("Uma leve justiça leva a varias compreensoes");
            string fraseCriptografada = cripto.Criptografar();
            Console.WriteLine(fraseCriptografada);
            Console.WriteLine(cripto.Descriptografar(fraseCriptografada));
            Console.ReadLine();
        }
    }
}
