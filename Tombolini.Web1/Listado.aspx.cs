using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tombolini.Web1
{
    public partial class Listado : System.Web.UI.Page
    {
        Tombolini.Negocio.Usuario _logic;
        public Tombolini.Negocio.Usuario Logic { get=>_logic; set=>_logic=value; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void LoadGrid() {
            this.gridView.DataSource = this.Logic.RecuperarTodos();
            this.gridView.DataBind();
        }
    }
}