using CursValutar.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursValutar.Data;

public class CursDao
{
    private SQLiteConnection connection;

    public CursDao()
    {
        connection = new SQLiteConnection(Path.Combine(FileSystem.AppDataDirectory, "cursvalutar.db"));

        connection.CreateTable<Curs>();

    }

    public List<Curs> ObtineCursDinData(string data)
    {
        return connection.Query<Curs>("SELECT * FROM Curs WHERE data = ?", data);
    }

    public List<Curs> ObtineCursValuta(string valuta)
    {
        return connection.Query<Curs>("SELECT * FROM Curs WHERE valuta = ? ORDER BY data", valuta);
    }

    public List<Curs> ObtineCurs(string data)
    {
        return connection.Table<Curs>().ToList();
    }

    public List<string> ObtineValute()
    {
        return connection.QueryScalars<string>("SELECT DISTINCT valuta FROM Curs");
    }

    public int StergeInregistrari()
    {
        return connection.DeleteAll<Curs>();
    }

    public int AdaugaCurs(Curs curs)
    {
        return connection.Insert(curs);
    }

    public int AdaugaCurs(List<Curs> cursuri)
    {
        return connection.InsertAll(cursuri);
    }
}

