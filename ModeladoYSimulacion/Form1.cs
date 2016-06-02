using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeladoYSimulacion
{
    public partial class Form1 : Form
    {

        float x = 27;
        float mul = 29;
        float ca = 107;
        float mod = 1031;
        float nx = 0;
        int asistencia;
        float R;
        float restante;
        int semanas;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void lblEmpleadosM_Click(object sender, EventArgs e)
        {

        }

        private void numEmpleados_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numMeses_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblMeses_Click(object sender, EventArgs e)
        {

        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            semanas = Convert.ToInt32(numMeses.Value) * 4;
            dataGridView1.Rows.Clear();
           
            for(int i =1; i <= semanas; i++)
            {

                dataGridView1.Rows.Add(i, "Matutino", asistenciaM(), produccionM(), restante);
                dataGridView1.Rows.Add(i, "Vespertino", asistenciaV(), produccionV(), restante);
                dataGridView1.Rows.Add(i, "Nocturno", asistenciaN(), produccionN(), restante);
            }
            calcularPromedios(); 
        }

        public float randomGen()
        {
            nx = (mul * x + ca) % mod;
            x = nx;
            nx /= mod;
            float rnd = nx;
            return rnd;
        }

        public int asistenciaM()
        {
            
            double k = -1.5955;
            double s = 1.422;
            double m = 5.2675;
            asistencia = 0;
            for (int i = 0; i < numEmpleados.Value; i++)
            {
                R = randomGen();
                double rndVar = (Math.Pow((-Math.Log(R)), -k) * (-k * m * Math.Pow((-Math.Log(R)), k) + s * Math.Pow(-Math.Log(R), k) - s)) / -k;
                asistencia += Convert.ToInt32(rndVar);
            }
            
            return asistencia;
        }

        public int produccionM()
        {
            restante = 0;
            int produccionM = asistencia * 25 * 7;

            if(produccionM > 4800)
            {
                restante = (produccionM - 4800) / 100;
                produccionM = 4800;
            }

            return produccionM;
        }

        public int asistenciaV()
        {
            
            double k = -1.4223;
            double s = 2.0351;
            double m = 4.8173;
            asistencia = 0;
            for (int i = 0; i < numEmpleados.Value; i++)
            {
                R = randomGen();
                double rndVar = (Math.Pow((-Math.Log(R)), -k) * (-k * m * Math.Pow((-Math.Log(R)), k) + s * Math.Pow(-Math.Log(R), k) - s)) / -k;
                asistencia += Convert.ToInt32(rndVar);
            }

            return asistencia;

        }

        public int produccionV()
        {
            restante = 0;
            int produccionV = asistencia * 25 * 7;
            if (produccionV > 4800)
            {
                restante = (produccionV - 4800) / 100;
                produccionV = 4800;
            }

            return produccionV;
        }

        public int asistenciaN()
        {
            
            double k = -0.60415;
            double s = 2.4545;
            double m = 3.2164;
            asistencia = 0;
            for (int i = 0; i < numEmpleados.Value; i++)
            {
                R = randomGen();
                double rndVar = (Math.Pow((-Math.Log(R)), -k) * (-k * m * Math.Pow((-Math.Log(R)), k) + s * Math.Pow(-Math.Log(R), k) - s)) / -k;
                asistencia += Convert.ToInt32(rndVar);
            }

            return asistencia;
        }

        public int produccionN()
        {
            restante = 0;
            int produccionN = asistencia * 25 * 7;
            if (produccionN > 4800)
            {
                restante = (produccionN - 4800) / 100;
                produccionN = 4800;
            }

            return produccionN;
        }


        public void calcularPromedios()
        {
            lblAsistenciasM.Text = "Asistencias:";
            lblAsistenciasV.Text = "Asistencias:";
            lblAsistenciasN.Text = "Asistencias:";
            lblProduccionM.Text = "Produccion:";
            lblProduccionV.Text = "Produccion:";
            lblProduccionN.Text = "Produccion:";
            lblOcioM.Text = "Tiempo de Ocio:";
            lblOcioV.Text = "Tiempo de Ocio:";
            lblOcioN.Text = "Tiempo de Ocio:";

            float AsistenciaM =0;
            float AsistenciaV =0;
            float AsistenciaN =0;
            float ProduccionM =0;
            float ProduccionV = 0;
            float ProduccionN = 0;
            float OcioM = 0;
            float OcioV = 0;
            float OcioN = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //2==asistencia,3==produccion,4==ocio
                if (Convert.ToString(row.Cells[1].Value) == "Matutino")
                {
                    AsistenciaM += Convert.ToInt32(row.Cells[2].Value);
                    ProduccionM += Convert.ToInt32(row.Cells[3].Value);
                    OcioM += Convert.ToInt32(row.Cells[4].Value);
                }

                else if (Convert.ToString(row.Cells[1].Value) == "Vespertino")
                {
                    AsistenciaV += Convert.ToInt32(row.Cells[2].Value);
                    ProduccionV += Convert.ToInt32(row.Cells[3].Value);
                    OcioV += Convert.ToInt32(row.Cells[4].Value);
                }

                else if (Convert.ToString(row.Cells[1].Value) == "Nocturno")
                {
                    AsistenciaN += Convert.ToInt32(row.Cells[2].Value);
                    ProduccionN += Convert.ToInt32(row.Cells[3].Value);
                    OcioN += Convert.ToInt32(row.Cells[4].Value);
                } 
            }
            float promProduccionM = ProduccionM / semanas;
            float promProduccionV = ProduccionV / semanas;
            float promProduccionN = ProduccionN / semanas;
            float promAsistenciasM = AsistenciaM / semanas;
            float promAsistenciasV = AsistenciaV / semanas;
            float promAsistenciasN = AsistenciaN / semanas;
            float promOcioM = OcioM / semanas;
            float promOcioV = OcioV / semanas;
            float promOcioN = OcioN / semanas;

            lblAsistenciasM.Text += " " + Convert.ToString(promAsistenciasM)+ " semanalmente";
            lblAsistenciasV.Text += " " + Convert.ToString(promAsistenciasV) + " semanalmente";
            lblAsistenciasN.Text += " " + Convert.ToString(promAsistenciasN) + " semanalmente"; 
            lblProduccionM.Text += " " + Convert.ToString(promProduccionM)+ " kg.";
            lblProduccionV.Text += " " + Convert.ToString(promProduccionV) + " kg.";
            lblProduccionN.Text += " " + Convert.ToString(promProduccionN) + " kg.";
            lblOcioM.Text += " " + Convert.ToString(promOcioM) + " horas";
            lblOcioV.Text += " " + Convert.ToString(promOcioV) + " horas";
            lblOcioN.Text += " " + Convert.ToString(promOcioN) + " horas";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
     
}
