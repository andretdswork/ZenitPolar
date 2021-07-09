namespace ZenitPolar.Service
{
    public class Criptografia : ZenitPolarCripto
    {
        public Criptografia(string fraseCriptografada) : base(fraseCriptografada)
        {
        }

        public new string Criptografar()
        {
            return base.Criptografar();
        }

        public new string Descriptografar()
        {
            return base.Descriptografar();
        }
    }
}
