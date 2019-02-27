using parkingmodels;
using System;
using System.Collections.Generic;
using System.Data;

namespace databaseservice.Repositories
{
    public class PaymentRepository : IParkingRepository<Payment>
    {
        public DataSet GetDataSet(string sql)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetList(string sql)
        {
            throw new NotImplementedException();
        }

        public Payment GetModel()
        {
            throw new NotImplementedException();
        }

        public Payment GetModel(string sql)
        {
            throw new NotImplementedException();
        }
    }

}



