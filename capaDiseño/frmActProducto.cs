using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogica;
using capaEntidades;

namespace capaDiseño
{
    public partial class frmActProducto : Form
    {
        public frmActProducto()
        {
            InitializeComponent();
        }

        private void btnACtProducto_Click(object sender, EventArgs e)
        {
            if (logProgram.consultaPro(Convert.ToInt32(txtId.Text)) == null)
            {
                MessageBox.Show("--- ERROR --- Producto no encontrado");
                cboxDescu.Text="";
                txtPrecio.Clear();
                txtId.Focus();
            }
            else
            {
                List<String> lista = new List<string>();
                lista.Add(txtId.Text);
                lista.Add(txtPrecio.Text);
                lista.Add(cboxDescu.Text);
                logProgram.actualizarProd (lista);
                MessageBox.Show("Producto actualizado");
                txtId.Clear();
                cboxDescu.Text="";
                txtPrecio.Clear();
                txtId.Focus();
            }
        }
    }
}
