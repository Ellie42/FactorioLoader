using System.Data.SQLite;

namespace FactorioLoader.Main.Database
{
    public class DatabaseFacade
    {
        protected string DbFile;
        public string DbString;
        public SQLiteConnection Connection => new SQLiteConnection(DbString);

//        private SQLiteConnection GetNewDbConnection()
//        {
//            return new SQLiteConnection(DbString);
//        }

        public DatabaseFacade(string dbFile)
        {
            this.DbFile = dbFile;
            this.DbString = $"Data Source={DbFile};Version=3;";
        }

        public void Setup(DatabaseSetup setup)
        {
            setup.DbFile = DbFile;
            setup.ConnectionString = DbString;
            setup.Up();
        }
    }
}