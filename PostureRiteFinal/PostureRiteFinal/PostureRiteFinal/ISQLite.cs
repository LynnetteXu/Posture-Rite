using System;
using SQLite;

namespace PostureRiteFinal
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
