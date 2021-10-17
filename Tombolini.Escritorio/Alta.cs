using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tombolini.Escritorio
{
    public partial class Alta : Form
    {
        private Tombolini.Entidades.Usuario _usuActual;
        private Tombolini.Negocio.Validaciones _val;
        public Entidades.Usuario usuActual { get=> _usuActual; set=>_usuActual=value; }
        public Tombolini.Negocio.Validaciones val { get=>_val; set=> _val=value; }
        public Alta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Validar(String em) {
            bool resp = false;
            String rta;
            this.val = new Negocio.Validaciones();
            if (!("".Equals(txtNombre.Text))) {
                if (!("".Equals(txtClave.Text)))
                {
                    if (!("".Equals(txtEmail.Text)) & (val.EsMailValido(em)))
                    {
                        if (!("".Equals(txtTipoPer.Text)))
                        {
                            resp = true;
                        }
                        else { rta = "El tipo de usuario no puede ser vacio"; this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                    }
                    else { rta = "El mail no es valido"; this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                }
                else
                {rta = "La clave no puede ser vacia"; this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);}
            
            }
            else { rta = "El nombre no puede ser vacío"; this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            return resp;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Entidades.Usuario usr = new Entidades.Usuario();
            usuActual = usr;
            usuActual.NombreUsuario = this.txtNombre.Text;
            usuActual.Clave = this.txtClave.Text;
            usuActual.Email = this.txtEmail.Text;
            usuActual.TipoUsuario = int.Parse(this.txtTipoPer.Text);

            if (this.Validar(usuActual.Email)){

                Tombolini.Negocio.Usuario usua = new Negocio.Usuario();
                usua.Agregar(this.usuActual);
                this.Notificar("Todo ok", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               
            }
            this.Close();
        }

        public void Notificar(String titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
    }
}
