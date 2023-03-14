namespace GameEngine.Main;

public abstract class Inimigo
{
    public string? Nome { get; set; }

    public abstract double PoderEspecialTotal { get; }
    public abstract double QuantidadePoderEspecial { get; }

    public double AtaquePoderEspecialTotal => PoderEspecialTotal / QuantidadePoderEspecial;
}