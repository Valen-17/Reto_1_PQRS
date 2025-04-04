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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }

        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }
    }
}
