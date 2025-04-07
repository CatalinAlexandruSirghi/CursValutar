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
    
    public List<Curs> ObtineCurs(string data)
    {
        return connection.Table<Curs>().ToList();
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

