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
    public partial class frmConCliente : Form
    {
        clsCliente res;
        public frmConCliente()
        {
            InitializeComponent();
        }

        private void btnConCliente_Click(object sender, EventArgs e)
        {
            if (logProgram.consultaCliente(txtIdBuscar.Text) == null)
            {
                MessageBox.Show("Cliente no encontrado");
            }
            else
            {
                res = logProgram.consultaCliente(txtIdBuscar.Text);
                txtPrimerNombre.Text = res.PrimerNombre;
                txtSegundoNombre.Text = res.SegundoNombre;
                txtPrimerApellido.Text = res.PrimerApellido;
                txtSegundoApellido.Text = res.SegundoApellido;
                txtTelefono.Text = res.Telefono;
                txtSexo.Text = res.Sexo;
                txtCiudad.Text = res.Ciudad;
                txtBarrio.Text = res.Barrio;
                txtCalle.Text = res.Calle;
                txtCarrera.Text = res.Carrera;
                txtCasa.Text = res.Casa;
            }
        }

        private void pnlBuscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConCliente_Click_1(object sender, EventArgs e)
        {
            if (logProgram.consultaCliente(txtIdBuscar.Text) == null)
            {
                MessageBox.Show("Cliente no encontrado");
            }
            else
            {
                res = logProgram.consultaCliente(txtIdBuscar.Text);
                txtPrimerNombre.Text = res.PrimerNombre;
                txtSegundoNombre.Text = res.SegundoNombre;
                txtPrimerApellido.Text = res.PrimerApellido;
                txtSegundoApellido.Text = res.SegundoApellido;
                txtTelefono.Text = res.Telefono;
                txtSexo.Text = res.Sexo;
                txtCiudad.Text = res.Ciudad;
                txtBarrio.Text = res.Barrio;
                txtCalle.Text = res.Calle;
                txtCarrera.Text = res.Carrera;
                txtCasa.Text = res.Casa;
            }
        }
    }
}
