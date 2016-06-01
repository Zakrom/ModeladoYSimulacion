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
            this.colProduccion});
            this.dataGridView1.Location = new System.Drawing.Point(184, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(385, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.Location = new System.Drawing.Point(12, 169);
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(152, 43);
            this.btnSimulacion.TabIndex = 1;
            this.btnSimulacion.Text = "Comenzar Simulacion";
            this.btnSimulacion.UseVisualStyleBackColor = true;
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // numEmpleados
            // 
            this.numEmpleados.Location = new System.Drawing.Point(15, 143);
            this.numEmpleados.Name = "numEmpleados";
            this.numEmpleados.Size = new System.Drawing.Size(146, 20);
            this.numEmpleados.TabIndex = 2;
            this.numEmpleados.ValueChanged += new System.EventHandler(this.numEmpleados_ValueChanged);
            // 
            // lblEmpleadosM
            // 
            this.lblEmpleadosM.AutoSize = true;
            this.lblEmpleadosM.Location = new System.Drawing.Point(12, 114);
            this.lblEmpleadosM.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblEmpleadosM.Name = "lblEmpleadosM";
            this.lblEmpleadosM.Size = new System.Drawing.Size(135, 26);
            this.lblEmpleadosM.TabIndex = 3;
            this.lblEmpleadosM.Text = "Número de Empleados por Turno:";
            this.lblEmpleadosM.Click += new System.EventHandler(this.lblEmpleadosM_Click);
            // 
            // numMeses
            // 
            this.numMeses.Location = new System.Drawing.Point(15, 77);
            this.numMeses.Name = "numMeses";
            this.numMeses.Size = new System.Drawing.Size(149, 20);
            this.numMeses.TabIndex = 4;
            this.numMeses.ValueChanged += new System.EventHandler(this.numMeses_ValueChanged);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(12, 61);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 303);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.numMeses);
            this.Controls.Add(this.lblEmpleadosM);
            this.Controls.Add(this.numEmpleados);
            this.Controls.Add(this.btnSimulacion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

