using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            //if (!TestarLogin())
            //{
            //    Response.Redirect(Login);
            //}
        }

        private bool TestarLogin() 
        {
            bool retorno = true;

            try
            {
                string usuario = Session["Repositorio_CNC_Usuario"].ToString();
                string senha = Session["Repositorio_CNC_Senha"].ToString();

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
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
    }
}