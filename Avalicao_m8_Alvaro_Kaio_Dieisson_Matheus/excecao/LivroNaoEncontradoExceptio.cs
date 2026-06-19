namespace Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.excecao
{
    [Serializable]
    internal class LivroNaoEncontradoException : Exception
    {
        public LivroNaoEncontradoException()
        {
        }

        public LivroNaoEncontradoException(string? message) : base(message)
        {
        }
    }
}