namespace CursValutar.Models;
// raportare la RON
public class Curs
{
    public int Id { get; set; }
    public int Multiplicator { get; set; } // 1 (implicit) sau 100
    public string Valuta { get; set; } // eg EUR, USD
    public double Valoare { get; set; }
    public string ResursaDrapel => $"https://flagcdn.com/w80/{Valuta.Substring(0, 2).ToLower()}.png";
    public string Data { get; set; }

    public Curs()
    {
        Multiplicator = 1;
    }

    public override string ToString()
    {
        return Valuta;
    }
}

