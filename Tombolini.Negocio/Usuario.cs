using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tombolini.Entidades;
using Tombolini.Datos;

namespace Tombolini.Negocio
{
    public class Usuario
    {
        private Tombolini.Datos.Usuario _usuData;
        public Tombolini.Datos.Usuario usuData { get=>_usuData; set=>_usuData=value; }

        public Usuario() { }

        public Usuario(Tombolini.Datos.Usuario x)
        {
            this.usuData = x;
        }

        public List<Entidades.Usuario> RecuperarTodos() {
            this.usuData = new Tombolini.Datos.Usuario();
            return this.usuData.RecuperarTodos();
        }

        public  Entidades.Usuario RecuperarUno(String nombre) {
            Entidades.Usuario usu = new Entidades.Usuario();
            try
            {
                this.usuData = new Tombolini.Datos.Usuario();
                usu= this.usuData.RecuperarUno(nombre);
            }
            catch(Exception Ex) {
                Exception ExcepcionManejada = new Exception("No existe el usuario en cuestión", Ex);
            }
            return usu;
        }

        public void Agregar(Entidades.Usuario usu) {
            this.usuData = new Tombolini.Datos.Usuario();
            this.usuData.Agregar(usu);
        }
    }
}
