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
    public partial class frmElimEmpleado : Form
    {
        public frmElimEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (logProgram.consultaEmple(txtCed.Text) != null){
                logProgram.eliminarEmple(txtCed.Text);
                MessageBox.Show("Empleado eliminado");
            }
            else
            {
                MessageBox.Show("Empleado no existe");
            }
        }
    }
}
