using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tombolini.Web
{
    public partial class Listado : System.Web.UI.Page
    {
        private Tombolini.Negocio.Usuario _logic;
        public Tombolini.Negocio.Usuario Logic {
            get
            {
                if (_logic == null) { _logic = new Tombolini.Negocio.Usuario(); }
                return _logic;
            }
        }
            
            
        private
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