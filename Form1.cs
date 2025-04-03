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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Solicitudes solicitudesForm = new Solicitudes();
            solicitudesForm.Show();
            this.Hide();
        }
        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Consultar_Solicitud consultarForm = new Consultar_Solicitud();
            consultarForm.Show();
            this.Hide();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            Nuevo_PQRSFD nuevoPQRSFDForm = new Nuevo_PQRSFD();
            nuevoPQRSFDForm.Show();
            this.Hide();
        }
    }
}
