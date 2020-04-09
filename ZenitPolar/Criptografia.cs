using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenitPolar
{
    public class Criptografia
    {        
        private string _fraseCriptografada;        
        private int _tamanhoFrase;
        private string _strZenite = @"qazwsxedcrfvtgbyhnujmik,ol.pç;/~´[]=-0987654321'`{^}?:><\\|+_!@";
        private string _strPolar =  @"+_)(*&¨%$#@!'{}?:^`><pç;ol.ik,ujmyhntgbrfvedcwsxqaz!@#$%¨&*08_+";        

        public Criptografia(string frase)
        {
            _fraseCriptografada = frase;
            _tamanhoFrase = frase.Length;
        }
        
        private bool ExisteLetra(char letra)
        {
            return _strZenite.Contains(char.ToLower(letra)) || _strPolar.Contains(char.ToLower(letra));
        }

        private int getPosicaoLetra(char letra, string palavra)
        {
            return palavra.IndexOf(char.ToLower(letra)) == -1 ? 0 : palavra.IndexOf(char.ToLower(letra));
        }        

        private char TrocarLetra(char letra)
        {
            int posicaoLetraZenit = getPosicaoLetra(letra, _strZenite);
            int posicaoLetraPolar = getPosicaoLetra(letra, _strPolar);
            return ExisteLetra(letra) ? (posicaoLetraPolar >= 0 ? _strZenite[posicaoLetraPolar] : _strPolar[posicaoLetraZenit]) : letra;
        }

        public string Criptografar()
        {            
            string frase = string.Empty;
            for (int i = 0; i < _tamanhoFrase; i++)
            {
                frase += TrocarLetra(_fraseCriptografada[i]);
            }
            return frase;
        }
    }
}
