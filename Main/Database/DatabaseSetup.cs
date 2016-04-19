namespace FactorioLoader.Main.Database
{
    public abstract class DatabaseSetup
    {
        public string ConnectionString;
        public string DbFile;

        public abstract void Up();
        public abstract void Down();
    }
}