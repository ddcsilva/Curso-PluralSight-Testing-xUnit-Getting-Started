﻿using GameEngine.Main;

namespace GameEngine.Tests;

public class InimigoFactoryTestes
{
    // Object Types Asserts
    [Fact]
    public void CriaMonstroPorPadrao()
    {
        InimigoFactory sut = new InimigoFactory();

        Inimigo inimigo = sut.Criar("Zombie");

        Assert.IsType<Monstro>(inimigo);
    }

    [Fact]
    public void VerificaTipoIncorretoMonstroPadrao()
    {
        InimigoFactory sut = new InimigoFactory();

        Inimigo inimigo = sut.Criar("Zombie");

        Assert.IsNotType<DateTime>(inimigo);
    }

    [Fact]
    public void CriaChefe()
    {
        InimigoFactory sut = new InimigoFactory();

        Inimigo inimigo = sut.Criar("Zombie King", true);

        Assert.IsType<Chefe>(inimigo);
    }

    [Fact]
    public void VerificaTipoRetornadoAposCriacaoChefe()
    {
        InimigoFactory sut = new InimigoFactory();

        Inimigo inimigo = sut.Criar("Zombie King", true);

        // Faz o assert e pega o retorno do Cast
        Chefe chefe = Assert.IsType<Chefe>(inimigo);

        // Assert adicional com o tipo do Objeto
        Assert.Equal("Zombie King", chefe.Nome);
    }

    [Fact]
    public void VerificaTipoDerivadoAposCriacaoChefe()
    {
        InimigoFactory sut = new InimigoFactory();

        Inimigo inimigo = sut.Criar("Zombie King", true);

        Assert.IsAssignableFrom<Inimigo>(inimigo);
    }

    // Object Instances Asserts
    [Fact]
    public void VerificaObjetosDistintos()
    {
        InimigoFactory sut = new InimigoFactory();

        Inimigo inimigo1 = sut.Criar("Zombie");
        Inimigo inimigo2 = sut.Criar("Zombie");

        Assert.NotSame(inimigo1, inimigo2);
    }
}