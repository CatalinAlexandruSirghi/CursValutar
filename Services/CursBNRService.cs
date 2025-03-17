using CursValutar.Models;
using System.Globalization;
using System.Xml;

namespace CursValutar.Services;

public class CursBNRService
{
    public static List<Curs> ObtineCurs(string url)
    {
        List<Curs> listCurs = [];

        XmlReader reader = XmlReader.Create(url);
        string data = string.Empty;

        while (reader.Read())
        {
            if (reader.IsStartElement())
            {
                if (reader.Name == "Cube")
                {
                    data = reader["date"]!;
                }

                if (reader.Name == "Rate")
                {
                    Curs curs = new Curs
                    {
                        Multiplicator = reader["multiplier"] != null ? Convert.ToInt32(reader["multiplier"]) : 1,
                        Valuta = reader["currency"]!,
                        Data = data
                    };
                    reader.Read();
                    curs.Valoare = Convert.ToDouble(reader.Value, CultureInfo.InvariantCulture);
                    listCurs.Add(curs);
                }
            }

        }

        return listCurs;
    }
}

