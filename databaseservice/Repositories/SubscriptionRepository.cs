using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class SubscriptionRepository : IParkingRepository<Subscription>
    {
        public SubscriptionRepository(DataBase db)
        {
            this.db = db;

        }
        private DataBase db;
        public void Edit(Subscription Model)
        {
            string sql = "UPDATE Абонемент SET  ИМЯСТОЛБЦА = ЗНАЧЕНИЕ WHERE УСЛОВИЕ";
        }

        public DataSet GetDataSet(string sql)
        {
            sql = "SELECT * from Абонемент where";
            return null;
        }

        public List<Subscription> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Subscription> GetList(string sql)
        {
            sql = "SELECT * from Абонемент";
            return null;
        }

        public Subscription GetModel()
        {
            throw new NotImplementedException();
        }

        public Subscription GetModel(string sql)
        {
            throw new NotImplementedException();
        }

        public void Insert(Subscription Model)
        {
            string sql = $" INSERT INTO Абонемент (id_автомобиля,Срок_дейсвтия,Стоимость,Дата_начала,Дата_окончания) VALUES( {Model.Duration},{Model.Price},{Model.StartDate},{Model.EndDate})";
        }

        public void Remove(Subscription Model)
        {
            string sql = "DELETE FROM Абонемент where ";
        }
    }

}



