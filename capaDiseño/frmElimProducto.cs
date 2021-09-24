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
    public partial class frmElimProducto : Form
    {
        public frmElimProducto()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsProducto p = logProgram.consultaPro(Convert.ToInt32(txtCodigo.Text));
            if (p != null) { 
                logProgram.eliminarPro(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show("Producto eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Producto no existe");
            }
        }
    }
}
