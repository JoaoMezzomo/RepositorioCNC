using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Repositorio_CNC.Data
{
    public class Data
    {
        protected string BuscarConnectionString()
        {
            return WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString.ToString();
        }

        public DataSet ExecutarSelectDataBase(string query)
        {
            DataSet data = new DataSet();

            try
            {
                string connectionString = BuscarConnectionString();

                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(data);

            }
            catch (Exception ex)
            {
                
            }
            return data;
        }
    }
}