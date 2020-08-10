using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio_CNC.Data;
using System.Data;
using System.IO;
using System.IO.Compression;
using Repositorio_CNC.Controles;

namespace Repositorio_CNC.Maquinas
{
    public partial class Maquinas_Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarGrid();
                CarregarTipo();
            }
        }


        #region Métodos

        private void RedirecionarParaEdita(int IDMaquina)
        {
            Controles.Controles.IDMaquina = IDMaquina;
            Response.Redirect("~/Maquinas/Maquinas_Edita.aspx");
        }

        private void Filtrar()
        {
            if (!string.IsNullOrEmpty(txtNome.Text) || !string.IsNullOrEmpty(txtNumero.Text) || ddlTipo.SelectedIndex > 0)
            {
                string where = " WHERE";
                bool colocarAnd = false;

                if (!string.IsNullOrEmpty(txtNome.Text))
                {
                    where += " NOME LIKE '%" + txtNome.Text + "%'";
                    colocarAnd = true;
                }

                if (!string.IsNullOrEmpty(txtNumero.Text))
                {
                    if (colocarAnd)
                    {
                        where += " AND";
                    }
                    where += " NUMERO LIKE '%" + txtNumero.Text + "%'";
                    colocarAnd = true;
                }


                if (ddlTipo.SelectedIndex > 0)
                {
                    if (colocarAnd)
                    {
                        where += " AND";
                    }
                    where += " IDTIPOMAQUINA = '" + ddlTipo.SelectedValue + "'";
                }

                Data.Maquinas maquinas = new Data.Maquinas();
                GridMaquinas.DataSource = maquinas.ListarMaquinasComFiltro(where);
                GridMaquinas.DataBind();
            }
            else
            {
                CarregarGrid();
            }
        }

        private void CarregarTipo()
        {
            Data.Tipo_Maquina tipos = new Tipo_Maquina();

            DataSet dt = tipos.ListarTiposComMaquinas();

            ddlTipo.Items.Clear();
            ddlTipo.Items.Add(new ListItem().Text = "Tipo");

            foreach (DataRow row in dt.Tables[0].Rows)
            {
                ListItem item = new ListItem();
                item.Value = row["ID"].ToString();
                item.Text = row["NOME"].ToString();
                ddlTipo.Items.Add(item);
            }

        }

        private void CarregarGrid()
        {
            Data.Maquinas maquinas = new Data.Maquinas();

            GridMaquinas.DataSource = maquinas.ListarTodasMaquinas();
            GridMaquinas.DataBind();
        }
        #endregion

        #region GridMaquinas
        protected void GridMaquinas_RowCreated(object sender, GridViewRowEventArgs e)
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

        protected void GridMaquinas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridMaquinas.PageIndex = e.NewPageIndex;
            CarregarGrid();
        }

        protected void GridMaquinas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            RedirecionarParaEdita(Convert.ToInt32(GridMaquinas.Rows[e.NewEditIndex].Cells[1].Text));
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