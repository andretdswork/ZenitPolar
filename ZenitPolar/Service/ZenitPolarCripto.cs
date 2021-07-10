using System.Linq;

namespace ZenitPolar.Service
{
    public abstract class ZenitPolarCripto
    {
        private string KEYS_ZENIT = @"+_)(*&¨%$#@!'zxcvbnm,.;/asdfghjklç~][´poiuyAtrewq1234567890-='`{}^?:><B";
        private string KEYS_POLAR = @"1qaz2wsx3edc4rfv5tgb6yhn7ujm8ik,9ol.;çp0-´B~/][=<>:?}^{`+_)(*&¨%$#@!'\A";     
        private string _fraseCriptografada;
        private int _tamanhoFrase;
        private string _fraseRetorno;

        protected ZenitPolarCripto(string fraseCriptografada)
        {
            _fraseCriptografada = fraseCriptografada;
            _tamanhoFrase = fraseCriptografada.Length;
        }

        protected string Criptografar()
        {
            _fraseRetorno = string.Empty;
            for (int i = 0; i < _tamanhoFrase; i++)
                _fraseRetorno += TrocarLetra(_fraseCriptografada[i]);            

            return _fraseRetorno;
        }

        protected string Descriptografar()
        {
            _fraseRetorno = string.Empty;
            for (int i = 0; i < _tamanhoFrase; i++)            
                _fraseRetorno += TrocarLetraParaDescriptografia(_fraseCriptografada[i]);
            
            return _fraseRetorno;
        }

        private char TrocarLetra(char letra)
        {
            int posicaoLetraZenit = retornarPosicaoLetra(letra, KEYS_ZENIT);
            int posicaoLetraPolar = retornarPosicaoLetra(letra, KEYS_POLAR);
            return ExisteLetra(letra) ? (posicaoLetraPolar >= 0 ? KEYS_ZENIT[posicaoLetraPolar] : KEYS_POLAR[posicaoLetraZenit]) : letra;
        }

        private int retornarPosicaoLetra(char letra, string palavra) => 
            palavra.IndexOf(letra) == -1 ? 0 : palavra.IndexOf(letra);
        

        private bool ExisteLetra(char letra) =>
            KEYS_ZENIT.Contains(char.ToLower(letra)) || KEYS_POLAR.Contains(char.ToLower(letra));        

        private char TrocarLetraParaDescriptografia(char letra)
        {
            int posicaoLetraPolar = retornarPosicaoLetra(letra, KEYS_POLAR);
            return ExisteLetra(letra) ? KEYS_POLAR[posicaoLetraPolar] : letra;
        }

        
    }
}
