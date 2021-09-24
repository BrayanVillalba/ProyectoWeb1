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
    public partial class frmRegProducto : Form
    {
        public frmRegProducto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsProducto pro = new clsProducto();
            pro.Codigo = Convert.ToInt32(txtCodigo.Text);
            pro.Nombre = txtNombre.Text;
            pro.Descripcion = tboxDesc.Text;
            pro.Precio = Convert.ToDouble(txtPrecio.Text);
            pro.Descuento = Convert.ToDouble(cboxDescuento.Text);

            logProgram.agregar(pro);
            MessageBox.Show("Producto registrado");

            txtCodigo.Clear();
            txtCodigo.Focus();
            txtNombre.Clear();
            tboxDesc.Clear();
            txtPrecio.Clear();
            cboxDescuento.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
