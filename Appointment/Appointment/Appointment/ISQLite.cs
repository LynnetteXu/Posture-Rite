using System;
using SQLite;

namespace Appointment
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
