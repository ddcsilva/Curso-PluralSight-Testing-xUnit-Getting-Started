namespace GameEngine.Main
{
    public class InimigoFactory
    {
        public Inimigo Criar(string nome, bool chefe = false)
        {
            if (nome is null)
            {
                throw new ArgumentNullException(nameof(nome));
            }

            if (chefe)
            {
                if (!NomeChefeValido(nome))
                {
                    throw new CriacaoInimigoException($"{nome} não é um nome válido para um chefe inimigo, os nomes dos chefes inimigos devem terminar com 'King' ou 'Queen'", nome);
                }

                return new Chefe { Nome = nome };
            }

            return new Monstro { Nome = nome };
        }

        private bool NomeChefeValido(string name) => name.EndsWith("King") ||
                                                     name.EndsWith("Queen");
    }
}
