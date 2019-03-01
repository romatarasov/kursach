using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class TariffRepository : IParkingRepository<Tariff>
    {
        public TariffRepository(DataBase db)
        {
            this.db = db;

        }
        private DataBase db;
        public void Edit(Tariff Model)
        {
            string sql = "UPDATE Тариф SET  ИМЯСТОЛБЦА = ЗНАЧЕНИЕ WHERE УСЛОВИЕ";
        }

        public DataSet GetDataSet(string sql)
        {
            sql = "SELECT * from Тариф where";
            return null;
        }

        public List<Tariff> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Tariff> GetList(string sql)
        {
            sql = "SELECT * from Тариф";
            return null;
        }

        public Tariff GetModel()
        {
            throw new NotImplementedException();
        }

        public Tariff GetModel(string sql)
        {
            throw new NotImplementedException();
        }

        public void Insert(Tariff Model)
        {
            string sql = $" INSERT INTO Тариф (Выходной_будни,Размер_Оплаты) VALUES({Model.Day},{Model.Cost})";
        }

        public void Remove(Tariff Model)
        {
            string sql = "DELETE FROM Тариф where ";
        }
    }

}



