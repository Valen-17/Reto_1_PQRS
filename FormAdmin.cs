using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Reto_1_PQRS.Ingreso;
using static Reto_1_PQRS.Nuevo_PQRSFD;

namespace Reto_1_PQRS
{
    public partial class FormAdmin : Form
    {
        private List<Solicitud> solicitudes;

        public FormAdmin(List<Solicitud> solicitudesRecibidas)
        {
            InitializeComponent();
            solicitudes = solicitudesRecibidas;
            CargarDatos();
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }

        private void Ingreso_Click(object sender, EventArgs e)
        {
            Ingreso ingresoForm = new Ingreso();
            ingresoForm.Show();
            this.Hide();
        }

        private void CargarDatos()
        {
            dvg_Solicitudes.DataSource = null;
            dvg_Solicitudes.DataSource = new BindingSource { DataSource = solicitudes };
        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            if (dvg_Solicitudes.SelectedRows.Count > 0)
            {
                var selectedRow = dvg_Solicitudes.SelectedRows[0];

                if (selectedRow.Cells["CodigoSeguimiento"].Value != null &&
                    int.TryParse(selectedRow.Cells["CodigoSeguimiento"].Value.ToString(), out int codigo))
                {
                    Solicitud solicitud = solicitudes.FirstOrDefault(s => s.CodigoSeguimiento == codigo);

                    if (solicitud != null)
                    {
                        MessageBox.Show(
                            $"Código: {solicitud.CodigoSeguimiento}\n" +
                            $"Fecha: {solicitud.FechaHoraRadicacion:yyyy-MM-dd HH:mm:ss}\n" +
                            $"Correo: {solicitud.Correo}\n" +
                            $"Descripción: {solicitud.Descripcion}\n" +
                            $"Estado: {solicitud.Estado}",
                            "Estado de la Solicitud"
                        );
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona una solicitud.");
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dvg_Solicitudes.SelectedRows.Count > 0)
            {
                var cellValue = dvg_Solicitudes.SelectedRows[0].Cells["CodigoSeguimiento"].Value;

                if (int.TryParse(cellValue?.ToString(), out int codigo))
                {
                    solicitudes.RemoveAll(s => s.CodigoSeguimiento == codigo);
                    CargarDatos();
                }
            }
        }

        private void BtnResponder_Click(object sender, EventArgs e)
        {
            if (dvg_Solicitudes.SelectedRows.Count > 0)
            {
                var selectedRow = dvg_Solicitudes.SelectedRows[0];

                if (selectedRow.Cells["CodigoSeguimiento"].Value != null &&
                    int.TryParse(selectedRow.Cells["CodigoSeguimiento"].Value.ToString(), out int codigo))
                {
                    Solicitud solicitud = solicitudes.FirstOrDefault(s => s.CodigoSeguimiento == codigo);

                    if (solicitud != null)
                    {
                        solicitud.Estado = "Respondida";
                        MessageBox.Show("La solicitud ha sido marcada como respondida.");
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona una solicitud para responder.");
                    }
                }
            }
        }
    }
}
