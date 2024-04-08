using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace AsistenciaAlumnos
{
    public partial class FormAdmAsisAlu : Form
    {
        public Alumno objEntAlu = new Alumno();
        public NegAlumnos objNegAlu = new NegAlumnos();


        public FormAdmAsisAlu()
        {
            InitializeComponent();
            CrearDGVs();
            LlenarDGVs();
        }

        private void CrearDGVs()
        {
            #region DgvAlumnos
            //Creacion DGV Alumnos
            dgv_Alumnos.ColumnCount = 3;
            dgv_Alumnos.Columns[0].HeaderText = "DNI";
            dgv_Alumnos.Columns[1].HeaderText = "Apellido";
            dgv_Alumnos.Columns[2].HeaderText = "Nombre";

            dgv_Alumnos.Columns[0].Width = 100;
            dgv_Alumnos.Columns[1].Width = 100;
            dgv_Alumnos.Columns[2].Width = 100;
            #endregion

            #region DgvAsistencias
            //Creacion DGV Asistencias
            dgv_Asistencias.ColumnCount = 3;
            dgv_Asistencias.Columns[0].HeaderText = "DNI";
            dgv_Asistencias.Columns[1].HeaderText = "Fecha";
            dgv_Asistencias.Columns[2].HeaderText = "Asistencia";

            dgv_Asistencias.Columns[0].Width = 100;
            dgv_Asistencias.Columns[1].Width = 100;
            dgv_Asistencias.Columns[2].Width = 100;
            #endregion
        }

        private void LlenarDGVs()
        {
            #region DgvAlumnos
            //limpiamos el DataGridView
            dgv_Alumnos.Rows.Clear();

            //Invocamos al listado para que devuelva los elementos si existen
            DataSet ds = new DataSet();
            ds = objNegAlu.listadoAlumnos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_Alumnos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
            }
            else
            {
                lbl_Mensaje.Text = "No hay Alumnos cargados en el sistema.";
            }
            #endregion
        }

        private void TxtBox_a_objAlu()
        {
            //Tomamos los datos del form y se lo damos a los atributos
            objEntAlu.Documento = int.Parse(txt_Documento.Text);
            objEntAlu.Apellido = txt_Apellido.Text;
            objEntAlu.Nombre = txt_Nombre.Text;
        }

        private void btn_CargarAlu_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            //llamamos al método que carga los datos del objeto
            TxtBox_a_objAlu();

            nGrabados = objNegAlu.abmAlumnos("Alta", objEntAlu);

            if (nGrabados == -1)
            {
                lbl_Mensaje.Text = "No se pudo cargar Alumnos en el sistema.";
            }
            else
            {
                lbl_Mensaje.Text = "Se cargo el Alumno con éxito.";
                LlenarDGVs();
                LimpiarDGVs();
            }
        }
        private void LimpiarDGVs()
        {
            txt_Documento.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            txt_Nombre.Text = string.Empty;

            maskedTextBox_DocAluAsistencia.Text = string.Empty;
            maskedTextBox_Fecha.Text = string.Empty;
            radioButton_No.Checked = false;
            radioButton_Si.Checked = false;
        }
    }
}