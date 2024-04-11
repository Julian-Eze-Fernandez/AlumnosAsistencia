using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class NegAlumnos
    {
        DatosAlumnos objDatosAlus = new DatosAlumnos();

        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            return objDatosAlus.abmAlumnos(accion, objAlumno);
        }

        public DataSet listadoAlumnos(string cual)
        {
            return objDatosAlus.listadoAlumnos(cual);
        }

        public bool ExisteDniAlumno(string documentoAlu)
        {
            return objDatosAlus.ExisteDniAlumno(documentoAlu);
        }
    }
}
