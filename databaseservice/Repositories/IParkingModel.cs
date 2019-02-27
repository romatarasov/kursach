using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseservice.Repositories
{
    public interface IParkingRepository<T>

    {
        T GetModel();
        List<T> GetList();
        T GetModel(string sql);
        List<T> GetList(string sql);
         DataSet GetDataSet(string sql);
        void Insert(T Model);
        void Edit(T Model);
        void Remove(T Model);
        
        



    }
    

}



