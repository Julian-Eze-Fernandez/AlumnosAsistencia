using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegAsistencias
    {
        DatosAsistencias objDatosAsis = new DatosAsistencias();

        public int abmAsistencias(string accion, Asistencia objAsistencia)
        {
            return objDatosAsis.abmAsistencias(accion, objAsistencia);
        }


        public DataSet listadoAsistencias(string documentoAlu, DateTime fecha)
        {
            return objDatosAsis.listadoAsistencias(documentoAlu, fecha);
        }

        public bool ExisteDniAlumno(string documentoAlu)
        {
            return objDatosAsis.ExisteDniAlumno(documentoAlu);
        }
    }
}
