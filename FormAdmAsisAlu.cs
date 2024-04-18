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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
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
            LlenarCombos();
            LimpiarDGVAsis();
        }

        private void CrearDGVs()
        {
            #region DgvAlumnos
            //Creacion DGV Alumnos
            dgv_Alumnos.ColumnCount = 4;
            dgv_Alumnos.Columns[0].HeaderText = "DNI";
            dgv_Alumnos.Columns[1].HeaderText = "Apellido";
            dgv_Alumnos.Columns[2].HeaderText = "Nombre";
            dgv_Alumnos.Columns[3].HeaderText = "Activo";

            dgv_Alumnos.Columns[0].Width = 100;
            dgv_Alumnos.Columns[1].Width = 100;
            dgv_Alumnos.Columns[2].Width = 100;
            dgv_Alumnos.Columns[3].Width = 50;
            #endregion

            #region DgvAsistencias
            //Creacion DGV Asistencias
            dgv_Asistencias.ColumnCount = 4;
            dgv_Asistencias.Columns[0].HeaderText = "DNI";
            dgv_Asistencias.Columns[1].HeaderText = "Fecha";
            dgv_Asistencias.Columns[2].HeaderText = "Asistencia";

            dgv_Asistencias.Columns[0].Width = 100;
            dgv_Asistencias.Columns[1].Width = 100;
            dgv_Asistencias.Columns[2].Width = 100;

            lbl_fechaNueva.Visible = false;
            dateTimePicker2.Visible = false;
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
                    dgv_Alumnos.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
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
            objEntAlu.Activo = Convert.ToChar("S");
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
            epv_DniAlumno.Clear();
        }

        private void btn_CargarAlu_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            string documentoAlu = txt_Documento.Text;

            if (AlumnosCamposNoVacios())
            {
                if (objNegAlu.ExisteDniAlumno(documentoAlu))
                {
                    MessageBox.Show(this, "El Alumno ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        LlenarCombos();
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
                LlenarCombos();
                txt_Documento.Enabled = true;
            }
            else
            {
                MessageBox.Show("Se produjo un error al intentar modificar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_EliminarAlu_Click(object sender, EventArgs e)
        {
            string asistenciaAlu = txt_Documento.Text; 
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el alumno con DNI " + int.Parse(txt_Documento.Text) + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (objNegAsi.ExisteAsistencia(asistenciaAlu))
                {
                    MessageBox.Show(this, "El alumno cuenta con asistencias cargadas.", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);

                }
                else
                {
                    int nGrabados = -1;
                    Alumno NuevoAlumno = new Alumno(int.Parse(txt_Documento.Text), txt_Apellido.Text, txt_Nombre.Text);

                    nGrabados = objNegAlu.abmAlumnos("Borrar", NuevoAlumno);
                    LlenarDGVAlu();
                    LimpiarDGVAlu();
                    LlenarCombos();

                    txt_Documento.Enabled = true;
                }            
            }
        }
        private void btn_Baja_Click(object sender, EventArgs e)
        {
            string asistenciaAlu = txt_Documento.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea dar de baja al alumno con DNI " + int.Parse(txt_Documento.Text) + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Alumno NuevoAlumno = new Alumno(int.Parse(txt_Documento.Text), txt_Apellido.Text, txt_Nombre.Text);

                nGrabados = objNegAlu.abmAlumnos("Baja", NuevoAlumno);
                LlenarDGVAlu();
                LimpiarDGVAlu();
                LlenarCombos();

                txt_Documento.Enabled = true;
            }
        }
        private void btn_Activar_Click(object sender, EventArgs e)
        {
            string asistenciaAlu = txt_Documento.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea dar de baja al alumno con DNI " + int.Parse(txt_Documento.Text) + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Alumno NuevoAlumno = new Alumno(int.Parse(txt_Documento.Text), txt_Apellido.Text, txt_Nombre.Text);

                nGrabados = objNegAlu.abmAlumnos("Activar", NuevoAlumno);
                LlenarDGVAlu();
                LimpiarDGVAlu();
                LlenarCombos();

                txt_Documento.Enabled = true;
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
                    dgv_Asistencias.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
            }
            else
            {
                lbl_Mensaje.Text = "No hay se encuentran cargadas las asistencias en el sistema.";
            }
        }
        private void LlenarCombos()
        {
            cmb_docAlu.DataSource = objNegAlu.ObtenerAlumnos(); // Asignar la lista de enteros al DataSource directamente
        }
        private void Ds_a_TxtBoxAsis(DataSet ds)
        {
            dateTimePicker2.Visible = true;
            lbl_fechaNueva.Visible = true;

            cmb_docAlu.Text = ds.Tables[0].Rows[0]["docAlumno"].ToString();
            dateTimePicker1.Value = (DateTime)ds.Tables[0].Rows[0]["Fecha"];
            radioButton_Si.Checked = (bool)ds.Tables[0].Rows[0]["Presente"];
            dateTimePicker2.Value = (DateTime)ds.Tables[0].Rows[0]["Fecha"];

            dateTimePicker1.Visible = false;
            lbl_fecha.Visible = false;
        }
        private void dgv_Asistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string documentoAlu = dgv_Asistencias.CurrentRow.Cells[0].Value.ToString();
                DateTime fecha = Convert.ToDateTime(dgv_Asistencias.CurrentRow.Cells[1].Value);
                DataSet ds = objNegAsi.listadoAsistencias(documentoAlu, fecha);
                DateTime nuevaFecha = Convert.ToDateTime(dgv_Asistencias.CurrentRow.Cells[1].Value);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Ds_a_TxtBoxAsis(ds);
                    btn_CargarAsis.Visible = false;
                    cmb_docAlu.Enabled = false;
                    lbl_MensajeAsi.Text = string.Empty;
                }
            }
        }
        private void LimpiarDGVAsis()
        {
            cmb_docAlu.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            radioButton_Si.Checked = false;
            btn_CargarAsis.Visible = true;
            epv_DniAlumnoAsi.Clear();

            lbl_fecha.Visible = true;
            dateTimePicker1.Visible = true;
            cmb_docAlu.Enabled = true;

            lbl_fechaNueva.Visible = false;
            dateTimePicker2.Visible = false;
        }
        private void btn_CargarAsis_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            string documentoAlu = cmb_docAlu.Text;
            DateTime fecha = dateTimePicker1.Value.Date;

            if (AsistenciaCamposNoVacios())
            {
                if (objNegAsi.ExisteDniAlumno(documentoAlu))
                {
                    if (objNegAsi.ExisteAsistenciaFecha(int.Parse(documentoAlu), fecha))
                    {
                        MessageBox.Show("Ya existe una asistencia registrada para este alumno en la fecha especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string fechaFormateada = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                    Asistencia nuevaAsistencia = new Asistencia(int.Parse(cmb_docAlu.Text), DateTime.Parse(fechaFormateada), radioButton_Si.Checked);

                    nGrabados = objNegAsi.abmAsistencias("Alta", nuevaAsistencia);

                    if (nGrabados == -1)
                    {
                        lbl_MensajeAsi.Text = "No se pudo cargar la asistencia en el sistema.";
                    }
                    else
                    {
                        lbl_MensajeAsi.Text = "Se cargó la asistencia con éxito.";
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

        private void btn_ModificarAsis_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            // Obtener la fecha del DateTimePicker en el formato esperado por la base de datos
            //Asistencia NuevaAsistencia = new Asistencia(int.Parse(txt_docAlu.Text), fecha, radioButton_Si.Checked);
            Asistencia NuevaAsistencia = new Asistencia(int.Parse(cmb_docAlu.Text), dateTimePicker1.Value, radioButton_Si.Checked);
            string documentoAlu = cmb_docAlu.Text;
            DateTime nuevaFecha = dateTimePicker2.Value; // Obtiene solo la parte de la fecha, sin la parte de la hora
            //DateTime nuevaFecha = fecha;
            if (objNegAsi.ExisteAsistenciaFecha(int.Parse(documentoAlu), nuevaFecha))
            {
                MessageBox.Show("Ya existe una asistencia registrada para este alumno en la fecha especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                nResultado = objNegAsi.modificarAsistencias("Modificar", NuevaAsistencia, nuevaFecha); //invocar a la capa de negocio

                if (nResultado != -1)
                {
                    MessageBox.Show("La cuota fue Modificada con éxito", "Aviso");
                    LimpiarDGVAsis();
                    LlenarDGVAsis();

                    cmb_docAlu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar la cuota", "Error");
                }
            }
            
        }
        private void btnEliminarAsi_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value.Date; // Obtiene solo la parte de la fecha, sin la parte de la hora

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la asistencia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Asistencia NuevaAsistencia = new Asistencia(int.Parse(cmb_docAlu.Text), fecha, radioButton_Si.Checked);

                nGrabados = objNegAsi.abmAsistencias("Borrar", NuevaAsistencia);
                LlenarDGVAsis();
                LimpiarDGVAsis();

            }
        }
        private void btn_LimpiezaAsis_Click(object sender, EventArgs e)
        {
            LimpiarDGVAsis();
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
                epv_DniAlumno.SetError(txt_Documento, "Solo se permiten numeros.");
                e.Handled = true;
                return;
            }
        }
        private bool AsistenciaCamposNoVacios()
        {
            // Agrega todos los campos que deseas validar aquí.
            Control[] campos = {cmb_docAlu, dateTimePicker1, radioButton_Si, radioButton_No };

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
        private void cmb_docAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                epv_DniAlumnoAsi.SetError(cmb_docAlu, "Solo se permiten numeros.");
                e.Handled = true;
                return;
            }
        }

        //Reporte
        private void CrearReportePdf(DataGridView dataGridView, string outputPath)
        {
            PdfWriter writer = new PdfWriter(outputPath);
            PdfDocument pdf = new PdfDocument(writer);
            Document doc = new Document(pdf);

            // Crea la tabla con las columnas que tenga el dataGridView
            iText.Layout.Element.Table pdfTable = new iText.Layout.Element.Table(dataGridView.Columns.Count);

            // Añade titulos
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                pdfTable.AddCell(new Cell().Add(new Paragraph(column.HeaderText)));
            }


            // Añade los datos del DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Valida si es nulo
                    if (cell != null && cell.Value != null)
                    {
                        pdfTable.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                    }
                    else
                    {
                        // En caso de que sea null
                        pdfTable.AddCell(new Cell().Add(new Paragraph("")));
                    }
                }
            }

            pdfTable.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            // Añade la tabla al documento
            doc.Add(pdfTable);

            doc.Close();
        }
        private void btn_ReporteAlumnos_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Descargas|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dgv_Alumnos, outputPath);
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }
        private void btn_ReporteAsistencia_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Descargas|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dgv_Asistencias, outputPath);
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }
    }
}