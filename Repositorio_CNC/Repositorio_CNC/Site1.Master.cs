using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio_CNC.Controles;

namespace Repositorio_CNC
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        string Login = "~/Login.aspx";
        string Default = "~/Default.aspx";
        string Programas_Lista = "~/Programas/Programas_Lista.aspx";
        string Maquinas_Lista = "~/Maquinas/Maquinas_Lista.aspx";
        string TiposDeMaquina_Lista = "~/TiposDeMaquina/TiposDeMaquina_Lista.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
            VerificarLogin();
            LabelUsuario.Text = Controles.Controles.Usuario;
        }

        public void VerificarLogin() 
        {
            try
            {
                string usuario = Controles.Controles.Usuario;
                string senha = Controles.Controles.Senha;

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
                {
                    Response.Redirect(Login);
                }
            }
            catch (Exception)
            {
                Response.Redirect(Login);
            }
        }

        protected void LinkBtnProgramas_Click(object sender, EventArgs e)
        {
            Response.Redirect(Programas_Lista);
        }

        protected void LinkBtnMaquinas_Click(object sender, EventArgs e)
        {
            Response.Redirect(Maquinas_Lista);
        }

        protected void LinkBtnTiposDeMaquina_Click(object sender, EventArgs e)
        {
            Response.Redirect(TiposDeMaquina_Lista);
        }

        protected void LinkBtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect(Default);
        }

        protected void LinkBtnSair_Click(object sender, EventArgs e)
        {
            Controles.Controles.Usuario = null;
            Controles.Controles.Senha = null;

            Response.Redirect(Login);
        }
    }
}