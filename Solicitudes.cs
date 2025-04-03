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
    public partial class Solicitudes: Form
    {
        public Solicitudes()
        {
            InitializeComponent();
        }
        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }

        private void Next_button_Click(object sender, EventArgs e)

        {
            Solicitudes solicitudesForm = new Solicitudes();
            solicitudesForm.Show();
            this.Hide();
        }

        private void Btn_mostrar_Click(object sender, EventArgs e)
        {
            PanelDenuncia.Visible = !PanelDenuncia.Visible; // Alterna visibilidad del panel
            if (PanelDenuncia.Visible)
            {
                Btn_mostrar.Text = "−"; // Si está visible, mostrar "-"
            }
            else
            {
                Btn_mostrar.Text = "+"; // Si está oculto, mostrar "+"
            }
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            Solicitudes_1 solicitudes_2Form = new Solicitudes_1();
            solicitudes_2Form.Show();
            this.Hide();
        }

        private void Btn_back_Click_1(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
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
