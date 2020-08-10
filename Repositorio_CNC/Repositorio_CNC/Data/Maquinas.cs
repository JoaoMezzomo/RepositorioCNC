using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Repositorio_CNC.Data
{
    public class Maquinas
    {
        struct Maquina
        {
            public int ID;
            public string NOME;
            public int NUMERO;
            public string DESCRICAO;
            public int IDTIPOMAQUINA;
        }

        public DataSet ListarMaquinasComProgramas()
        {
            string query = "SELECT ID, NOME FROM MAQUINAS WHERE ID IN (SELECT IDMAQUINA FROM MAQUINAS_X_PROGRAMAS) ORDER BY NOME";

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            return data;
        }

        public DataSet ListarTodasMaquinas()
        {
            string query = "SELECT ID, NOME, NUMERO FROM MAQUINAS ORDER BY NOME";

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            return data;
        }

        public DataSet ListarMaquinasComFiltro(string where = "")
        {
            string query = @"SELECT ID, NOME, NUMERO FROM MAQUINAS" + where + " ORDER BY NOME";

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            return data;
        }
    }
}