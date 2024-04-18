using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosConexion
    {
        public SqlConnection conexion;
        //BD Casa
        protected string cadenaConexion = "Data Source=DESKTOP-M5DJ7QL\\SQLEXPRESS;Initial Catalog=AsistenciaAlumnos;Integrated Security=True";
        //BD Facu
        //protected string cadenaConexion = "Data Source=EQUIPO\\SQLEXPRESS;Initial Catalog=AsistenciaAlumnos;Integrated Security=True";

        public DatosConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cerrar la conexion", e);
            }
        }
    }
}
