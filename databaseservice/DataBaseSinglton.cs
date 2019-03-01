namespace databaseservice
{
    public class DataBaseSinglton
    {
        private static DataBase database;
        public static DataBase GetDataBase()
        {
            if (database != null)
            {
                database = new DataBase();
            }
            return database;
        }
    }
}
