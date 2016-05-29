using Appointment.Classes;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Appointment
{
    public class SpecialistDatabase
    {
        static object locker = new object();

        SQLiteConnection database;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
        /// if the database doesn't exist, it will create the database and all the tables.
        /// </summary>
        /// <param name='path'>
        /// Path.
        /// </param>
        public SpecialistDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables
            database.CreateTable<Specialist>();
        }

        public IEnumerable<Specialist> GetSpecialists()
        {
            lock (locker)
            {
                return (from i in database.Table<Specialist>() select i).ToList();
            }
        }

        public IEnumerable<Specialist> GetItemsNotDone()
        {
            lock (locker)
            {
                return database.Query<Specialist>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
            }
        }

        public void DeleteAllSpecialists()
        {
            lock (locker)
            {
              database.Execute("DELETE FROM [Specialist]");
            }
        }

        public Specialist GetSpecialist(int id)
        {
            lock (locker)
            {
                return database.Table<Specialist>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveSpecialist(Specialist item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    database.Update(item);
                    return item.ID;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public int DeleteSpecialist(int id)
        {
            lock (locker)
            {
                return database.Delete<Specialist>(id);
            }
        }
    }
}
