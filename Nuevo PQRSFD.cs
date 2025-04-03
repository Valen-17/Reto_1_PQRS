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
    public partial class Nuevo_PQRSFD: Form
    {
        public Nuevo_PQRSFD()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }
        private void Btn_Inicio_Click(object sender, EventArgs e)
        {

        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            Nuevo_PQRSFD_2 nuevoPQRSFD2Form = new Nuevo_PQRSFD_2();
            nuevoPQRSFD2Form.Show();
            this.Hide();
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }
    }
}
