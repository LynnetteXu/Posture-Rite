using System;
using SQLite;

namespace PostureRite
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
