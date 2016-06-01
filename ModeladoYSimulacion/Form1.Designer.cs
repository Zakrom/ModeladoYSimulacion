namespace ModeladoYSimulacion
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSimulacion = new System.Windows.Forms.Button();
            this.numEmpleados = new System.Windows.Forms.NumericUpDown();
            this.lblEmpleadosM = new System.Windows.Forms.Label();
            this.numMeses = new System.Windows.Forms.NumericUpDown();
            this.lblMeses = new System.Windows.Forms.Label();
            this.colWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAsistenciasM = new System.Windows.Forms.Label();
            this.lblProduccionM = new System.Windows.Forms.Label();
            this.lblOcioM = new System.Windows.Forms.Label();
            this.lblOcioV = new System.Windows.Forms.Label();
            this.lblProduccionV = new System.Windows.Forms.Label();
            this.lblAsistenciasV = new System.Windows.Forms.Label();
            this.lblOcioN = new System.Windows.Forms.Label();
            this.lblProduccionN = new System.Windows.Forms.Label();
            this.lblAsistenciasN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWeek,
            this.colTurno,
            this.colAsistencias,
            this.colProduccion,
            this.colOcio});
            this.dataGridView1.Location = new System.Drawing.Point(184, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(496, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.Location = new System.Drawing.Point(12, 120);
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(152, 43);
            this.btnSimulacion.TabIndex = 1;
            this.btnSimulacion.Text = "Comenzar Simulación";
            this.btnSimulacion.UseVisualStyleBackColor = true;
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // numEmpleados
            // 
            this.numEmpleados.Location = new System.Drawing.Point(15, 94);
            this.numEmpleados.Name = "numEmpleados";
            this.numEmpleados.Size = new System.Drawing.Size(146, 20);
            this.numEmpleados.TabIndex = 2;
            this.numEmpleados.ValueChanged += new System.EventHandler(this.numEmpleados_ValueChanged);
            // 
            // lblEmpleadosM
            // 
            this.lblEmpleadosM.AutoSize = true;
            this.lblEmpleadosM.Location = new System.Drawing.Point(12, 65);
            this.lblEmpleadosM.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblEmpleadosM.Name = "lblEmpleadosM";
            this.lblEmpleadosM.Size = new System.Drawing.Size(135, 26);
            this.lblEmpleadosM.TabIndex = 3;
            this.lblEmpleadosM.Text = "Número de Empleados por Turno:";
            this.lblEmpleadosM.Click += new System.EventHandler(this.lblEmpleadosM_Click);
            // 
            // numMeses
            // 
            this.numMeses.Location = new System.Drawing.Point(15, 28);
            this.numMeses.Name = "numMeses";
            this.numMeses.Size = new System.Drawing.Size(149, 20);
            this.numMeses.TabIndex = 4;
            this.numMeses.ValueChanged += new System.EventHandler(this.numMeses_ValueChanged);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(12, 12);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(96, 13);
            this.lblMeses.TabIndex = 5;
            this.lblMeses.Text = "Número de Meses:";
            this.lblMeses.Click += new System.EventHandler(this.lblMeses_Click);
            // 
            // colWeek
            // 
            this.colWeek.HeaderText = "Semana";
            this.colWeek.Name = "colWeek";
            this.colWeek.ReadOnly = true;
            this.colWeek.Width = 50;
            // 
            // colTurno
            // 
            this.colTurno.HeaderText = "Turno";
            this.colTurno.Name = "colTurno";
            this.colTurno.ReadOnly = true;
            // 
            // colAsistencias
            // 
            this.colAsistencias.HeaderText = "Asistencias";
            this.colAsistencias.Name = "colAsistencias";
            this.colAsistencias.ReadOnly = true;
            // 
            // colProduccion
            // 
            this.colProduccion.HeaderText = "Kg. Producidos";
            this.colProduccion.Name = "colProduccion";
            this.colProduccion.ReadOnly = true;
            // 
            // colOcio
            // 
            this.colOcio.HeaderText = "Tiempo de Ocio en Horas";
            this.colOcio.Name = "colOcio";
            this.colOcio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Promedios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matutino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vespertino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nocturno";
            // 
            // lblAsistenciasM
            // 
            this.lblAsistenciasM.AutoSize = true;
            this.lblAsistenciasM.Location = new System.Drawing.Point(12, 204);
            this.lblAsistenciasM.Name = "lblAsistenciasM";
            this.lblAsistenciasM.Size = new System.Drawing.Size(63, 13);
            this.lblAsistenciasM.TabIndex = 10;
            this.lblAsistenciasM.Text = "Asistencias:";
            // 
            // lblProduccionM
            // 
            this.lblProduccionM.AutoSize = true;
            this.lblProduccionM.Location = new System.Drawing.Point(12, 217);
            this.lblProduccionM.Name = "lblProduccionM";
            this.lblProduccionM.Size = new System.Drawing.Size(64, 13);
            this.lblProduccionM.TabIndex = 11;
            this.lblProduccionM.Text = "Producción:";
            // 
            // lblOcioM
            // 
            this.lblOcioM.AutoSize = true;
            this.lblOcioM.Location = new System.Drawing.Point(12, 230);
            this.lblOcioM.Name = "lblOcioM";
            this.lblOcioM.Size = new System.Drawing.Size(85, 13);
            this.lblOcioM.TabIndex = 12;
            this.lblOcioM.Text = "Tiempo de Ocio:";
            // 
            // lblOcioV
            // 
            this.lblOcioV.AutoSize = true;
            this.lblOcioV.Location = new System.Drawing.Point(12, 303);
            this.lblOcioV.Name = "lblOcioV";
            this.lblOcioV.Size = new System.Drawing.Size(85, 13);
            this.lblOcioV.TabIndex = 15;
            this.lblOcioV.Text = "Tiempo de Ocio:";
            // 
            // lblProduccionV
            // 
            this.lblProduccionV.AutoSize = true;
            this.lblProduccionV.Location = new System.Drawing.Point(12, 290);
            this.lblProduccionV.Name = "lblProduccionV";
            this.lblProduccionV.Size = new System.Drawing.Size(64, 13);
            this.lblProduccionV.TabIndex = 14;
            this.lblProduccionV.Text = "Producción:";
            // 
            // lblAsistenciasV
            // 
            this.lblAsistenciasV.AutoSize = true;
            this.lblAsistenciasV.Location = new System.Drawing.Point(12, 277);
            this.lblAsistenciasV.Name = "lblAsistenciasV";
            this.lblAsistenciasV.Size = new System.Drawing.Size(63, 13);
            this.lblAsistenciasV.TabIndex = 13;
            this.lblAsistenciasV.Text = "Asistencias:";
            // 
            // lblOcioN
            // 
            this.lblOcioN.AutoSize = true;
            this.lblOcioN.Location = new System.Drawing.Point(14, 373);
            this.lblOcioN.Name = "lblOcioN";
            this.lblOcioN.Size = new System.Drawing.Size(85, 13);
            this.lblOcioN.TabIndex = 18;
            this.lblOcioN.Text = "Tiempo de Ocio:";
            // 
            // lblProduccionN
            // 
            this.lblProduccionN.AutoSize = true;
            this.lblProduccionN.Location = new System.Drawing.Point(14, 360);
            this.lblProduccionN.Name = "lblProduccionN";
            this.lblProduccionN.Size = new System.Drawing.Size(64, 13);
            this.lblProduccionN.TabIndex = 17;
            this.lblProduccionN.Text = "Producción:";
            // 
            // lblAsistenciasN
            // 
            this.lblAsistenciasN.AutoSize = true;
            this.lblAsistenciasN.Location = new System.Drawing.Point(14, 347);
            this.lblAsistenciasN.Name = "lblAsistenciasN";
            this.lblAsistenciasN.Size = new System.Drawing.Size(63, 13);
            this.lblAsistenciasN.TabIndex = 16;
            this.lblAsistenciasN.Text = "Asistencias:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 430);
            this.Controls.Add(this.lblOcioN);
            this.Controls.Add(this.lblProduccionN);
            this.Controls.Add(this.lblAsistenciasN);
            this.Controls.Add(this.lblOcioV);
            this.Controls.Add(this.lblProduccionV);
            this.Controls.Add(this.lblAsistenciasV);
            this.Controls.Add(this.lblOcioM);
            this.Controls.Add(this.lblProduccionM);
            this.Controls.Add(this.lblAsistenciasM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.numMeses);
            this.Controls.Add(this.lblEmpleadosM);
            this.Controls.Add(this.numEmpleados);
            this.Controls.Add(this.btnSimulacion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSimulacion;
        private System.Windows.Forms.NumericUpDown numEmpleados;
        private System.Windows.Forms.Label lblEmpleadosM;
        private System.Windows.Forms.NumericUpDown numMeses;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOcio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAsistenciasM;
        private System.Windows.Forms.Label lblProduccionM;
        private System.Windows.Forms.Label lblOcioM;
        private System.Windows.Forms.Label lblOcioV;
        private System.Windows.Forms.Label lblProduccionV;
        private System.Windows.Forms.Label lblAsistenciasV;
        private System.Windows.Forms.Label lblOcioN;
        private System.Windows.Forms.Label lblProduccionN;
        private System.Windows.Forms.Label lblAsistenciasN;
    }
}

