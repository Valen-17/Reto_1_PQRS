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
    public partial class Ingreso : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        public Ingreso()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Txt_password.Text = "Contraseña";
            Txt_username.Text = "Identificación";
            Txt_username.ForeColor = Color.Gray;
            Txt_password.ForeColor = Color.Gray;

            // Usuario admin
            usuarios.Add(new Usuario("admin", "admin123", "admin"));
        }
        private void Txt_username_Enter(object sender, EventArgs e)
        {
            if (Txt_username.Text == "Identificación")
            {
                Txt_username.Text = "";
                Txt_username.ForeColor = Color.Black;
            }
        }

        private void Txt_username_Leave(object sender, EventArgs e)
        {
            if (Txt_username.Text == "")
            {
                Txt_username.Text = "Identificación";
                Txt_username.ForeColor = Color.Gray;
            }
        }

        private void Txt_password_Enter(object sender, EventArgs e)
        {
            if (Txt_password.Text == "Contraseña")
            {
                Txt_password.Text = "";
                Txt_password.ForeColor = Color.Black;
                Txt_password.UseSystemPasswordChar = true;
            }
        }

        private void Txt_password_Leave(object sender, EventArgs e)
        {
            if (Txt_password.Text == "")
            {
                Txt_password.Text = "Contraseña";
                Txt_password.ForeColor = Color.Gray;
                Txt_password.UseSystemPasswordChar = false;
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = usuarios.FirstOrDefault(u => u.Username == Txt_username.Text && u.Password == Txt_password.Text);
            if (usuario != null)
            {
                MessageBox.Show($"Bienvenido {usuario.Username}");
                if (usuario.Rol == "admin")
                {
                    FormAdmin adminForm = new FormAdmin();
                    adminForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }
        private void Recuperar_Contraseña_Click(object sender, EventArgs e)
        {
            RecuperarContraseña recuperarForm = new RecuperarContraseña(usuarios);
            recuperarForm.Show();
        }

        public class Usuario
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Rol { get; set; }
            public Usuario(string username, string password, string rol)
            {
                Username = username;
                Password = password;
                Rol = rol;
            }
        }
    }
}
  

