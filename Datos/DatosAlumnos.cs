using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

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
                orden = $"insert into Alumnos (Documento, Apellido, Nombre) values ({objAlumno.Documento}, '{objAlumno.Apellido}', '{objAlumno.Nombre}');";
            }

            if (accion == "Modificar")
            {
                orden = $"update Alumnos set Apellido='{objAlumno.Apellido}', Nombre='{objAlumno.Nombre}' WHERE Documento like '%{objAlumno.Documento}%';";
            }

            if (accion == "Borrar")
            {
                orden = $"delete from Alumnos WHERE Documento = '{objAlumno.Documento}';";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);

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
    }
}
