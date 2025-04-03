using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto_1_PQRS
{
    public partial class Solicitudes_1 : Form
    {
        public Solicitudes_1()
        {
            InitializeComponent();
        }
        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Solicitudes solicitudesForm = new Solicitudes();
            solicitudesForm.Show();
            this.Hide();
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            Solicitudes_3 solicitudes_3Form = new Solicitudes_3();
            solicitudes_3Form.Show();
            this.Hide();
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }
    }
}
