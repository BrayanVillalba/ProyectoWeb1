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
    public partial class frmElimCliente : Form
    {
        public frmElimCliente()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (logProgram.consultaCliente(txtCed.Text) != null)
            {
                logProgram.eliminarCliente(txtCed.Text);
                MessageBox.Show("Cliente eliminado");
            }
            else
            {
                MessageBox.Show("Cliente no existe");
            }
        }
    }
}
