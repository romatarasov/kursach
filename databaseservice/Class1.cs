using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseservice
{
    public class Class1
    {
    }
    public class DataBase
    {
        SqlConnection connection;
        public DataBase ()
        {
            this.connection = new SqlConnection(Parking.Default.Connection);


        }
      /// <summary>
      /// Получение модели из базы данных
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="sql"></param>
      /// <returns></returns>
        public T GetModel<T>(string sql) where T:class,new ()
        {
            T Model = new T();
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                //записываем
                for (int i=0;i<Model.GetType().GetProperties().Length;i++)
                {
                    Model.GetType().GetProperties()[i].SetValue(Model, sqlDataReader.GetValue(i));
                    
                }
                sqlDataReader.Close();
                return Model;
            }
            return default(T);
        }

        public List<T> GetModelList<T>(string sql) where T : class, new()
        {
            
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            List<T> ModelList = new List<T>();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    T Model = new T();
                    //записываем
                    for (int i = 0; i < Model.GetType().GetProperties().Length; i++)
                    {
                        Model.GetType().GetProperties()[i].SetValue(Model, sqlDataReader.GetValue(i));

                    }
                    ModelList.Add(Model);
                }
               
               
                sqlDataReader.Close();
                return ModelList;
            }
            return null;

        }
        public DataSet GetDataSet(string sql)
        {
            var adapter = new SqlDataAdapter(sql, connection);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            return dataset;
        }
        /// <summary>
        /// вставка удаление сохранение
        /// </summary>
        /// <param name="sql"></param>
        public void ExecuteQuary (string sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql,connection);
            sqlCommand.ExecuteNonQuery();

        }

}
