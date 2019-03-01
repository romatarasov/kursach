using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class DrivingLicenseRepository : IParkingRepository<DrivingLicense>
    {
        public DrivingLicenseRepository(DataBase db)
        {
            this.db = db;

        }
        private DataBase db;
        public void Edit(DrivingLicense Model)
        {
            string sql = "UPDATE [Водительское удостоверение] SET  ИМЯСТОЛБЦА = ЗНАЧЕНИЕ WHERE УСЛОВИЕ";
        }

        public DataSet GetDataSet(string sql)
        {
            throw new NotImplementedException();
        }

        public List<DrivingLicense> GetList()
        {
            throw new NotImplementedException();
        }

        public List<DrivingLicense> GetList(string sql)
        {
            sql = "SELECT * from [Водительское удостоверение]";
            return null;
        }

        public DrivingLicense GetModel()
        {
            throw new NotImplementedException();
        }

        public DrivingLicense GetModel(string sql)
        {
            throw new NotImplementedException();
        }

        public void Insert(DrivingLicense Model)
        {
            string sql = $"INSERT INTO [Водительское удостоверение] (Номер_телефона) values ({Model.Id},{Model.Number}) ";
        }

        public void Remove(DrivingLicense Model)
        {
            string sql = "DELETE FROM [Водительское удостоверение] where ";
        }
    }

}



