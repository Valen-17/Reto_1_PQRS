using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Reto_1_PQRS.Nuevo_PQRSFD;

namespace Reto_1_PQRS
{
    public partial class Consultar_Solicitud : Form
    {
        private static List<Solicitud> listaSolicitudes = Nuevo_PQRSFD.listaSolicitudes;
        public Consultar_Solicitud()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Txt_codigoSolicitud.Text = "Digite su código";
            Txt_codigoSolicitud.ForeColor = Color.Gray;;
        }
        private void Txt_codigoSolicitud_Enter(object sender, EventArgs e)
        {
            if (Txt_codigoSolicitud.Text == "Digite su código")
            {
                Txt_codigoSolicitud.Text = "";
                Txt_codigoSolicitud.ForeColor = Color.Black;
            }
        }

        private void Txt_codigoSolicitud_Leave(object sender, EventArgs e)
        {
            if (Txt_codigoSolicitud.Text == "")
            {
                Txt_codigoSolicitud.Text = "Digite su código";
                Txt_codigoSolicitud.ForeColor = Color.Gray;
            }   
        }
        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            int codigoBusqueda; 
            bool codigoValido = int.TryParse(Txt_codigoSolicitud.Text, out codigoBusqueda);

            if (!codigoValido)
            {
                MessageBox.Show("Por favor, ingresa un código válido.");
                return;
            }

            // Buscar la solicitud por el código de seguimiento
            var solicitud = listaSolicitudes.FirstOrDefault(s => s.CodigoSeguimiento == codigoBusqueda);

            if (solicitud != null)
            {
                // Mostrar los datos en un MessageBox
                string mensaje = $"Código: {solicitud.CodigoSeguimiento}\n" +
                                 $"Fecha: {solicitud.FechaHoraRadicacion:yyyy-MM-dd HH:mm:ss}\n" +
                                 $"Correo: {solicitud.Correo}\n" +
                                 $"Descripción: {solicitud.Descripcion}";

                MessageBox.Show(mensaje, "Detalles de la Solicitud");
            }
            else
            {
                MessageBox.Show("No se encontraron resultados con el número ingresado, por favor verifica el código e intenta nuevamente");
            }
        }
    }
}
