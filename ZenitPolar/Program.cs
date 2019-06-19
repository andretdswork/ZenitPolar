using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenitPolar
{
    class Program
    {
        private static char[] zenit = { 'z', 'e', 'n', 'i', 't' };
        private static char[] polar = { 'p', 'o', 'l', 'a', 'r' };
        private static char[] letras;

        private static bool ExisteLetra(char letra)
        {
            return zenit.Contains(letra) || polar.Contains(letra);
        }

        private static char Trocar(char letra)
        {
            char result = char.MinValue;
            for (int j = 0; j < zenit.Length; j++)
            {
                if (letra == zenit[j])
                    result = polar[j];
                else if (letra == polar[j])
                    result = zenit[j];
            }
            return result;
        }

        private static void Criptografar(string frase)
        {
            letras = frase.ToCharArray();

            for (int i = 0; i < frase.Length; i++)
            {
                if (ExisteLetra(letras[i]))
                    letras[i] = Trocar(letras[i]);
                Console.Write(letras[i]);
            }
            Console.WriteLine();
        }

        private static void Descriptografar(string frase)
        {
            //letras = frase.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {                
                if (ExisteLetra(letras[i]))
                    letras[i] = Trocar(letras[i]);                
                Console.Write(letras[i]);
            }
        }       

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
