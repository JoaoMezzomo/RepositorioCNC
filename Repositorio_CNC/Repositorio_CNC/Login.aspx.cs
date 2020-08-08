using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio_CNC.Controles;
using Repositorio_CNC.Data;

namespace Repositorio_CNC
{
    public partial class Login : System.Web.UI.Page
    {
        string Default = "~/Default.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                VerificarLogin();
            }
        }

        public void VerificarLogin()
        {
            try
            {
                string usuario = Controles.Controles.Usuario;
                string senha = Controles.Controles.Senha;

                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha))
                {
                    Response.Redirect(Default);
                }
            }
            catch (Exception)
            {
                Response.Redirect(Default);
            }
        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha))
            {
                if (Data.Login.VerificarLogin(usuario, senha))
                {
                    Controles.Controles.Usuario = usuario;
                    Controles.Controles.Senha = senha;
                    LabelErro.Visible = false;
                    Response.Redirect(Default);
                }
                else
                {
                    LabelErro.Visible = true;
                    Controles.Controles.Usuario = null;
                    Controles.Controles.Senha = null;
                }
            }
        }
    }
}