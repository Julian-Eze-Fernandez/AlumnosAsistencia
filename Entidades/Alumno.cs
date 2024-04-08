using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region Atributos
        private int documento;
        private string apellido;
        private string nombre;

        #endregion

        #region Constructor
        public Alumno()
        {

        }

        public Alumno(int dni, string ape, string nom)
        {
            documento = dni;
            apellido = ape;
            nombre = nom;
        }
        #endregion

        #region Propiedades
        public int Documento { get { return documento; } set { documento = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        #endregion
    }
}
