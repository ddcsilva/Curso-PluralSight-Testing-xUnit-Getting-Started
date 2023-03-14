using GameEngine.Main;

namespace GameEngine.Tests;

public class ChefeTestes
{
    // Floating Points Asserrt
    [Fact]
    public void VerificaPoderCorreto()
    {
        Chefe sut = new Chefe();

        Assert.Equal(166.667, sut.AtaquePoderEspecialTotal, 3);
    }
}
