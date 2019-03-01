using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class CarsBrandRepository : IParkingRepository<CarsBrand>
    {
        public CarsBrandRepository(DataBase db)
        {
            this.db = db;
            
        }
        private DataBase db;
        public void Edit(CarsBrand Model)
        {
            string sql = "UPDATE  Марка_автомобиля SET  ИМЯСТОЛБЦА = ЗНАЧЕНИЕ WHERE УСЛОВИЕ";
        }

        public DataSet GetDataSet(string sql)
        {
            throw new NotImplementedException();
        }

        public List<CarsBrand> GetList()
        {
            throw new NotImplementedException();
        }

        public List<CarsBrand> GetList(string sql)
        {
            sql = "SELECT * from Марка_автомобиля";
            return null;

        }

        public CarsBrand GetModel()
        {
            throw new NotImplementedException();
        }

        public CarsBrand GetModel(string sql)
        {
            throw new NotImplementedException();
        }

        public void Insert(CarsBrand Model)
        {
            string sql = $"INSERT INTO Марка_автомобиля (Марка_автомобиля,Модель_автомобиля) values ({Model.Id},{Model.Brand}) ";
        }

        public void Remove(CarsBrand Model)
        {
            string sql = "DELETE FROM Марка_автомобиля where ";
        }
    }

}



