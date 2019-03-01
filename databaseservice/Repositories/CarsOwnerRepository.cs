using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class CarsOwnerRepository : IParkingRepository<CarsOwner>
    {
        public CarsOwnerRepository(DataBase db)
        {
            this.db = db;

        }
        private DataBase db;
        public void Edit(CarsOwner Model)
        {
            string sql = "UPDATE [Владелец авто] SET  ИМЯСТОЛБЦА = ЗНАЧЕНИЕ WHERE УСЛОВИЕ";
        }

        public DataSet GetDataSet(string sql)
        {
            throw new NotImplementedException();
        }

        public List<CarsOwner> GetList()
        {
            throw new NotImplementedException();
        }

        public List<CarsOwner> GetList(string sql)
        {
            sql = "SELECT * from [Владелец авто]";
            return null;
        }

        public CarsOwner GetModel()
        {
            throw new NotImplementedException();
        }

        public CarsOwner GetModel(string sql)
        {
            throw new NotImplementedException();
        }

        public void Insert(CarsOwner Model)
        {
            string sql = $"INSERT INTO [Владелец авто] (ФИО,Номер_телефона,Водительское_удостоверение) values ({Model.Fio},{Model.Id},{Model.Number}) ";
        }

        public void Remove(CarsOwner Model)
        {
            string sql = "DELETE FROM [Владелец авто] where ";
        }
    }

}



