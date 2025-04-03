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
    public partial class Solicitudes_3 : Form
    {
        public Solicitudes_3()
        {
            InitializeComponent();
        }
        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            Estado_Solicitud estadoForm = new Estado_Solicitud();
            estadoForm.Show();
            this.Hide();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Solicitudes_1 solicitudes_2Form = new Solicitudes_1();
            solicitudes_2Form.Show();
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
