using SQLite;

namespace CursValutar.Models;
// raportare la RON
public class Curs
{
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("multiplicator")]
    public int Multiplicator { get; set; } // 1 (implicit) sau 100

    [Column("valuta")]
    public string Valuta { get; set; } // eg EUR, USD

    [Column("valoare")]
    public double Valoare { get; set; }
    [Ignore]
    public string ResursaDrapel => $"https://flagcdn.com/w80/{Valuta.Substring(0, 2).ToLower()}.png";
    [Column("data")]
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

