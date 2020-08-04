using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Repositorio_CNC
{
    public partial class Login : System.Web.UI.Page
    {
        string Default = "~/Default.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha))
            {
                Session["Repositorio_CNC_Usuario"] = usuario;
                Session["Repositorio_CNC_Senha"] = senha;
                Response.Redirect(Default);
            }
        }
    }
}