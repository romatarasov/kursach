using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class CarsModelRepository : IParkingRepository<CarsModel>
    {
        public CarsModelRepository(DataBase db)
        {
            this.db = db;

        }
        private DataBase db;
        public void Edit(CarsModel Model)
        {
            string sql = "UPDATE [Модель автомобиля] SET  ИМЯСТОЛБЦА = ЗНАЧЕНИЕ WHERE УСЛОВИЕ";
        }

        public DataSet GetDataSet(string sql)
        {
            throw new NotImplementedException();
        }

        public List<CarsModel> GetList()
        {
            throw new NotImplementedException();
        }

        public List<CarsModel> GetList(string sql)
        {
            sql = "SELECT * from [Модель автомобиля]";
            return null;
        }

        public CarsModel GetModel()
        {
            throw new NotImplementedException();
        }

        public CarsModel GetModel(string sql)
        {
            return db.GetModel<CarsModel>(sql);
        }

        public void Insert(CarsModel Model)
        {
            string sql = $"INSERT INTO [Модель автомобиля] (Модель_автомобиля) values ({Model.Id},{Model.Model}) ";
        }

        public void Remove(CarsModel Model)
        {
            string sql = "DELETE FROM [Модель автомобиля] where ";
        }
    }

}



