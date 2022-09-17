using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolineas
{
    public class Administrador
    {
        string usuario;
        string contrasenia;
        string nombreCompleto;

        public Administrador(string usuario, string contrasenia, string nombreCompleto)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.nombreCompleto = nombreCompleto;
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }
        }

        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }
        }
        public string NombreCompleto
        {
            get
            {
                return nombreCompleto;
            }
        }
    }
}
