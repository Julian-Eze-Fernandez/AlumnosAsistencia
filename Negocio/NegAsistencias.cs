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
        public int modificarAsistencias(string accion, Asistencia objAsistencia, DateTime nuevaFecha)
        {
            return objDatosAsis.modificarAsistencias(accion, objAsistencia, nuevaFecha);
        }
        public DataSet listadoAsistencias(string documentoAlu, DateTime fecha)
        {
            return objDatosAsis.listadoAsistencias(documentoAlu, fecha);
        }
        public bool ExisteDniAlumno(string documentoAlu)
        {
            return objDatosAsis.ExisteDniAlumno(documentoAlu);
        }
        public bool ExisteAsistencia(string asistenciaAlu)
        {
            return objDatosAsis.ExisteAsistencia(asistenciaAlu);
        }
        public bool ExisteAsistenciaFecha(int asistenciaAlu, DateTime fecha)
        {
            return objDatosAsis.ExisteAsistenciaFecha(asistenciaAlu, fecha);
        }
    }
}
