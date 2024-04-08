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

        public DataSet listadoAsistencias(string cual)
        {
            return objDatosAsis.listadoAasistencias(cual);
        }
    }
}
