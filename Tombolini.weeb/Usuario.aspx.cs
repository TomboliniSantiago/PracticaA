using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tombolini.weeb
{
    public partial class Usuario : System.Web.UI.Page
    {
        public Entidades.Usuario Entity { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            
            Negocio.Usuario usu = new Negocio.Usuario();
            this.Entity = usu.RecuperarUno(txtNomUsu.Text);
            lblNomUsu.Text = this.Entity.NombreUsuario;
            lblEmail.Text = this.Entity.Email;
            lblClave.Text = this.Entity.Clave;
            this.lblTipoUsu.Text = (this.Entity.TipoUsuario).ToString();
            this.lblUltIng.Text = (this.Entity.UltimoIngreso).ToString();
            this.Panel2.Visible = true;
            

        }
    }
}