using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Repositorio_CNC.Data
{
    public class Login
    {
        public static bool VerificarLogin(string usuario, string senha) 
        {
            string query = string.Format("SELECT * FROM LOGIN WHERE USUARIO = '{0}' AND SENHA = '{1}'", usuario, senha);

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            if (data.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}