using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Repositorio_CNC.Data
{
    public class Tipo_Maquina
    {
        public DataSet ListarTiposComMaquinas()
        {
            string query = "SELECT ID, NOME FROM TIPO_MAQUINA WHERE ID IN (SELECT IDTIPOMAQUINA FROM MAQUINAS)";

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            return data;
        }

        public DataSet ListarTodosTipos()
        {
            string query = "SELECT ID, NOME FROM TIPO_MAQUINA ORDER BY NOME";

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            return data;
        }

        public DataSet ListarTiposComFiltro(string where = "")
        {
            string query = @"SELECT ID, NOME FROM TIPO_MAQUINA" + where + " ORDER BY NOME";

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            return data;
        }
    }
}