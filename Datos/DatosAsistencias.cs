using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosAsistencias : DatosConexion
    {
        public int abmAsistencias(string accion, Asistencia objAsistencia)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = $"insert into Asistencias (docAlumno, Fecha, Presente) values ({objAsistencia.DocAlumno}, '{objAsistencia.Fecha}', {objAsistencia.Presente});";
            }

            if (accion == "Modificar")
            {
                orden = $"update Asistencias set Fecha='{objAsistencia.Fecha}', Presente={objAsistencia.Presente} WHERE docAlumno like '%{objAsistencia.DocAlumno}%';";
            }

            if (accion == "Borrar")
            {
                orden = $"delete from Asistencias WHERE docAlumno = '{objAsistencia.DocAlumno}';";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar las asistencias de los alumnos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return resultado;
        }

        public DataSet listadoAasistencias(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Asistencias where docAlumno = " + int.Parse(cual) + ";";
            else
                orden = "select * from Asistencias;";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar las asistencias", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return ds;
        }
    }
}
