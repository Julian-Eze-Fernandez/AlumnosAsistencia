using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Threading;

namespace Datos
{
    public class DatosAlumnos : DatosConexion
    {
        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO Alumnos (Documento, Apellido, Nombre, Activo) VALUES (@Documento, @Apellido, @Nombre, @Activo);";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Alumnos SET Apellido = @Apellido, Nombre = @Nombre WHERE Documento = @Documento;";
            }
            else if (accion == "Borrar")
            {
                orden = "DELETE FROM Alumnos WHERE Documento = @Documento;";
            }
            else if (accion == "Baja")
            {
                orden = "UPDATE Alumnos SET Activo = 'N' WHERE Documento = @Documento;";
            }
            else if (accion == "Activar")
            {
                orden = "UPDATE Alumnos SET Activo = 'S' WHERE Documento = @Documento;";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Documento", objAlumno.Documento);
            cmd.Parameters.AddWithValue("@Apellido", objAlumno.Apellido);
            cmd.Parameters.AddWithValue("@Nombre", objAlumno.Nombre);
            cmd.Parameters.AddWithValue("@Activo", objAlumno.Activo);


            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar Alumnos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return resultado;
        }
        public DataSet listadoAlumnos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Alumnos where Documento = " + int.Parse(cual) + ";";
            else
                orden = "select * from Alumnos;";

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
                throw new Exception("Error al listar alumnos", e);
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
        public List<int> ObtenerAlumnos()
        {
            List<int> lista = new List<int>();
            string orden = "SELECT documento FROM Alumnos";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            SqlDataReader dr;

            try
            {
                AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int documento = dr.GetInt32(0); // Obtener el documento como un entero
                    lista.Add(documento);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Documentos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return lista;
        }


    }
}
