using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class NumberPhoneRepositoty : IParkingRepository<NumberPhone>
    {
        public NumberPhoneRepositoty(DataBase db)
        {
            this.db = db;

        }
        private DataBase db;
        public void Edit(NumberPhone Model)
        {
            string sql = "UPDATE [Номер телефона] SET  ИМЯСТОЛБЦА = ЗНАЧЕНИЕ WHERE УСЛОВИЕ";
        }

        public DataSet GetDataSet(string sql)
        {
            sql = "SELECT * from Тариф where";
            return null;
        }

        public List<NumberPhone> GetList()
        {
            throw new NotImplementedException();
        }

        public List<NumberPhone> GetList(string sql)
        {
            sql = "SELECT * from [Номер телефона]";
            return null;
        }

        public NumberPhone GetModel()
        {
            throw new NotImplementedException();
        }

        public NumberPhone GetModel(string sql)
        {
            throw new NotImplementedException();
        }

        public void Insert(NumberPhone Model)
        {
            string sql = $"INSERT INTO [Номер телефона] (Номер_телефона) values ({Model.Id},{Model.Number}) ";
        }

        public void Remove(NumberPhone Model)
        {
            string sql = "DELETE FROM [Номер телефона] where ";
        }
    }

}



