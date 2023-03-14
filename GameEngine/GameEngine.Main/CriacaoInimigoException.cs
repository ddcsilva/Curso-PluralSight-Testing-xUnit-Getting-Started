namespace GameEngine.Main;

public class CriacaoInimigoException : Exception
{
    public CriacaoInimigoException(string mensagem, string nomeInimigo) : base(mensagem)
    {
        NomeInimigoSolicitado = nomeInimigo;
    }

    public string NomeInimigoSolicitado { get; private set; }
}