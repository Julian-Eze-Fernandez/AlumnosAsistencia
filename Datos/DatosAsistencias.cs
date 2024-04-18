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
                orden = "INSERT INTO Asistencias (docAlumno, Fecha, Presente) VALUES (@DocAlumno, @Fecha, @Presente)";
            }
            //else if (accion == "Modificar")
            //{
            //    // Consulta SQL para modificar la fecha y el estado de asistencia basándose en el ID de la asistencia
            //    orden = "UPDATE Asistencias SET Fecha = @NuevaFecha, Presente = @Presente WHERE IdAsistencia = (SELECT IdAsistencia FROM Asistencias WHERE docAlumno = @DocAlumno and Fecha = @Fecha)";
            //}
            else if (accion == "Borrar")
            {
                orden = "DELETE FROM Asistencias WHERE  docAlumno = @DocAlumno AND Fecha = @Fecha";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            //cmd.Parameters.AddWithValue("@NuevaFecha", nuevaFecha);
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
        public int modificarAsistencias(string accion, Asistencia objAsistencia, DateTime nuevaFecha)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Modificar")
            {
                // Consulta SQL para modificar la fecha y el estado de asistencia basándose en el ID de la asistencia
                orden = "UPDATE Asistencias SET Fecha = @NuevaFecha, Presente = @Presente WHERE docAlumno = @DocAlumno AND Fecha = @Fecha";
            }


            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@NuevaFecha", nuevaFecha);
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
        public bool ExisteAsistencia(string asistenciaAlu)
        {
            string consulta = "SELECT COUNT(*) FROM asistencias WHERE DocAlumno = @DocAlumno";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@DocAlumno", asistenciaAlu);

            try
            {
                AbrirConexion();
                int count = (int)cmd.ExecuteScalar(); // Obtenemos el resultado del conteo de filas
                return count > 0; // Devolvemos true si el código de socio existe en la tabla
            }
            catch (Exception e)
            {
                throw new Exception("Error al verificar la existencia del la asistencia del Alumno.", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }
        public bool ExisteAsistenciaFecha(int documentoAlu, DateTime fecha)
        {
            string consulta = "SELECT COUNT(*) FROM Asistencias WHERE DocAlumno = @DocAlumno AND Fecha = @Fecha";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@DocAlumno", documentoAlu);
            cmd.Parameters.AddWithValue("@Fecha", fecha);

            try
            {
                AbrirConexion();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Devuelve true si ya existe una asistencia para el alumno en la fecha especificada
            }
            catch (Exception e)
            {
                throw new Exception("Error al verificar la existencia de la asistencia del alumno.", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }

    }
}
