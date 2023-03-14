using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameEngine.Main;

public class Jogador : INotifyPropertyChanged
{
    public Jogador()
    {
        Nome = GerarNomeAleatorio();

        Iniciante = true;

        CriarArmasIniciais();
    }

    private int _saude = 100;

    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? NomeCompleto => $"{Nome} {Sobrenome}";
    public string? Apelido { get; set; }
    public bool Iniciante { get; set; }
    public List<string>? Armas { get; set; }

    public int Saude
    {
        get => _saude;
        set
        {
            _saude = value;
            OnPropertyChanged();
        }
    }

    public event EventHandler<EventArgs>? Dormindo;

    public void Dormir()
    {
        var aumentoDeSaude = CalcularAumentoDeSaude();

        Saude += aumentoDeSaude;

        JogadorAdormecido(EventArgs.Empty);
    }

    private int CalcularAumentoDeSaude()
    {
        var random = new Random();

        return random.Next(1, 101);
    }


    protected virtual void JogadorAdormecido(EventArgs e)
    {
        Dormindo?.Invoke(this, e);
    }

    public void LevaDano(int dano)
    {
        Saude = Math.Max(1, Saude -= dano);
    }

    private string GerarNomeAleatorio()
    {
        var possiveisNomesIniciaisAleatorios = new[]
        {
            "Danieth",
            "Derick",
            "Shalnorr",
            "G'Toth'lop",
            "Boldrakteethtop"
        };

        return possiveisNomesIniciaisAleatorios[new Random().Next(0, possiveisNomesIniciaisAleatorios.Length)];
    }

    private void CriarArmasIniciais()
    {
        Armas = new List<string>
        {
            "Arco Longo",
            "Arco Curto",
            "Espada Curta",
        };
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}