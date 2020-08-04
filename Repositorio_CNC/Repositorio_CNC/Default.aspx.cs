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

namespace Repositorio_CNC
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarGrid();
                CarregarMaquinas();
                CarregarProjetos();
            }
        }

        #region Métodos

        private void Download() 
        {
            FileInfo file = new FileInfo("");

            Response.Clear();
            Response.ClearHeaders();
            Response.ClearContent();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "text/plain";
            Response.Flush();
            Response.TransmitFile(file.FullName);
            Response.End();
        }

        private void Filtrar() 
        {
            if (!string.IsNullOrEmpty(txtNome.Text) || ddlMaquinas.SelectedIndex > 0 || ddlProjetos.SelectedIndex > 0)
            {
                string where = " WHERE";
                bool colocarAnd = false;

                if (!string.IsNullOrEmpty(txtNome.Text))
                {
                    where += " PROG.NOME LIKE '%" + txtNome.Text + "%'";
                    colocarAnd = true;
                }

                if (ddlMaquinas.SelectedIndex > 0)
                {
                    if (colocarAnd)
                    {
                        where += " AND";
                    }

                    where += " MXP.IDMAQUINA = " + ddlMaquinas.SelectedValue;
                    colocarAnd = true;
                }

                if (ddlProjetos.SelectedIndex > 0)
                {
                    if (colocarAnd)
                    {
                        where += " AND";
                    }
                    where += " PROG.PROJETO = '" + ddlProjetos.SelectedValue + "'";
                }

                Data.Programas programas = new Data.Programas();
                GridProgramas.DataSource = programas.ListarProgramasComFiltro(where);
                GridProgramas.DataBind();
            }
            else
            {
                CarregarGrid();
            }
        }

        private void CarregarProjetos()
        {
            Data.Programas programas = new Data.Programas();
            DataSet dt = programas.ListarProjetos();

            ddlProjetos.Items.Clear();
            ddlProjetos.Items.Add(new ListItem());

            foreach (DataRow row in dt.Tables[0].Rows)
            {
                ListItem item = new ListItem();
                item.Value = row["PROJETO"].ToString();
                item.Text = row["PROJETO"].ToString();
                ddlProjetos.Items.Add(item);
            }

        }

        private void CarregarMaquinas() 
        {
            Data.Maquinas maquinas = new Data.Maquinas();
            DataSet dt = maquinas.ListarMaquinasComProgramas();

            ddlMaquinas.Items.Clear();
            ddlMaquinas.Items.Add(new ListItem());

            foreach (DataRow row in dt.Tables[0].Rows)
            {
                ListItem item = new ListItem();
                item.Value = row["ID"].ToString();
                item.Text = row["NOME"].ToString();
                ddlMaquinas.Items.Add(item);
            }

        }

        private void CarregarGrid() 
        {
            Data.Programas programas = new Data.Programas();
            GridProgramas.DataSource = programas.ListarTodosProgramas();
            GridProgramas.DataBind();
        }
        #endregion

        #region GridProgramas
        protected void GridProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GridProgramas.SelectedIndex;

            foreach (GridViewRow row in GridProgramas.Rows)
            {
                if (row.RowIndex == index)
                {
                    row.BackColor = Color.SeaGreen;
                }
                else
                {
                    row.BackColor = Color.Transparent;
                }
            }
        }

        protected void GridProgramas_RowCreated(object sender, GridViewRowEventArgs e)
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

        protected void GridProgramas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridProgramas.PageIndex = e.NewPageIndex;
            CarregarGrid();
        }
        #endregion

        protected void LinkBtnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        protected void LinkBtnDownloadUnico_Click(object sender, EventArgs e)
        {
            Download();
        }
    }
}