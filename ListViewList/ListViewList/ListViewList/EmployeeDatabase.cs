using ListViewList.Implementations;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewList
{
    public class EmployeeDatabase
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
        public EmployeeDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables

            database.CreateTable<Employee>();
        }



        public IEnumerable<Employee> GetEmployees()
        {
            lock (locker)
            {
                return (from i in database.Table<Employee>() select i).ToList();
            }
        }




        public void DeleteAllEmployee()
        {
            lock (locker)
            {
                database.Execute("DELETE FROM [Employee]");
            }
        }



        public Employee GetEmployee(int id)
        {
            lock (locker)
            {
                return database.Table<Employee>().FirstOrDefault(x => x.ID == id);
            }
        }



        public int SaveEmployee(Employee item)
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


        public int DeleteEmployee(int id)
        {
            lock (locker)
            {
                return database.Delete<Employee>(id);
            }
        }
    }
}
