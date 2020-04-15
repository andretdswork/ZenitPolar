using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenitPolar
{
    public class Criptografia : ICriptografia
    {        
        private string _fraseCriptografada;        
        private int _tamanhoFrase;
        private string _keyZenite = @"+_)(*&¨%$#@!'zxcvbnm,.;/asdfghjklç~][´poiuyAtrewq1234567890-='`{}^?:><B";
        private string _keyPolar =  @"1qaz2wsx3edc4rfv5tgb6yhn7ujm8ik,9ol.;çp0-´B~/][=<>:?}^{`+_)(*&¨%$#@!'\A";        

        public Criptografia(string frase)
        {
            _fraseCriptografada = frase;
            _tamanhoFrase = frase.Length;
        }
        
        private bool ExisteLetra(char letra)
        {
            return _keyZenite.Contains(char.ToLower(letra)) || _keyPolar.Contains(char.ToLower(letra));
        }

        private int getPosicaoLetra(char letra, string palavra)
        {
            return palavra.IndexOf(char.ToLower(letra)) == -1 ? 0 : palavra.IndexOf(char.ToLower(letra));
        }        

        private char TrocarLetra(char letra)
        {
            int posicaoLetraZenit = getPosicaoLetra(letra, _keyZenite);
            int posicaoLetraPolar = getPosicaoLetra(letra, _keyPolar);
            return ExisteLetra(letra) ? (posicaoLetraPolar >= 0 ? _keyZenite[posicaoLetraPolar] : _keyPolar[posicaoLetraZenit]) : letra;
        }

        private char TrocarLetraParaDescriptografia(char letra)
        {
            int posicaoLetraPolar = getPosicaoLetra(letra, _keyPolar);
            return ExisteLetra(letra) ? _keyPolar[posicaoLetraPolar] : letra;
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

        public string Descriptografar()
        {
            string frase = string.Empty;
            for (int i = 0; i < _tamanhoFrase; i++)
            {
                frase += TrocarLetraParaDescriptografia(_fraseCriptografada[i]);
            }
            return frase;
        }
    }
}
