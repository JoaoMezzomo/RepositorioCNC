using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.IO;

namespace Repositorio_CNC.Data
{
    public class PastaBase
    {
        public static string BuscarPastaBase()
        {
            string path = "C:\\RepositorioCNC";

            //path = WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString.ToString();

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }
    }
}