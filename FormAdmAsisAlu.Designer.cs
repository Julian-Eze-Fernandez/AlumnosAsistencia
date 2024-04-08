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
            this.maskedTextBox_Fecha = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_DocAluAsistencia = new System.Windows.Forms.MaskedTextBox();
            this.btn_EliminarAsis = new System.Windows.Forms.Button();
            this.btn_ModificarAsis = new System.Windows.Forms.Button();
            this.btn_CargarAsis = new System.Windows.Forms.Button();
            this.dgv_Asistencias = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.radioButton_Si = new System.Windows.Forms.RadioButton();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_docAlu = new System.Windows.Forms.Label();
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
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(22, 38);
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
            this.btn_EliminarAlu.Location = new System.Drawing.Point(22, 254);
            this.btn_EliminarAlu.Name = "btn_EliminarAlu";
            this.btn_EliminarAlu.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarAlu.TabIndex = 17;
            this.btn_EliminarAlu.Text = "Eliminar";
            this.btn_EliminarAlu.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarAlu
            // 
            this.btn_ModificarAlu.Location = new System.Drawing.Point(22, 225);
            this.btn_ModificarAlu.Name = "btn_ModificarAlu";
            this.btn_ModificarAlu.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarAlu.TabIndex = 16;
            this.btn_ModificarAlu.Text = "Modificar";
            this.btn_ModificarAlu.UseVisualStyleBackColor = true;
            // 
            // btn_CargarAlu
            // 
            this.btn_CargarAlu.Location = new System.Drawing.Point(22, 196);
            this.btn_CargarAlu.Name = "btn_CargarAlu";
            this.btn_CargarAlu.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarAlu.TabIndex = 15;
            this.btn_CargarAlu.Text = "Cargar";
            this.btn_CargarAlu.UseVisualStyleBackColor = true;
            this.btn_CargarAlu.Click += new System.EventHandler(this.btn_CargarAlu_Click);
            // 
            // dgv_Alumnos
            // 
            this.dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alumnos.Location = new System.Drawing.Point(155, 18);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.Size = new System.Drawing.Size(345, 316);
            this.dgv_Alumnos.TabIndex = 6;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(22, 93);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 5;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(19, 73);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(58, 17);
            this.lbl_Apellido.TabIndex = 4;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(22, 147);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(19, 127);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(58, 17);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Documento
            // 
            this.lbl_Documento.AutoSize = true;
            this.lbl_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Documento.Location = new System.Drawing.Point(19, 18);
            this.lbl_Documento.Name = "lbl_Documento";
            this.lbl_Documento.Size = new System.Drawing.Size(31, 17);
            this.lbl_Documento.TabIndex = 0;
            this.lbl_Documento.Text = "DNI";
            // 
            // PagAsistencias
            // 
            this.PagAsistencias.Controls.Add(this.maskedTextBox_Fecha);
            this.PagAsistencias.Controls.Add(this.maskedTextBox_DocAluAsistencia);
            this.PagAsistencias.Controls.Add(this.btn_EliminarAsis);
            this.PagAsistencias.Controls.Add(this.btn_ModificarAsis);
            this.PagAsistencias.Controls.Add(this.btn_CargarAsis);
            this.PagAsistencias.Controls.Add(this.dgv_Asistencias);
            this.PagAsistencias.Controls.Add(this.groupBox1);
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
            // maskedTextBox_Fecha
            // 
            this.maskedTextBox_Fecha.Location = new System.Drawing.Point(19, 89);
            this.maskedTextBox_Fecha.Mask = "00/00/0000";
            this.maskedTextBox_Fecha.Name = "maskedTextBox_Fecha";
            this.maskedTextBox_Fecha.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Fecha.TabIndex = 21;
            this.maskedTextBox_Fecha.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_DocAluAsistencia
            // 
            this.maskedTextBox_DocAluAsistencia.Location = new System.Drawing.Point(19, 36);
            this.maskedTextBox_DocAluAsistencia.Mask = "00.000.000";
            this.maskedTextBox_DocAluAsistencia.Name = "maskedTextBox_DocAluAsistencia";
            this.maskedTextBox_DocAluAsistencia.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_DocAluAsistencia.TabIndex = 19;
            // 
            // btn_EliminarAsis
            // 
            this.btn_EliminarAsis.Location = new System.Drawing.Point(19, 275);
            this.btn_EliminarAsis.Name = "btn_EliminarAsis";
            this.btn_EliminarAsis.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarAsis.TabIndex = 18;
            this.btn_EliminarAsis.Text = "Eliminar";
            this.btn_EliminarAsis.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarAsis
            // 
            this.btn_ModificarAsis.Location = new System.Drawing.Point(19, 246);
            this.btn_ModificarAsis.Name = "btn_ModificarAsis";
            this.btn_ModificarAsis.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarAsis.TabIndex = 14;
            this.btn_ModificarAsis.Text = "Modificar";
            this.btn_ModificarAsis.UseVisualStyleBackColor = true;
            // 
            // btn_CargarAsis
            // 
            this.btn_CargarAsis.Location = new System.Drawing.Point(19, 217);
            this.btn_CargarAsis.Name = "btn_CargarAsis";
            this.btn_CargarAsis.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarAsis.TabIndex = 13;
            this.btn_CargarAsis.Text = "Cargar";
            this.btn_CargarAsis.UseVisualStyleBackColor = true;
            // 
            // dgv_Asistencias
            // 
            this.dgv_Asistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Asistencias.Location = new System.Drawing.Point(159, 16);
            this.dgv_Asistencias.Name = "dgv_Asistencias";
            this.dgv_Asistencias.Size = new System.Drawing.Size(344, 316);
            this.dgv_Asistencias.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_No);
            this.groupBox1.Controls.Add(this.radioButton_Si);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presente";
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_No.Location = new System.Drawing.Point(7, 43);
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
            this.radioButton_Si.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Si.Name = "radioButton_Si";
            this.radioButton_Si.Size = new System.Drawing.Size(34, 17);
            this.radioButton_Si.TabIndex = 0;
            this.radioButton_Si.TabStop = true;
            this.radioButton_Si.Text = "Si";
            this.radioButton_Si.UseVisualStyleBackColor = true;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(16, 69);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(47, 17);
            this.lbl_fecha.TabIndex = 8;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_docAlu
            // 
            this.lbl_docAlu.AutoSize = true;
            this.lbl_docAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docAlu.Location = new System.Drawing.Point(16, 16);
            this.lbl_docAlu.Name = "lbl_docAlu";
            this.lbl_docAlu.Size = new System.Drawing.Size(82, 17);
            this.lbl_docAlu.TabIndex = 6;
            this.lbl_docAlu.Text = "DNI Alumno";
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Fecha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DocAluAsistencia;
        private System.Windows.Forms.Button btn_EliminarAsis;
        private System.Windows.Forms.Button btn_ModificarAsis;
        private System.Windows.Forms.Button btn_CargarAsis;
        private System.Windows.Forms.DataGridView dgv_Asistencias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_Si;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_docAlu;
    }
}