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
        public Nuevo_PQRSFD_2(int codigoSeguimiento, DateTime fechaHoraRadicacion)
        {
            InitializeComponent();
            Txt_CodigoSeguimiento.Text = codigoSeguimiento.ToString();
            Txt_Fecha.Text = fechaHoraRadicacion.ToString("yyyy-MM-dd HH:mm:ss");

        }
        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
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
