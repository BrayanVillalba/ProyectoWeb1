using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidades;
using capaLogica;

namespace capaDiseño
{
    public partial class frmRegCliente : Form
    {
        public frmRegCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            clsCliente cliente = new clsCliente();

            cliente.Documento = txtDocumento.Text;
            cliente.PrimerNombre = txtPrimerNombre.Text;
            cliente.SegundoNombre = txtSegundoNombre.Text;
            cliente.PrimerApellido = txtPrimerApellido.Text;
            cliente.SegundoApellido = txtSegundoApellido.Text;
            cliente.Sexo = cboxSexo.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Ciudad = txtCiudad.Text;
            cliente.Barrio = txtBarrio.Text;
            cliente.Calle = txtCalle.Text;
            cliente.Carrera = txtCarrera.Text;
            cliente.Casa = txtCasa.Text;

            logProgram.agregar(cliente);
            MessageBox.Show("Cliente registrado correctamente");
            txtDocumento.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            cboxSexo.Text = "";
            txtTelefono.Clear();
            txtCiudad.Clear();
            txtBarrio.Clear();
            txtCalle.Clear();
            txtCarrera.Clear();
            txtCasa.Clear();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
