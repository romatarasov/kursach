using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class CarsRepository : IParkingRepository<Cars>
    {
        
        private DataBase bd;
        
        public CarsRepository()
        {
            bd = DataBaseSinglton.GetDataBase();
        }
        public List<Cars> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetList(string sql)
        {
            throw new NotImplementedException();
        }

        public Cars GetModel()
        {
            throw new NotImplementedException();
        }

        public Cars GetModel(string sql)
        {
            throw new NotImplementedException();
        }

        DataSet IParkingRepository<Cars>.GetDataSet(string sql)
        {
            throw new NotImplementedException();
        }
    }

}



