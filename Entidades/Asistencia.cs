using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        #region Atributos
        private long docAlumno;
        private DateTime fecha;
        private bool presente;
        #endregion

        #region Constructores
        public Asistencia()
        {
                
        }

        public Asistencia(long dniAlu, DateTime fech)
        {
            docAlumno = dniAlu;
            fecha = fech;
        }

        public Asistencia(long dniAlu, DateTime fech, bool pres)
        {
            docAlumno = dniAlu;
            fecha = fech;
            presente = pres;
        }
        #endregion

        #region Propiedades
        public long DocAlumno { get { return docAlumno; } set { docAlumno = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public bool Presente { get { return presente; } set { presente = value; } }
        #endregion
    }
}
