using GameEngine.Main;

namespace GameEngine.Tests;

public class JogadorTestes
{
    // Boolean Asserts
    [Fact]
    public void SejaInexperienteQuandoJogadorNovo()
    {
        Jogador sut = new Jogador();

        Assert.True(sut.Iniciante);
    }

    // String Asserts
    [Fact]
    public void ValidaNomeCompleto()
    {
        Jogador sut = new Jogador();

        sut.Nome = "Danilo";
        sut.Sobrenome = "Silva";

        Assert.Equal("Danilo Silva", sut.NomeCompleto);
    }

    [Fact]
    public void ValidaNomeCompletoIniciandoPeloPrimeiroNome()
    {
        Jogador sut = new Jogador();

        sut.Nome = "Danilo";
        sut.Sobrenome = "Silva";

        Assert.StartsWith("Danilo", sut.NomeCompleto);
    }

    [Fact]
    public void ValidaNomeCompletoTerminandoPeloSegundoNome()
    {
        Jogador sut = new Jogador();

        sut.Nome = "Danilo";
        sut.Sobrenome = "Silva";

        Assert.EndsWith("Silva", sut.NomeCompleto);
    }

    [Fact]
    public void ValidaNomeCompletoIgnorandoLetraMaiusculaMinuscula()
    {
        Jogador sut = new Jogador();

        sut.Nome = "DANILO";
        sut.Sobrenome = "silva";

        Assert.Equal("Danilo Silva", sut.NomeCompleto, ignoreCase: true);
    }

    [Fact]
    public void ValidaNomeCompletoComSubstring()
    {
        Jogador sut = new Jogador();

        sut.Nome = "Danilo";
        sut.Sobrenome = "Silva";

        Assert.Contains("lo Si", sut.NomeCompleto);
    }

    [Fact]
    public void ValidaNomeCompletoComExpressaoRegular()
    {
        Jogador sut = new Jogador();

        sut.Nome = "Danilo";
        sut.Sobrenome = "Silva";

        Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.NomeCompleto);
    }

    // Number Asserts
    [Fact]
    public void IniciaComSaudePadrao()
    {
        Jogador sut = new Jogador();

        Assert.Equal(100, sut.Saude);
    }

    [Fact]
    public void IniciaComSaudeDiferenteZero()
    {
        Jogador sut = new Jogador();

        Assert.NotEqual(0, sut.Saude);
    }

    [Fact]
    public void AumentaSaudeDepoisDeDormir()
    {
        Jogador sut = new Jogador();

        sut.Dormir(); // Aguarda o aumento da Saude entre 1 a 100

        Assert.InRange(sut.Saude, 101, 200); // Espera um valor de Saúde entre 101 e 200
    }

    // Null Asserts
    [Fact]
    public void NaoPossuiApelidoPorPadrao()
    {
        Jogador sut = new Jogador();

        Assert.Null(sut.Apelido);
    }

    // Collection Asserts
    [Fact]
    public void PossuiArcoLongo()
    {
        Jogador sut = new Jogador();

        Assert.Contains("Arco Longo", sut.Armas);
    }

    [Fact]
    public void NaoPossuiCajadoSimples()
    {
        Jogador sut = new Jogador();

        Assert.DoesNotContain("Cajado Simples", sut.Armas);
    }

    [Fact]
    public void PossuiPeloMenosUmTipoDeEspada()
    {
        Jogador sut = new Jogador();

        Assert.Contains(sut.Armas, arma => arma.Contains("Espada"));
    }

    [Fact]
    public void PossuiTodasAsArmas()
    {
        Jogador sut = new Jogador();

        var armasEsperadas = new[]
        {
            "Arco Longo",
            "Arco Curto",
            "Espada Curta"
        };

        Assert.Equal(armasEsperadas, sut.Armas);
    }

    [Fact]
    public void PossuiArmasPorPadrao()
    {
        Jogador sut = new Jogador();

        Assert.All(sut.Armas, arma => Assert.False(string.IsNullOrWhiteSpace(arma)));
    }
}
