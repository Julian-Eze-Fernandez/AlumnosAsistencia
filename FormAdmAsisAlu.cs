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
        public Asistencia objEntAsi = new Asistencia();
        public NegAsistencias objNegAsi = new NegAsistencias();


        public FormAdmAsisAlu()
        {
            InitializeComponent();
            CrearDGVs();
            LlenarDGVAlu();
            LlenarDGVAsis();
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
            dgv_Asistencias.ColumnCount = 4;
            dgv_Asistencias.Columns[0].HeaderText = "idAsistencia";
            dgv_Asistencias.Columns[1].HeaderText = "DNI";
            dgv_Asistencias.Columns[2].HeaderText = "Fecha";
            dgv_Asistencias.Columns[3].HeaderText = "Asistencia";

            dgv_Asistencias.Columns[0].Width = 100;
            dgv_Asistencias.Columns[1].Width = 100;
            dgv_Asistencias.Columns[2].Width = 100;
            dgv_Asistencias.Columns[3].Width = 100;
            #endregion
        }
        private void LlenarDGVAlu()
        {
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
        }

        //Alumnos
        private void TxtBox_a_objAlu()
        {
            //Tomamos los datos del form y se lo damos a los atributos
            objEntAlu.Documento = int.Parse(txt_Documento.Text);
            objEntAlu.Apellido = txt_Apellido.Text;
            objEntAlu.Nombre = txt_Nombre.Text;
        }
        private void Ds_a_TxtBoxAlu(DataSet ds)
        {
            txt_Documento.Text = ds.Tables[0].Rows[0]["Documento"].ToString();
            txt_Apellido.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            txt_Nombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txt_Documento.Enabled = false;
        }
        private void dgv_Alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();

            objEntAlu.Documento = Convert.ToInt32(dgv_Alumnos.CurrentRow.Cells[0].Value);

            ds = objNegAlu.listadoAlumnos(objEntAlu.Documento.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBoxAlu(ds);
                btn_CargarAlu.Visible = false;
                lbl_Mensaje.Text = string.Empty;
            }
        }
        private void LimpiarDGVAlu()
        {
            txt_Documento.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            btn_CargarAlu.Visible = true;
        }

        private void btn_CargarAlu_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            string documentoAlu = txt_Documento.Text;

            if (AlumnosCamposNoVacios() && DocumentoAlumnoNoCaracteres())
            {
                if (objNegAlu.ExisteDniAlumno(documentoAlu))
                {
                    MessageBox.Show(this, "Error", "El Alumno ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
                        LlenarDGVAlu();
                        LimpiarDGVAlu();
                    }
                }

            } 
        }
        private void btn_ModificarAlu_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            TxtBox_a_objAlu();
            nResultado = objNegAlu.abmAlumnos("Modificar", objEntAlu);

            if (nResultado != -1)
            {
                MessageBox.Show("El Alumno fue Modificado con exito.", "Aviso");
                LimpiarDGVAlu();
                LlenarDGVAlu();
                txt_Documento.Enabled = true;
            }
            else
            {
                MessageBox.Show("Se produjo un error al intentar modificar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_EliminarAlu_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el alumno con DNI " + int.Parse(txt_Documento.Text) + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Alumno NuevoAlumno = new Alumno(int.Parse(txt_Documento.Text), txt_Apellido.Text, txt_Nombre.Text);

                nGrabados = objNegAlu.abmAlumnos("Borrar", NuevoAlumno);
                LlenarDGVAlu();
                LimpiarDGVAlu();

                txt_Documento.Enabled=true;

            }
        }
        private void btn_LimpiezaAlu_Click(object sender, EventArgs e)
        {
            LimpiarDGVAlu();
            txt_Documento.Enabled = true;
        }


        //Asistencias
        private void LlenarDGVAsis()
        {
            dgv_Asistencias.Rows.Clear();

            DataSet ds = new DataSet();
            string documentoAlu = "Todos"; // Obtener todos los registros de asistencia
            DateTime fecha = DateTime.Now; // Utilizar la fecha actual por defecto
            ds = objNegAsi.listadoAsistencias(documentoAlu, fecha);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_Asistencias.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
            }
            else
            {
                lbl_Mensaje.Text = "No hay se encuentran cargadas las asistencias en el sistema.";
            }
        }
        private void Ds_a_TxtBoxAsis(DataSet ds)
        {
            txt_IdAsis.Text = ds.Tables[0].Rows[0]["idAsistencia"].ToString();
            txt_docAlu.Text = ds.Tables[0].Rows[0]["docAlumno"].ToString();
            dateTimePicker1.Value = (DateTime)ds.Tables[0].Rows[0]["Fecha"];
            radioButton_Si.Checked = (bool)ds.Tables[0].Rows[0]["Presente"];

            txt_IdAsis.Enabled = false;
            txt_docAlu.Enabled = false;
        }
        private void dgv_Asistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idAsis = dgv_Asistencias.CurrentRow.Cells[0].Value.ToString();
                string documentoAlu = dgv_Asistencias.CurrentRow.Cells[1].Value.ToString();
                DateTime fecha = Convert.ToDateTime(dgv_Asistencias.CurrentRow.Cells[2].Value);
                DataSet ds = objNegAsi.listadoAsistencias(documentoAlu, fecha);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Ds_a_TxtBoxAsis(ds);
                    btn_CargarAsis.Visible = false;
                    lbl_MensajeAsi.Text = string.Empty;
                }
            }
        }
        private void LimpiarDGVAsis()
        {
            txt_IdAsis.Text = string.Empty;
            txt_docAlu.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Today;
            radioButton_Si.Checked = false;
            btn_CargarAsis.Visible = true;
            epv_DniAlumnoAsi.Clear();
        }

        private void btn_CargarAsis_Click(object sender, EventArgs e)
        {
            #region CargaVieja
            //int nGrabados = -1;

            //string documentoAlu = txt_docAlu.Text;

            //if (objNegAsi.ExisteDniAlumno(documentoAlu))
            //{
            //    Asistencia NuevaAsistencia = new Asistencia(int.Parse(txt_docAlu.Text), dateTimePicker1.Value, radioButton_Si.Checked);

            //    nGrabados = objNegAsi.abmAsistencias("Alta", NuevaAsistencia);

            //    if (nGrabados == -1)
            //    {
            //        lbl_MensajeAsi.Text = "No se pudo cargar Alumnos en el sistema.";
            //    }
            //    else
            //    {
            //        lbl_MensajeAsi.Text = "Se cargo el Alumno con éxito.";
            //        LlenarDGVAsis();
            //        LimpiarDGVAsis();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("El DNI ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            #endregion

            int nGrabados = -1;

            string documentoAlu = txt_docAlu.Text;
            string idAsis = txt_IdAsis.Text;

            if (AsistenciaCamposNoVacios() && DocumentoAlumnoAsistenciaNoCaracteres())
            {
                if (objNegAsi.ExisteIdAsistencia(idAsis))
                {
                    epv_DniAlumnoAsi.SetError(txt_IdAsis, "Ya existe este codigo de asistencia.");
                }
                else
                {
                    if (objNegAsi.ExisteDniAlumno(documentoAlu))
                    {
                        // Formatear la fecha en el formato esperado por la base de datos
                        string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

                        // Crear el objeto Asistencia
                        Asistencia NuevaAsistencia = new Asistencia(int.Parse(txt_IdAsis.Text), int.Parse(txt_docAlu.Text), DateTime.Parse(fechaFormateada), radioButton_Si.Checked);

                        nGrabados = objNegAsi.abmAsistencias("Alta", NuevaAsistencia);

                        if (nGrabados == -1)
                        {
                            lbl_MensajeAsi.Text = "No se pudo cargar Alumnos en el sistema.";
                        }
                        else
                        {
                            lbl_MensajeAsi.Text = "Se cargo el Alumno con éxito.";
                            LlenarDGVAsis();
                            LimpiarDGVAsis();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El DNI ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }
        private void btn_ModificarAsis_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            // Obtener la fecha del DateTimePicker en el formato esperado por la base de datos
            DateTime fecha = dateTimePicker1.Value.Date; // Obtiene solo la parte de la fecha, sin la parte de la hora
            Asistencia NuevaAsistencia = new Asistencia( int.Parse(txt_IdAsis.Text), int.Parse(txt_docAlu.Text), fecha, radioButton_Si.Checked);

            DateTime nuevaFecha = fecha;
            nResultado = objNegAsi.abmAsistencias("Modificar", NuevaAsistencia); //invocar a la capa de negocio

            if (nResultado != -1)
            {
                MessageBox.Show("La cuota fue Modificada con éxito", "Aviso");
                LimpiarDGVAsis();
                LlenarDGVAsis();

                txt_docAlu.Enabled = true;
                txt_IdAsis.Enabled = true;
            }
            else
            {
                MessageBox.Show("Se produjo un error al intentar modificar la cuota", "Error");
            }
        }
        private void btnEliminarAsi_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value.Date; // Obtiene solo la parte de la fecha, sin la parte de la hora

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la asistencia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Asistencia NuevaAsistencia = new Asistencia(int.Parse(txt_IdAsis.Text), int.Parse(txt_docAlu.Text), fecha, radioButton_Si.Checked);

                nGrabados = objNegAsi.abmAsistencias("Borrar", NuevaAsistencia);
                LlenarDGVAsis();
                LimpiarDGVAsis();

            }
        }
        private void btn_LimpiezaAsis_Click(object sender, EventArgs e)
        {
            LimpiarDGVAsis();
            txt_docAlu.Enabled = true;
            txt_IdAsis.Enabled = true;

        }

        //Validaciones
        private bool AlumnosCamposNoVacios()
        {
            // Agrega todos los campos que deseas validar aquí.
            Control[] campos = { txt_Documento, txt_Apellido, txt_Nombre };

            foreach (Control campo in campos)
            {
                if (campo is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show(this, "Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está vacío, la validación falla.
                    }
                }
                else if (campo is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Por favor, seleccione una opción en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está sin selección, la validación falla.
                    }
                }
            }

            return true; // Todos los campos están completos, la validación pasa.
        }
        private bool DocumentoAlumnoNoCaracteres()
        {
            TextBox[] campos = { txt_Documento };

            foreach (TextBox campo in campos)
            {
                if (!EsNumero(campo.Text))
                {
                    //MessageBox.Show(this, "Por favor, numeros en el monto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epv_DniAlumno.SetError(txt_Documento, "No se aceptan caracteres en este campo.");
                    return false; // Devuelve false si al menos uno de los campos contiene caracteres no numéricos.
                }
            }

            return true; // Devuelve true si ambos campos solo contienen números.
        }
        private bool DocumentoAlumnoAsistenciaNoCaracteres()
        {
            TextBox[] campos = { txt_docAlu };

            foreach (TextBox campo in campos)
            {
                if (!EsNumero(campo.Text))
                {
                    //MessageBox.Show(this, "Por favor, numeros en el monto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epv_DniAlumnoAsi.SetError(txt_docAlu, "No se aceptan caracteres en este campo.");
                    return false; // Devuelve false si al menos uno de los campos contiene caracteres no numéricos.
                }
            }

            return true; // Devuelve true si ambos campos solo contienen números.
        }

        private bool EsNumero(string texto)
        {
            foreach (char caracter in texto)
            {
                if (!char.IsDigit(caracter))
                {
                    return false; // Devuelve false si encuentra un carácter no numérico.
                }
            }

            return true; // Devuelve true si todos los caracteres son numéricos.
        }
        private void txt_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                epv_DniAlumno.SetError(txt_Documento, "Solo se permiten numero.");
                e.Handled = true;
                return;
            }
        }

        private bool AsistenciaCamposNoVacios()
        {
            // Agrega todos los campos que deseas validar aquí.
            Control[] campos = { txt_IdAsis, txt_docAlu, dateTimePicker1, radioButton_Si, radioButton_No };

            foreach (Control campo in campos)
            {
                if (campo is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show(this, "Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está vacío, la validación falla.
                    }
                }
                else if (campo is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Por favor, seleccione una opción en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está sin selección, la validación falla.
                    }
                }
            }

            return true; // Todos los campos están completos, la validación pasa.
        }
    }
}