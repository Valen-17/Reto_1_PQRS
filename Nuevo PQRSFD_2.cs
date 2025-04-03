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
    public partial class Nuevo_PQRSFD_2 : Form
    {
        public Nuevo_PQRSFD_2()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }
        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Nuevo_PQRSFD nuevoPQRSFDForm = new Nuevo_PQRSFD();
            nuevoPQRSFDForm.Show();
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
