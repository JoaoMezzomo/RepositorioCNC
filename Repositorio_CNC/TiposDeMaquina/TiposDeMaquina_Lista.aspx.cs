using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Repositorio_CNC.TiposDeMaquina
{
    public partial class TiposDeMaquina_Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarGrid();
            }
        }


        #region Métodos

        private void RedirecionarParaEdita(int IDTipoMaquina)
        {
            Controles.Controles.IDTipoMaquina = IDTipoMaquina;
            Response.Redirect("~/TiposDeMaquina/TiposDeMaquina_Edita.aspx");
        }

        private void Filtrar()
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                string where = " WHERE";
                
                where += " NOME LIKE '%" + txtNome.Text + "%'";

                Data.Tipo_Maquina tipos = new Data.Tipo_Maquina();

                GridTipos.DataSource = tipos.ListarTiposComFiltro(where);
                GridTipos.DataBind();
            }
            else
            {
                CarregarGrid();
            }
        }

        private void CarregarGrid()
        {
            Data.Tipo_Maquina tipos = new Data.Tipo_Maquina();

            GridTipos.DataSource = tipos.ListarTodosTipos();
            GridTipos.DataBind();
        }
        #endregion

        #region GridTipos
        protected void GridTipos_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[1].Visible = false;
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Visible = false;
            }
        }

        protected void GridTipos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridTipos.PageIndex = e.NewPageIndex;
            CarregarGrid();
        }

        protected void GridTipos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            RedirecionarParaEdita(Convert.ToInt32(GridTipos.Rows[e.NewEditIndex].Cells[1].Text));
        }
        #endregion

        protected void LinkBtnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        protected void LinkBtnNovo_Click(object sender, EventArgs e)
        {
            RedirecionarParaEdita(0);
        }
    }
}