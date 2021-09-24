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
    public partial class frmConProducto : Form
    {
        clsProducto producto;
        public frmConProducto()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            producto = logProgram.consultaPro(Convert.ToInt32(txtCodigo.Text));
            if(producto == null)
            {
                MessageBox.Show("Producto no encontrado");
            }
            else
            {
                txtNombre.Text = producto.Nombre;
                tboxDesc.Text = producto.Descripcion;
                txtPrecio.Text = producto.Precio.ToString();
                txtDesc.Text = producto.Descuento.ToString();
            }
        }
    }
}
