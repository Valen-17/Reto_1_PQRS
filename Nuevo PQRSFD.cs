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
    public partial class Nuevo_PQRSFD : Form
    {
        public Nuevo_PQRSFD()
        {
            InitializeComponent();
            CargarPaises();
            InicializarCiudades();
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
        private Dictionary<string, List<string>> ciudadesPorDepartamento;

        private void CargarPaises()
        {
            List<string> paises = new List<string>
            {
                "Estados Unidos", "Canadá", "México", "Brasil", "Argentina", "Colombia",
                "Reino Unido", "Francia", "Alemania", "Italia", "España", "China", "Japón"
            };

            cmbPaises.DataSource = paises;
            cmbPaises.SelectedIndexChanged += CmbPaises_SelectedIndexChanged;
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
                "Antioquia", "Cundinamarca", "Valle del Cauca", "Santander", "Atlántico"
            };

            cmbDepartamentos.DataSource = departamentos;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
        }

        private void InicializarCiudades()
        {
            ciudadesPorDepartamento = new Dictionary<string, List<string>>
            {
                { "Antioquia", new List<string> { "Medellín", "Bello", "Itagüí", "Envigado", "Rionegro" } },
                { "Cundinamarca", new List<string> { "Bogotá", "Soacha", "Chía", "Zipaquirá", "Facatativá" } },
                { "Valle del Cauca", new List<string> { "Cali", "Palmira", "Buenaventura", "Tuluá", "Cartago" } },
                { "Santander", new List<string> { "Bucaramanga", "Floridablanca", "Girón", "Piedecuesta", "Barrancabermeja" } },
                { "Atlántico", new List<string> { "Barranquilla", "Soledad", "Malambo", "Galapa", "Puerto Colombia" } }
            };
        }
        private void Selected_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaises.SelectedItem.ToString() == "Colombia")
            {
                CargarDepartamentos();
                cmbDepartamentos.Enabled = true;
            }
            else
            {
                cmbDepartamentos.DataSource = null;
                cmbDepartamentos.Enabled = false;
            }

        }
        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
