using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombolini.Entidades
{
    public class Usuario
    {
        private String _clave;
        private String _email;
        private String _nombreUsuario;
        private int _tipoUsuario;
        private DateTime _ultimoIngreso;
        private int _diasUltIng;

        public String Clave { get=>_clave; set=> _clave=value; }
        public String Email { get=>_email; set =>_email=value; }
        public String NombreUsuario { get =>_nombreUsuario; set =>_nombreUsuario=value; }
        public int TipoUsuario { get =>_tipoUsuario; set =>_tipoUsuario=value; }
        public DateTime UltimoIngreso { get =>_ultimoIngreso; set =>_ultimoIngreso=value; }

        protected int DiasUltimoIngreso { get=> (DateTime.Now - this.UltimoIngreso).Days; }

        public Usuario()
        {

        }

        public Usuario(String clave, String email, String nomUsu, int tipoUsu, DateTime ultIng)
        {
            this.Clave = clave;
            this.Email = email;
            this.NombreUsuario = nomUsu;
            this.TipoUsuario = tipoUsu;
            this.UltimoIngreso = ultIng;
        }
    }
}
