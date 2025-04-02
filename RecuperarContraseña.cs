using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Reto_1_PQRS.Ingreso;

namespace Reto_1_PQRS
{
    public partial class RecuperarContraseña: Form
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public RecuperarContraseña(List<Usuario> usuario)
        {
            InitializeComponent();
            usuarios = usuario;

        }

    }
}
