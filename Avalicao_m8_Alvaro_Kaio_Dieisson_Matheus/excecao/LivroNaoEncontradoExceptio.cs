namespace Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.excecao
{
    [Serializable]
    internal class LivroNaoEncontradoExceptio : Exception
    {
        public LivroNaoEncontradoExceptio()
        {
        }

        public LivroNaoEncontradoExceptio(string? message) : base(message)
        {
        }

        public LivroNaoEncontradoExceptio(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}