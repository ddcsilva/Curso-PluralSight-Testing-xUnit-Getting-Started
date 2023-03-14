﻿using GameEngine.Main;

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
}
