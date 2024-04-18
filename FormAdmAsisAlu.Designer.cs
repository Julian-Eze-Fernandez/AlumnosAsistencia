namespace AsistenciaAlumnos
{
    partial class FormAdmAsisAlu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PagAlumnos = new System.Windows.Forms.TabPage();
            this.btn_ReporteAlumnos = new System.Windows.Forms.Button();
            this.btn_Activar = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_LimpiezaAlu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.btn_EliminarAlu = new System.Windows.Forms.Button();
            this.btn_ModificarAlu = new System.Windows.Forms.Button();
            this.btn_CargarAlu = new System.Windows.Forms.Button();
            this.dgv_Alumnos = new System.Windows.Forms.DataGridView();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Documento = new System.Windows.Forms.Label();
            this.PagAsistencias = new System.Windows.Forms.TabPage();
            this.btn_ReporteAsistencia = new System.Windows.Forms.Button();
            this.lbl_fechaNueva = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmb_docAlu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.radioButton_Si = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarAsi = new System.Windows.Forms.Button();
            this.lbl_MensajeAsi = new System.Windows.Forms.Label();
            this.btn_ModificarAsis = new System.Windows.Forms.Button();
            this.btn_CargarAsis = new System.Windows.Forms.Button();
            this.dgv_Asistencias = new System.Windows.Forms.DataGridView();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_docAlu = new System.Windows.Forms.Label();
            this.btn_LimpiezaAsis = new System.Windows.Forms.Button();
            this.epv_DniAlumno = new System.Windows.Forms.ErrorProvider(this.components);
            this.epv_DniAlumnoAsi = new System.Windows.Forms.ErrorProvider(this.components);
            this.epv_IdAsis = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.PagAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).BeginInit();
            this.PagAsistencias.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_DniAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_DniAlumnoAsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_IdAsis)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PagAlumnos);
            this.tabControl1.Controls.Add(this.PagAsistencias);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 453);
            this.tabControl1.TabIndex = 1;
            // 
            // PagAlumnos
            // 
            this.PagAlumnos.Controls.Add(this.btn_ReporteAlumnos);
            this.PagAlumnos.Controls.Add(this.btn_Activar);
            this.PagAlumnos.Controls.Add(this.btn_Baja);
            this.PagAlumnos.Controls.Add(this.btn_LimpiezaAlu);
            this.PagAlumnos.Controls.Add(this.label1);
            this.PagAlumnos.Controls.Add(this.txt_Documento);
            this.PagAlumnos.Controls.Add(this.lbl_Mensaje);
            this.PagAlumnos.Controls.Add(this.btn_EliminarAlu);
            this.PagAlumnos.Controls.Add(this.btn_ModificarAlu);
            this.PagAlumnos.Controls.Add(this.btn_CargarAlu);
            this.PagAlumnos.Controls.Add(this.dgv_Alumnos);
            this.PagAlumnos.Controls.Add(this.txt_Apellido);
            this.PagAlumnos.Controls.Add(this.lbl_Apellido);
            this.PagAlumnos.Controls.Add(this.txt_Nombre);
            this.PagAlumnos.Controls.Add(this.lbl_Nombre);
            this.PagAlumnos.Controls.Add(this.lbl_Documento);
            this.PagAlumnos.Location = new System.Drawing.Point(4, 22);
            this.PagAlumnos.Name = "PagAlumnos";
            this.PagAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.PagAlumnos.Size = new System.Drawing.Size(452, 427);
            this.PagAlumnos.TabIndex = 0;
            this.PagAlumnos.Text = "Alumnos";
            this.PagAlumnos.UseVisualStyleBackColor = true;
            // 
            // btn_ReporteAlumnos
            // 
            this.btn_ReporteAlumnos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ReporteAlumnos.Image = global::AlumnosAsistencia.Properties.Resources.icons8_send_to_printer_16;
            this.btn_ReporteAlumnos.Location = new System.Drawing.Point(385, 9);
            this.btn_ReporteAlumnos.Name = "btn_ReporteAlumnos";
            this.btn_ReporteAlumnos.Size = new System.Drawing.Size(29, 28);
            this.btn_ReporteAlumnos.TabIndex = 35;
            this.btn_ReporteAlumnos.UseVisualStyleBackColor = true;
            this.btn_ReporteAlumnos.Click += new System.EventHandler(this.btn_ReporteAlumnos_Click);
            // 
            // btn_Activar
            // 
            this.btn_Activar.Location = new System.Drawing.Point(324, 70);
            this.btn_Activar.Name = "btn_Activar";
            this.btn_Activar.Size = new System.Drawing.Size(28, 23);
            this.btn_Activar.TabIndex = 34;
            this.btn_Activar.Text = "A";
            this.btn_Activar.UseVisualStyleBackColor = true;
            this.btn_Activar.Click += new System.EventHandler(this.btn_Activar_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(290, 70);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(28, 23);
            this.btn_Baja.TabIndex = 33;
            this.btn_Baja.Text = "B";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_LimpiezaAlu
            // 
            this.btn_LimpiezaAlu.Image = global::AlumnosAsistencia.Properties.Resources.icons8_backspace_48;
            this.btn_LimpiezaAlu.Location = new System.Drawing.Point(376, 70);
            this.btn_LimpiezaAlu.Name = "btn_LimpiezaAlu";
            this.btn_LimpiezaAlu.Size = new System.Drawing.Size(38, 23);
            this.btn_LimpiezaAlu.TabIndex = 32;
            this.btn_LimpiezaAlu.UseVisualStyleBackColor = true;
            this.btn_LimpiezaAlu.Click += new System.EventHandler(this.btn_LimpiezaAlu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(172, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 20;
            // 
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(16, 35);
            this.txt_Documento.MaxLength = 8;
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(100, 20);
            this.txt_Documento.TabIndex = 19;
            this.txt_Documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Documento_KeyPress);
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensaje.ForeColor = System.Drawing.Color.Red;
            this.lbl_Mensaje.Location = new System.Drawing.Point(172, 354);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(0, 17);
            this.lbl_Mensaje.TabIndex = 18;
            // 
            // btn_EliminarAlu
            // 
            this.btn_EliminarAlu.Location = new System.Drawing.Point(209, 70);
            this.btn_EliminarAlu.Name = "btn_EliminarAlu";
            this.btn_EliminarAlu.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarAlu.TabIndex = 17;
            this.btn_EliminarAlu.Text = "Eliminar";
            this.btn_EliminarAlu.UseVisualStyleBackColor = true;
            this.btn_EliminarAlu.Click += new System.EventHandler(this.btn_EliminarAlu_Click);
            // 
            // btn_ModificarAlu
            // 
            this.btn_ModificarAlu.Location = new System.Drawing.Point(113, 70);
            this.btn_ModificarAlu.Name = "btn_ModificarAlu";
            this.btn_ModificarAlu.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarAlu.TabIndex = 16;
            this.btn_ModificarAlu.Text = "Modificar";
            this.btn_ModificarAlu.UseVisualStyleBackColor = true;
            this.btn_ModificarAlu.Click += new System.EventHandler(this.btn_ModificarAlu_Click);
            // 
            // btn_CargarAlu
            // 
            this.btn_CargarAlu.Location = new System.Drawing.Point(16, 70);
            this.btn_CargarAlu.Name = "btn_CargarAlu";
            this.btn_CargarAlu.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarAlu.TabIndex = 15;
            this.btn_CargarAlu.Text = "Cargar";
            this.btn_CargarAlu.UseVisualStyleBackColor = true;
            this.btn_CargarAlu.Click += new System.EventHandler(this.btn_CargarAlu_Click);
            // 
            // dgv_Alumnos
            // 
            this.dgv_Alumnos.AllowUserToAddRows = false;
            this.dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alumnos.Location = new System.Drawing.Point(16, 105);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.Size = new System.Drawing.Size(398, 316);
            this.dgv_Alumnos.TabIndex = 6;
            this.dgv_Alumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alumnos_CellClick);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(133, 35);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 5;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(130, 15);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(58, 17);
            this.lbl_Apellido.TabIndex = 4;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(250, 35);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(247, 15);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(58, 17);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Documento
            // 
            this.lbl_Documento.AutoSize = true;
            this.lbl_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Documento.Location = new System.Drawing.Point(13, 15);
            this.lbl_Documento.Name = "lbl_Documento";
            this.lbl_Documento.Size = new System.Drawing.Size(31, 17);
            this.lbl_Documento.TabIndex = 0;
            this.lbl_Documento.Text = "DNI";
            // 
            // PagAsistencias
            // 
            this.PagAsistencias.Controls.Add(this.btn_ReporteAsistencia);
            this.PagAsistencias.Controls.Add(this.lbl_fechaNueva);
            this.PagAsistencias.Controls.Add(this.dateTimePicker2);
            this.PagAsistencias.Controls.Add(this.cmb_docAlu);
            this.PagAsistencias.Controls.Add(this.groupBox1);
            this.PagAsistencias.Controls.Add(this.dateTimePicker1);
            this.PagAsistencias.Controls.Add(this.btnEliminarAsi);
            this.PagAsistencias.Controls.Add(this.lbl_MensajeAsi);
            this.PagAsistencias.Controls.Add(this.btn_ModificarAsis);
            this.PagAsistencias.Controls.Add(this.btn_CargarAsis);
            this.PagAsistencias.Controls.Add(this.dgv_Asistencias);
            this.PagAsistencias.Controls.Add(this.lbl_fecha);
            this.PagAsistencias.Controls.Add(this.lbl_docAlu);
            this.PagAsistencias.Controls.Add(this.btn_LimpiezaAsis);
            this.PagAsistencias.Location = new System.Drawing.Point(4, 22);
            this.PagAsistencias.Name = "PagAsistencias";
            this.PagAsistencias.Padding = new System.Windows.Forms.Padding(3);
            this.PagAsistencias.Size = new System.Drawing.Size(452, 427);
            this.PagAsistencias.TabIndex = 1;
            this.PagAsistencias.Text = "Asistencias";
            this.PagAsistencias.UseVisualStyleBackColor = true;
            // 
            // btn_ReporteAsistencia
            // 
            this.btn_ReporteAsistencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ReporteAsistencia.Image = global::AlumnosAsistencia.Properties.Resources.icons8_send_to_printer_16;
            this.btn_ReporteAsistencia.Location = new System.Drawing.Point(369, 98);
            this.btn_ReporteAsistencia.Name = "btn_ReporteAsistencia";
            this.btn_ReporteAsistencia.Size = new System.Drawing.Size(29, 28);
            this.btn_ReporteAsistencia.TabIndex = 38;
            this.btn_ReporteAsistencia.UseVisualStyleBackColor = true;
            this.btn_ReporteAsistencia.Click += new System.EventHandler(this.btn_ReporteAsistencia_Click);
            // 
            // lbl_fechaNueva
            // 
            this.lbl_fechaNueva.AutoSize = true;
            this.lbl_fechaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaNueva.Location = new System.Drawing.Point(240, 12);
            this.lbl_fechaNueva.Name = "lbl_fechaNueva";
            this.lbl_fechaNueva.Size = new System.Drawing.Size(92, 17);
            this.lbl_fechaNueva.TabIndex = 37;
            this.lbl_fechaNueva.Text = "Nueva Fecha";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(243, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // cmb_docAlu
            // 
            this.cmb_docAlu.FormattingEnabled = true;
            this.cmb_docAlu.Location = new System.Drawing.Point(19, 33);
            this.cmb_docAlu.Name = "cmb_docAlu";
            this.cmb_docAlu.Size = new System.Drawing.Size(100, 21);
            this.cmb_docAlu.TabIndex = 35;
            this.cmb_docAlu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_docAlu_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_No);
            this.groupBox1.Controls.Add(this.radioButton_Si);
            this.groupBox1.Location = new System.Drawing.Point(341, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 71);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presente";
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_No.Location = new System.Drawing.Point(15, 42);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(39, 17);
            this.radioButton_No.TabIndex = 1;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "No";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // radioButton_Si
            // 
            this.radioButton_Si.AutoSize = true;
            this.radioButton_Si.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Si.Location = new System.Drawing.Point(15, 19);
            this.radioButton_Si.Name = "radioButton_Si";
            this.radioButton_Si.Size = new System.Drawing.Size(34, 17);
            this.radioButton_Si.TabIndex = 0;
            this.radioButton_Si.TabStop = true;
            this.radioButton_Si.Text = "Si";
            this.radioButton_Si.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // btnEliminarAsi
            // 
            this.btnEliminarAsi.Location = new System.Drawing.Point(177, 69);
            this.btnEliminarAsi.Name = "btnEliminarAsi";
            this.btnEliminarAsi.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAsi.TabIndex = 26;
            this.btnEliminarAsi.Text = "Eliminar";
            this.btnEliminarAsi.UseVisualStyleBackColor = true;
            this.btnEliminarAsi.Click += new System.EventHandler(this.btnEliminarAsi_Click);
            // 
            // lbl_MensajeAsi
            // 
            this.lbl_MensajeAsi.AutoSize = true;
            this.lbl_MensajeAsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MensajeAsi.ForeColor = System.Drawing.Color.Red;
            this.lbl_MensajeAsi.Location = new System.Drawing.Point(207, 346);
            this.lbl_MensajeAsi.Name = "lbl_MensajeAsi";
            this.lbl_MensajeAsi.Size = new System.Drawing.Size(0, 17);
            this.lbl_MensajeAsi.TabIndex = 25;
            // 
            // btn_ModificarAsis
            // 
            this.btn_ModificarAsis.Location = new System.Drawing.Point(96, 69);
            this.btn_ModificarAsis.Name = "btn_ModificarAsis";
            this.btn_ModificarAsis.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarAsis.TabIndex = 14;
            this.btn_ModificarAsis.Text = "Modificar";
            this.btn_ModificarAsis.UseVisualStyleBackColor = true;
            this.btn_ModificarAsis.Click += new System.EventHandler(this.btn_ModificarAsis_Click);
            // 
            // btn_CargarAsis
            // 
            this.btn_CargarAsis.Location = new System.Drawing.Point(15, 69);
            this.btn_CargarAsis.Name = "btn_CargarAsis";
            this.btn_CargarAsis.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarAsis.TabIndex = 13;
            this.btn_CargarAsis.Text = "Cargar";
            this.btn_CargarAsis.UseVisualStyleBackColor = true;
            this.btn_CargarAsis.Click += new System.EventHandler(this.btn_CargarAsis_Click);
            // 
            // dgv_Asistencias
            // 
            this.dgv_Asistencias.AllowUserToAddRows = false;
            this.dgv_Asistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Asistencias.Location = new System.Drawing.Point(19, 98);
            this.dgv_Asistencias.Name = "dgv_Asistencias";
            this.dgv_Asistencias.Size = new System.Drawing.Size(344, 314);
            this.dgv_Asistencias.TabIndex = 12;
            this.dgv_Asistencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Asistencias_CellClick);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(133, 13);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(47, 17);
            this.lbl_fecha.TabIndex = 8;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_docAlu
            // 
            this.lbl_docAlu.AutoSize = true;
            this.lbl_docAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docAlu.Location = new System.Drawing.Point(16, 13);
            this.lbl_docAlu.Name = "lbl_docAlu";
            this.lbl_docAlu.Size = new System.Drawing.Size(82, 17);
            this.lbl_docAlu.TabIndex = 6;
            this.lbl_docAlu.Text = "DNI Alumno";
            // 
            // btn_LimpiezaAsis
            // 
            this.btn_LimpiezaAsis.Image = global::AlumnosAsistencia.Properties.Resources.icons8_backspace_48;
            this.btn_LimpiezaAsis.Location = new System.Drawing.Point(258, 68);
            this.btn_LimpiezaAsis.Name = "btn_LimpiezaAsis";
            this.btn_LimpiezaAsis.Size = new System.Drawing.Size(37, 23);
            this.btn_LimpiezaAsis.TabIndex = 31;
            this.btn_LimpiezaAsis.UseVisualStyleBackColor = true;
            this.btn_LimpiezaAsis.Click += new System.EventHandler(this.btn_LimpiezaAsis_Click);
            // 
            // epv_DniAlumno
            // 
            this.epv_DniAlumno.ContainerControl = this;
            // 
            // epv_DniAlumnoAsi
            // 
            this.epv_DniAlumnoAsi.ContainerControl = this;
            // 
            // epv_IdAsis
            // 
            this.epv_IdAsis.ContainerControl = this;
            // 
            // FormAdmAsisAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmAsisAlu";
            this.Text = "Asitencia Alumnos";
            this.tabControl1.ResumeLayout(false);
            this.PagAlumnos.ResumeLayout(false);
            this.PagAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).EndInit();
            this.PagAsistencias.ResumeLayout(false);
            this.PagAsistencias.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_DniAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_DniAlumnoAsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_IdAsis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PagAlumnos;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.Label lbl_Mensaje;
        private System.Windows.Forms.Button btn_EliminarAlu;
        private System.Windows.Forms.Button btn_ModificarAlu;
        private System.Windows.Forms.Button btn_CargarAlu;
        private System.Windows.Forms.DataGridView dgv_Alumnos;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Documento;
        private System.Windows.Forms.TabPage PagAsistencias;
        private System.Windows.Forms.Button btn_ModificarAsis;
        private System.Windows.Forms.Button btn_CargarAsis;
        private System.Windows.Forms.DataGridView dgv_Asistencias;
        private System.Windows.Forms.RadioButton radioButton_Si;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_docAlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MensajeAsi;
        private System.Windows.Forms.Button btnEliminarAsi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_LimpiezaAlu;
        private System.Windows.Forms.Button btn_LimpiezaAsis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.ErrorProvider epv_DniAlumno;
        private System.Windows.Forms.ErrorProvider epv_DniAlumnoAsi;
        private System.Windows.Forms.ErrorProvider epv_IdAsis;
        private System.Windows.Forms.ComboBox cmb_docAlu;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_fechaNueva;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Activar;
        private System.Windows.Forms.Button btn_ReporteAlumnos;
        private System.Windows.Forms.Button btn_ReporteAsistencia;
    }
}