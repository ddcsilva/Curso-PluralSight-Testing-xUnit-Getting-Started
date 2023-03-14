using GameEngine.Main;

namespace GameEngine.Tests;

public class JogadorTestes
{
    [Fact]
    public void SejaInexperienteQuandoJogadorNovo()
    {
        Jogador sut = new Jogador();

        Assert.True(sut.Iniciante);
    }
}
