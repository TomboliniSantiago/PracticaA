using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Tombolini.Negocio
{
    public class Validaciones
    {
        public  bool EsMailValido(String email){
            bool rta = false;
            Regex rx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match m = rx.Match(email);
            if (m.Success) {
                rta = true;
            
            }
            return rta;
        }
    }
}
