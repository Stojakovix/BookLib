using SQLite;
using System.Diagnostics;
using BookLib.Model;

namespace BookLib.Data
{
    public class Conn
    {
        public string _dbPath;
        private SQLiteConnection _conn;
        public Conn(string dbPath)
        {
            _dbPath = dbPath;

        }

        public void Init()
        {
            try
            {
                _conn = new SQLiteConnection(_dbPath);
                _conn.CreateTable<BookItem>();
                Debug.WriteLine("Successful");

            }
            catch (Exception ex)
            {

                Debug.WriteLine("error in conn " + ex.Message);
            }
            
        }
        public void Insert(BookItem item)
        {
            _conn = new SQLiteConnection(_dbPath);
            _conn.Insert(item);
        }

        public void Delete(int id)
        {
            _conn = new SQLiteConnection(_dbPath);
            _conn.Delete(new { Id = id });
        }

        public void Update(BookItem item)
        {
            _conn = new SQLiteConnection(_dbPath);
            _conn.Update(item);

        }
    }
}
