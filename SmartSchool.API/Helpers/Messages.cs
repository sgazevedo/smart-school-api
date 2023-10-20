namespace SmartSchool.API.Helpers
{
    public static class Messages
    {
        private const string NaoEncontrado = "não foi encontrado.";
        private const string Cadastrado = "foi cadastrado.";

        public static string GetMessageNaoEncontrado(string entity)
        {
            return $"{entity} {NaoEncontrado}";
        }

        public static string GetMessageCadastrado(string entity)
        {
            return $"{entity} {Cadastrado}";
        }
    }
}