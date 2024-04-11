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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PagAlumnos = new System.Windows.Forms.TabPage();
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
            this.btn_LimpiezaAsis = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Presente = new System.Windows.Forms.Label();
            this.radioButton_Si = new System.Windows.Forms.RadioButton();
            this.btnEliminarAsi = new System.Windows.Forms.Button();
            this.lbl_MensajeAsi = new System.Windows.Forms.Label();
            this.txt_docAlu = new System.Windows.Forms.TextBox();
            this.btn_ModificarAsis = new System.Windows.Forms.Button();
            this.btn_CargarAsis = new System.Windows.Forms.Button();
            this.dgv_Asistencias = new System.Windows.Forms.DataGridView();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_docAlu = new System.Windows.Forms.Label();
            this.txt_IdAsis = new System.Windows.Forms.TextBox();
            this.lbl_IdAsis = new System.Windows.Forms.Label();
            this.btn_LimpiezaAlu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.PagAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).BeginInit();
            this.PagAsistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asistencias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PagAlumnos);
            this.tabControl1.Controls.Add(this.PagAsistencias);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 416);
            this.tabControl1.TabIndex = 1;
            // 
            // PagAlumnos
            // 
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
            this.PagAlumnos.Size = new System.Drawing.Size(529, 390);
            this.PagAlumnos.TabIndex = 0;
            this.PagAlumnos.Text = "Alumnos";
            this.PagAlumnos.UseVisualStyleBackColor = true;
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
            this.txt_Documento.Location = new System.Drawing.Point(16, 75);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(100, 20);
            this.txt_Documento.TabIndex = 19;
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
            this.btn_EliminarAlu.Location = new System.Drawing.Point(16, 291);
            this.btn_EliminarAlu.Name = "btn_EliminarAlu";
            this.btn_EliminarAlu.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarAlu.TabIndex = 17;
            this.btn_EliminarAlu.Text = "Eliminar";
            this.btn_EliminarAlu.UseVisualStyleBackColor = true;
            this.btn_EliminarAlu.Click += new System.EventHandler(this.btn_EliminarAlu_Click);
            // 
            // btn_ModificarAlu
            // 
            this.btn_ModificarAlu.Location = new System.Drawing.Point(16, 262);
            this.btn_ModificarAlu.Name = "btn_ModificarAlu";
            this.btn_ModificarAlu.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarAlu.TabIndex = 16;
            this.btn_ModificarAlu.Text = "Modificar";
            this.btn_ModificarAlu.UseVisualStyleBackColor = true;
            this.btn_ModificarAlu.Click += new System.EventHandler(this.btn_ModificarAlu_Click);
            // 
            // btn_CargarAlu
            // 
            this.btn_CargarAlu.Location = new System.Drawing.Point(16, 233);
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
            this.dgv_Alumnos.Location = new System.Drawing.Point(155, 18);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.Size = new System.Drawing.Size(345, 316);
            this.dgv_Alumnos.TabIndex = 6;
            this.dgv_Alumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alumnos_CellClick);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(16, 130);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 5;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(13, 110);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(58, 17);
            this.lbl_Apellido.TabIndex = 4;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(16, 184);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(13, 164);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(58, 17);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Documento
            // 
            this.lbl_Documento.AutoSize = true;
            this.lbl_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Documento.Location = new System.Drawing.Point(13, 55);
            this.lbl_Documento.Name = "lbl_Documento";
            this.lbl_Documento.Size = new System.Drawing.Size(31, 17);
            this.lbl_Documento.TabIndex = 0;
            this.lbl_Documento.Text = "DNI";
            // 
            // PagAsistencias
            // 
            this.PagAsistencias.Controls.Add(this.groupBox1);
            this.PagAsistencias.Controls.Add(this.txt_IdAsis);
            this.PagAsistencias.Controls.Add(this.lbl_IdAsis);
            this.PagAsistencias.Controls.Add(this.btn_LimpiezaAsis);
            this.PagAsistencias.Controls.Add(this.dateTimePicker1);
            this.PagAsistencias.Controls.Add(this.lbl_Presente);
            this.PagAsistencias.Controls.Add(this.btnEliminarAsi);
            this.PagAsistencias.Controls.Add(this.lbl_MensajeAsi);
            this.PagAsistencias.Controls.Add(this.txt_docAlu);
            this.PagAsistencias.Controls.Add(this.btn_ModificarAsis);
            this.PagAsistencias.Controls.Add(this.btn_CargarAsis);
            this.PagAsistencias.Controls.Add(this.dgv_Asistencias);
            this.PagAsistencias.Controls.Add(this.lbl_fecha);
            this.PagAsistencias.Controls.Add(this.lbl_docAlu);
            this.PagAsistencias.Location = new System.Drawing.Point(4, 22);
            this.PagAsistencias.Name = "PagAsistencias";
            this.PagAsistencias.Padding = new System.Windows.Forms.Padding(3);
            this.PagAsistencias.Size = new System.Drawing.Size(529, 390);
            this.PagAsistencias.TabIndex = 1;
            this.PagAsistencias.Text = "Asistencias";
            this.PagAsistencias.UseVisualStyleBackColor = true;
            // 
            // btn_LimpiezaAsis
            // 
            this.btn_LimpiezaAsis.Image = global::AlumnosAsistencia.Properties.Resources.icons8_clear_24;
            this.btn_LimpiezaAsis.Location = new System.Drawing.Point(116, 16);
            this.btn_LimpiezaAsis.Name = "btn_LimpiezaAsis";
            this.btn_LimpiezaAsis.Size = new System.Drawing.Size(37, 23);
            this.btn_LimpiezaAsis.TabIndex = 31;
            this.btn_LimpiezaAsis.UseVisualStyleBackColor = true;
            this.btn_LimpiezaAsis.Click += new System.EventHandler(this.btn_LimpiezaAsis_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // lbl_Presente
            // 
            this.lbl_Presente.AutoSize = true;
            this.lbl_Presente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Presente.Location = new System.Drawing.Point(251, 346);
            this.lbl_Presente.Name = "lbl_Presente";
            this.lbl_Presente.Size = new System.Drawing.Size(65, 17);
            this.lbl_Presente.TabIndex = 28;
            this.lbl_Presente.Text = "Presente";
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
            // btnEliminarAsi
            // 
            this.btnEliminarAsi.Location = new System.Drawing.Point(19, 332);
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
            // txt_docAlu
            // 
            this.txt_docAlu.Location = new System.Drawing.Point(19, 88);
            this.txt_docAlu.Name = "txt_docAlu";
            this.txt_docAlu.Size = new System.Drawing.Size(100, 20);
            this.txt_docAlu.TabIndex = 22;
            // 
            // btn_ModificarAsis
            // 
            this.btn_ModificarAsis.Location = new System.Drawing.Point(19, 303);
            this.btn_ModificarAsis.Name = "btn_ModificarAsis";
            this.btn_ModificarAsis.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarAsis.TabIndex = 14;
            this.btn_ModificarAsis.Text = "Modificar";
            this.btn_ModificarAsis.UseVisualStyleBackColor = true;
            this.btn_ModificarAsis.Click += new System.EventHandler(this.btn_ModificarAsis_Click);
            // 
            // btn_CargarAsis
            // 
            this.btn_CargarAsis.Location = new System.Drawing.Point(19, 274);
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
            this.dgv_Asistencias.Location = new System.Drawing.Point(159, 16);
            this.dgv_Asistencias.Name = "dgv_Asistencias";
            this.dgv_Asistencias.Size = new System.Drawing.Size(344, 316);
            this.dgv_Asistencias.TabIndex = 12;
            this.dgv_Asistencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Asistencias_CellClick);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(16, 121);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(47, 17);
            this.lbl_fecha.TabIndex = 8;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_docAlu
            // 
            this.lbl_docAlu.AutoSize = true;
            this.lbl_docAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docAlu.Location = new System.Drawing.Point(16, 68);
            this.lbl_docAlu.Name = "lbl_docAlu";
            this.lbl_docAlu.Size = new System.Drawing.Size(82, 17);
            this.lbl_docAlu.TabIndex = 6;
            this.lbl_docAlu.Text = "DNI Alumno";
            // 
            // txt_IdAsis
            // 
            this.txt_IdAsis.Location = new System.Drawing.Point(19, 45);
            this.txt_IdAsis.Name = "txt_IdAsis";
            this.txt_IdAsis.Size = new System.Drawing.Size(100, 20);
            this.txt_IdAsis.TabIndex = 33;
            // 
            // lbl_IdAsis
            // 
            this.lbl_IdAsis.AutoSize = true;
            this.lbl_IdAsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdAsis.Location = new System.Drawing.Point(16, 25);
            this.lbl_IdAsis.Name = "lbl_IdAsis";
            this.lbl_IdAsis.Size = new System.Drawing.Size(21, 17);
            this.lbl_IdAsis.TabIndex = 32;
            this.lbl_IdAsis.Text = "ID";
            // 
            // btn_LimpiezaAlu
            // 
            this.btn_LimpiezaAlu.Image = global::AlumnosAsistencia.Properties.Resources.icons8_clear_24;
            this.btn_LimpiezaAlu.Location = new System.Drawing.Point(16, 18);
            this.btn_LimpiezaAlu.Name = "btn_LimpiezaAlu";
            this.btn_LimpiezaAlu.Size = new System.Drawing.Size(38, 23);
            this.btn_LimpiezaAlu.TabIndex = 32;
            this.btn_LimpiezaAlu.UseVisualStyleBackColor = true;
            this.btn_LimpiezaAlu.Click += new System.EventHandler(this.btn_LimpiezaAlu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_No);
            this.groupBox1.Controls.Add(this.radioButton_Si);
            this.groupBox1.Location = new System.Drawing.Point(19, 168);
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
            // FormAdmAsisAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmAsisAlu";
            this.Text = "FormAdmAsisAlu";
            this.tabControl1.ResumeLayout(false);
            this.PagAlumnos.ResumeLayout(false);
            this.PagAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).EndInit();
            this.PagAsistencias.ResumeLayout(false);
            this.PagAsistencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asistencias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_docAlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MensajeAsi;
        private System.Windows.Forms.Button btnEliminarAsi;
        private System.Windows.Forms.Label lbl_Presente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_LimpiezaAlu;
        private System.Windows.Forms.Button btn_LimpiezaAsis;
        private System.Windows.Forms.TextBox txt_IdAsis;
        private System.Windows.Forms.Label lbl_IdAsis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_No;
    }
}