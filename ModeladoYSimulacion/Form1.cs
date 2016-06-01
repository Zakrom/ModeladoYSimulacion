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
            int days = Convert.ToInt32(numMeses.Value) * 4; 
           
            for(int i =1; i <= days; i++)
            {

                dataGridView1.Rows.Add(i, "Matutino", asistenciaM(), produccionM());
                dataGridView1.Rows.Add(i, "Vespertino", asistenciaV(), produccionV());
                dataGridView1.Rows.Add(i, "Nocturno", asistenciaN(), produccionN());
               
                    

            }

            
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
            int produccionM = asistencia * 25 * 8;

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
            int produccionV = asistencia * 25 * 8;
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
            int produccionN = asistencia * 25 * 8;
            return produccionN;
        }

    }
     
}
