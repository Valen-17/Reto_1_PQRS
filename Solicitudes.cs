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
        private bool panelVisible = false;
        public Solicitudes()
        {
            InitializeComponent();
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
        private void Ingreso_login_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }
    }
}
