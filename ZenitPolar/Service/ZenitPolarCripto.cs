using System.Linq;

namespace ZenitPolar.Service
{
    public abstract class ZenitPolarCripto
    {
        private string _keyZenite = @"+_)(*&¨%$#@!'zxcvbnm,.;/asdfghjklç~][´poiuyAtrewq1234567890-='`{}^?:><B";
        private string _keyPolar = @"1qaz2wsx3edc4rfv5tgb6yhn7ujm8ik,9ol.;çp0-´B~/][=<>:?}^{`+_)(*&¨%$#@!'\A";
        private string _fraseCriptografada;
        private int _tamanhoFrase;

        protected ZenitPolarCripto(string fraseCriptografada)
        {
            _fraseCriptografada = fraseCriptografada;
            _tamanhoFrase = fraseCriptografada.Length;
        }

        protected string Criptografar()
        {
            string frase = string.Empty;
            for (int i = 0; i < _tamanhoFrase; i++)
            {
                frase += TrocarLetra(_fraseCriptografada[i]);
            }
            return frase;
        }

        protected string Descriptografar()
        {
            string frase = string.Empty;
            for (int i = 0; i < _tamanhoFrase; i++)
            {
                frase += TrocarLetraParaDescriptografia(_fraseCriptografada[i]);
            }
            return frase;
        }

        private char TrocarLetra(char letra)
        {
            int posicaoLetraZenit = retornarPosicaoLetra(letra, _keyZenite);
            int posicaoLetraPolar = retornarPosicaoLetra(letra, _keyPolar);
            return ExisteLetra(letra) ? (posicaoLetraPolar >= 0 ? _keyZenite[posicaoLetraPolar] : _keyPolar[posicaoLetraZenit]) : letra;
        }

        private int retornarPosicaoLetra(char letra, string palavra)
        {
            return palavra.IndexOf(letra) == -1 ? 0 : palavra.IndexOf(letra);
        }

        private bool ExisteLetra(char letra)
        {
            return _keyZenite.Contains(char.ToLower(letra)) || _keyPolar.Contains(char.ToLower(letra));
        }

        private char TrocarLetraParaDescriptografia(char letra)
        {
            int posicaoLetraPolar = retornarPosicaoLetra(letra, _keyPolar);
            return ExisteLetra(letra) ? _keyPolar[posicaoLetraPolar] : letra;
        }
    }
}
