using GameEngine.Main;

namespace GameEngine.Tests;

public class JogadorTestes
{
    [Fact]
    public void SejaInexperienteQuandoNovo()
    {
        Jogador sut = new Jogador();
    }
}
