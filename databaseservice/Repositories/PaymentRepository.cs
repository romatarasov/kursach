using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class PaymentRepository : IParkingRepository<Payment>
    {
        public PaymentRepository(DataBase db)
        {
            this.db = db;

        }
        private DataBase db;
        public void Edit(Payment Model)
        {
            string sql = "UPDATE Оплата SET  ИМЯСТОЛБЦА = ЗНАЧЕНИЕ WHERE УСЛОВИЕ";
        }

        public DataSet GetDataSet(string sql)
        {
            sql = "SELECT * from Оплата where";
            return null;
        }

        public List<Payment> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetList(string sql)
        {
            sql = "SELECT * from Оплата";
            return null;
        }

        public Payment GetModel()
        {
            throw new NotImplementedException();
        }

        public Payment GetModel(string sql)
        {
            return db.GetModel<Payment>(sql);
        }

        public void Insert(Payment Model)
        {
            string sql = $" INSERT INTO Оплата (Способ_оплаты,Дата_заезда,Дата_выезда,Тариф,id_владельца_авто) VALUES({Model.Id},{Model.PaymentMethod},{Model.ArrivalDate},{Model.DepartureDate})";
        }

        public void Remove(Payment Model)
        {
            string sql = "DELETE FROM Оплата where ";
        }
    }

}



