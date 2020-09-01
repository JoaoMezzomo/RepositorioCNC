using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio_CNC.Controles;

namespace Repositorio_CNC.Programas
{
    public partial class Programas_Edita : System.Web.UI.Page
    {
        private static int IDPROGRAMA;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarIDPrograma();
            }
        }

        private void CarregarIDPrograma() 
        {
            IDPROGRAMA = Controles.Controles.IDPrograma;
        }
    }
}