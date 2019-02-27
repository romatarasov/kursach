using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class CarsModelRepository : IParkingRepository<CarsModel>
    {
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
            throw new NotImplementedException();
        }

        public CarsModel GetModel()
        {
            throw new NotImplementedException();
        }

        public CarsModel GetModel(string sql)
        {
            throw new NotImplementedException();
        }
    }

}



