namespace CursValutar.Models;
// raportare la RON
public class Curs
{
    public int Id { get; set; }
    public int Multiplicator { get; set; } // 1 (implicit) sau 100
    public string Valuta { get; set; } // eg EUR, USD
    public double Valoare { get; set; }
    public string ResursaDrapel { get; set; }
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

