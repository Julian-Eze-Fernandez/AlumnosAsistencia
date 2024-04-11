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
            #region abmVieja
            //int resultado = -1;
            //string orden = string.Empty;

            //if (accion == "Alta")
            //{
            //    orden = $"insert into Asistencias (docAlumno, Fecha, Presente) values ('{objAsistencia.DocAlumno}', '{objAsistencia.Fecha}', '{objAsistencia.Presente}');";
            //}

            //if (accion == "Modificar")
            //{
            //    orden = $"update Asistencias set Fecha='{objAsistencia.Fecha}', Presente='{objAsistencia.Presente}' WHERE docAlumno like '%{objAsistencia.DocAlumno}%' AND Fecha = '{objAsistencia.Fecha}';";
            //}

            //if (accion == "Borrar")
            //{
            //    orden = $"delete from Asistencias WHERE docAlumno = '{objAsistencia.DocAlumno}' AND Fecha = '{objAsistencia.Fecha}';";
            //}

            //SqlCommand cmd = new SqlCommand(orden, conexion);

            //try
            //{
            //    AbrirConexion();
            //    resultado = cmd.ExecuteNonQuery();
            //}
            //catch (Exception e)
            //{
            //    throw new Exception("Error al tratar de guardar, borrar o modificar las asistencias de los alumnos", e);
            //}
            //finally
            //{
            //    CerrarConexion();
            //    cmd.Dispose();
            //}

            //return resultado;
            #endregion

            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO Asistencias (idAsistencia, docAlumno, Fecha, Presente) VALUES (@idAsistencia, @DocAlumno, @Fecha, @Presente)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Asistencias SET Fecha = @Fecha, Presente = @Presente WHERE idAsistencia = @idAsistencia AND docAlumno = @DocAlumno";
            }
            else if (accion == "Borrar")
            {
                orden = "DELETE FROM Asistencias WHERE idAsistencia = @idAsistencia AND docAlumno = @DocAlumno";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@idAsistencia", objAsistencia.IdAsistencia);
            cmd.Parameters.AddWithValue("@DocAlumno", objAsistencia.DocAlumno);
            cmd.Parameters.AddWithValue("@Fecha", objAsistencia.Fecha);
            cmd.Parameters.AddWithValue("@Presente", objAsistencia.Presente);

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

        public DataSet listadoAsistencias(string documentoAlu, DateTime fecha)
        {
            string orden = string.Empty;
            if (documentoAlu != "Todos")
                orden = "select * from Asistencias where docAlumno = " + int.Parse(documentoAlu) + " and Fecha = @fecha;";
            else
                orden = "select * from Asistencias;";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@fecha", fecha);

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

        public bool ExisteDniAlumno(string documentoAlu)
        {
            string consulta = "SELECT COUNT(*) FROM alumnos WHERE documento = @documentoAlu";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@documentoAlu", documentoAlu);

            try
            {
                AbrirConexion();
                int count = (int)cmd.ExecuteScalar(); // Obtenemos el resultado del conteo de filas
                return count > 0; // Devolvemos true si el código de socio existe en la tabla
            }
            catch (Exception e)
            {
                throw new Exception("Error al verificar la existencia del DNI del Alumno.", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }
    }
}
