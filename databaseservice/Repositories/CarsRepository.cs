using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{

    public class CarsRepository : IParkingRepository<Cars>
    {

        public CarsRepository(DataBase db)
        {
            this.db = db;

        }
        private DataBase db;
        private DataBase bd;
        
        public CarsRepository()
        {
            bd = DataBaseSinglton.GetDataBase();
        }

        public void Edit(Cars Model)
        {
            string sql = "UPDATE [Владелец авто] SET  ИМЯСТОЛБЦА = ЗНАЧЕНИЕ WHERE УСЛОВИЕ";
        }

        public List<Cars> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetList(string sql)
        {
            sql = "SELECT * from Автомобили";
            return null;
        }

        public Cars GetModel()
        {
            throw new NotImplementedException();
        }

        public Cars GetModel(string sql)
        {
             return db.GetModel<Cars>(sql);
        }

        public void Insert(Cars Model)
        {
            string sql = $"INSERT INTO Автомобили (Модель,Марка,Номер,На_стоянке,Владелец_авто,Оплата) values ({Model.Id},{Model.NumberCar},{Model.OnParking}) ";
        }

        public void Remove(Cars Model)
        {
            string sql = "DELETE FROM Автомобили where ";
        }

        DataSet IParkingRepository<Cars>.GetDataSet(string sql)
        {
            throw new NotImplementedException();
        }
    }

}



