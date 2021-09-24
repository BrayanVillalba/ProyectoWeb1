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
    public partial class frmActCliente : Form
    {
        public frmActCliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnActCliente_Click(object sender, EventArgs e)
        {
            if (logProgram.consultaCliente(txtDoc.Text) == null)
            {
                MessageBox.Show("--- ERROR --- Cliente no encontrado");
                txtTele.Clear();
                txtBarrio.Clear();
                txtCar.Clear();
                txtCalle.Clear();
                txtCasa.Clear();
                txtDoc.Focus();
            }
            else
            {
                List<String> lista = new List<string>();
                lista.Add(txtDoc.Text);
                lista.Add(txtTele.Text);
                lista.Add(txtBarrio.Text);
                lista.Add(txtCar.Text);
                lista.Add(txtCalle.Text);
                lista.Add(txtCasa.Text);
                logProgram.actualizarCliente(lista);
                MessageBox.Show("Cliente actualizado");
                txtDoc.Clear();
                txtTele.Clear();
                txtBarrio.Clear();
                txtCar.Clear();
                txtCalle.Clear();
                txtCasa.Clear();
                txtDoc.Focus();
            }
        }
    }
}
