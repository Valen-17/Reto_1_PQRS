using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace Reto_1_PQRS
{
    public partial class Nuevo_PQRSFD : Form
    {
        private Dictionary<string, List<string>> ciudadesPorDepartamento;
        public static List<Solicitud> listaSolicitudes = new List<Solicitud>();
        private static int ultimoCodigo = 1000;
        public Nuevo_PQRSFD()
        {
            InitializeComponent();
            CargarPaises();
            InicializarCiudades();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            AsignarTextoPredeterminado(Txt_Identificacion, "Digite su número de identificación");
            AsignarTextoPredeterminado(Txt_Nombres, "Digite su nombre o razón social");
            AsignarTextoPredeterminado(Txt_apellidos, "Digite sus apellidos o nombre del representante");
            AsignarTextoPredeterminado(Txt_Correo, "Digite su correo electrónico");
            AsignarTextoPredeterminado(Txt_confirmacion, "Correo electrónico");
            AsignarTextoPredeterminado(Txt_TelefonoFijo, "Digite su número de teléfono");
            AsignarTextoPredeterminado(Txt_TelefonoCelular, "Digite su número de celular");
            AsignarTextoPredeterminado(Txt_Direccion, "Digite su dirección");
            AsignarTextoPredeterminado(Txt_BarrioVereda, "Digite su barrio o vereda");
            AsignarTextoPredeterminado(Txt_CodigoPostal, "Digite su código postal");
            AsignarTextoPredeterminado(Txt_Descripcion, "Digite aquí todo el contenido de su solicitud");

            cmbPaises.SelectedIndexChanged += CmbPaises_SelectedIndexChanged; // Asignar eventos a los ComboBox
            cmbDepartamentos.SelectedIndexChanged += CmbDepartamentos_SelectedIndexChanged;
        }
        private void AsignarTextoPredeterminado(Guna2TextBox textBox, string texto)
        {
            textBox.Text = texto;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == texto)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = texto;
                    textBox.ForeColor = Color.Gray;
                }
            };
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
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }

        private void CargarPaises()
        {
            List<string> paises = new List<string>
            {
                "Seleccione el País", "Estados Unidos", "Canadá", "México", "Brasil", "Argentina", "Colombia",
                "Reino Unido", "Francia", "Alemania", "Italia", "España", "China", "Japón"
            };

            cmbPaises.DataSource = paises; // Asigna la lista de países al ComboBox
        }

        private void CmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaises.SelectedItem.ToString() == "Colombia")
            {
                CargarDepartamentos();
                cmbDepartamentos.Enabled = true;
            }
            else
            {
                // Si no es Colombia, deshabilita los departamentos y ciudades
                cmbDepartamentos.DataSource = null;
                cmbDepartamentos.Enabled = false;

                cmbCiudades.DataSource = null;
                cmbCiudades.Enabled = false;
            }
        }

        private void CargarDepartamentos()
        {
            List<string> departamentos = new List<string>
            {
            "Seleccione el Departamento", "Antioquia", "Cundinamarca", "Valle del Cauca", "Santander", "Atlántico"
            };

            cmbDepartamentos.DataSource = departamentos;
        }

        private void InicializarCiudades()
        {
            ciudadesPorDepartamento = new Dictionary<string, List<string>>
            {
                { "Antioquia", new List<string> { "Seleccione la Ciudad", "Medellín", "Bello", "Itagüí", "Envigado", "Rionegro" } },
                { "Cundinamarca", new List<string> { "Seleccione la Ciudad", "Bogotá", "Soacha", "Chía", "Zipaquirá", "Facatativá" } },
                { "Valle del Cauca", new List<string> { "Seleccione la Ciudad", "Cali", "Palmira", "Buenaventura", "Tuluá", "Cartago" } },
                { "Santander", new List<string> { "Seleccione la Ciudad", "Bucaramanga", "Floridablanca", "Girón", "Piedecuesta", "Barrancabermeja" } },
                { "Atlántico", new List<string> { "Seleccione la Ciudad", "Barranquilla", "Soledad", "Malambo", "Galapa", "Puerto Colombia" } }
            };
        }

        private void CmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departamentoSeleccionado = cmbDepartamentos.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(departamentoSeleccionado) && ciudadesPorDepartamento.ContainsKey(departamentoSeleccionado))
            {
                cmbCiudades.DataSource = ciudadesPorDepartamento[departamentoSeleccionado];
                cmbCiudades.Enabled = true;
            }
            else
            {
                cmbCiudades.DataSource = null;
                cmbCiudades.Enabled = false; // Si no hay ciudades disponibles, limpiar y deshabilitar el ComboBox de ciudades
            }
        }
        
        private void cmbDepartamentos_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                int codigoSeguimiento = GenerarCodigoSeguimiento();
                DateTime fechaHoraRadicacion = DateTime.Now;

                Solicitud nuevaSolicitud = new Solicitud
                {
                    CodigoSeguimiento = codigoSeguimiento,
                    FechaHoraRadicacion = fechaHoraRadicacion,
                    Correo = Txt_Correo.Text,
                    Descripcion = Txt_Descripcion.Text
                };

                listaSolicitudes.Add(nuevaSolicitud);

                // Abrir el formulario 2 y pasarle los datos de código y fecha
                Nuevo_PQRSFD_2 nuevoPQRSFD2Form = new Nuevo_PQRSFD_2(codigoSeguimiento, fechaHoraRadicacion);

                nuevoPQRSFD2Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return; 
            }

            MessageBox.Show("Formulario enviado correctamente.");
        }
        private int GenerarCodigoSeguimiento()
        {
            if (listaSolicitudes.Count == 0)
            {
                return 1000; // Primer código
            }
            else
            {
                return listaSolicitudes.Count > 0 ? listaSolicitudes.Max(s => s.CodigoSeguimiento) + 1 : 1;
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(Txt_Correo.Text) ||
                string.IsNullOrWhiteSpace(Txt_confirmacion.Text) ||
                string.IsNullOrWhiteSpace(Txt_Descripcion.Text) ||
                cmbTipoSolicitud.SelectedIndex == 0 ||
                cmbMedioRespuesta.SelectedIndex == 0 ||
                cmbTipoSolicitante.SelectedIndex == 0)
            {
                return false;
            }
            if (!chkAutorizacion.Checked)
            {
                MessageBox.Show("Debe aceptar la autorización de datos personales para continuar.");
                return false; 
            }
            return true;
        }
        //Registro de formulario
        public class Solicitud
        {
            public int CodigoSeguimiento { get; set; }
            public DateTime FechaHoraRadicacion { get; set; }
            public string Correo { get; set; }
            public string Descripcion { get; set; }
        }

        private void cmbPaises_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
