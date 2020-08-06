using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Repositorio_CNC.Data
{
    public struct Programa
    {
        public int ID;
        public string NOME;
        public string TEXTO;
        public string ARQUIVO;
        public string PROJETO;
    }

    public class Programas
    {
        public DataSet ListarProjetos() 
        {
            string query = "SELECT DISTINCT(PROJETO) FROM PROGRAMAS ORDER BY PROJETO";

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            return data;
        }

        public DataSet ListarProgramasComFiltro(string where = "")
        {
            string query = @"SELECT PROG.ID, PROG.NOME, PROG.PROJETO FROM PROGRAMAS PROG
                             LEFT JOIN MAQUINAS_X_PROGRAMAS MXP ON MXP.IDPROGRAMA = PROG.ID" + where;

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            return data;
        }

        public DataSet ListarTodosProgramas() 
        {
            string query = "SELECT ID, NOME, PROJETO FROM PROGRAMAS";

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            return data;
        }

        public Programa CarregarPrograma(int id) 
        {
            Programa programa = new Programa();

            string query = "SELECT * FROM PROGRAMAS WHERE ID = " + id;

            Data database = new Data();
            DataSet data = database.ExecutarSelectDataBase(query);

            if (data.Tables.Count > 0)
            {
                if (data.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in data.Tables[0].Rows)
                    { 
                        programa.ID = Convert.ToInt32(row["ID"]);
                        programa.NOME = row["NOME"].ToString();
                        programa.TEXTO = row["TEXTO"].ToString();
                        programa.PROJETO = row["PROJETO"].ToString();
                    }
                }
            }

            return programa;
        }
    }
}