using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class Alumno : Persona
    {
        private string codigo;
        private string telefono;

        public string Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string DevolverDatosAlumno()
        {
            return "Codigo: " + this.Codigo + " Apellidos: " + this.Apellidos + " Nombres: " + this.Nombres + " Edad: " + Convert.ToString(this.Edad) + " Telefono; " + this.Telefono;
        }
    }
}