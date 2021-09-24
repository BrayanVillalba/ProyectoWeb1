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
    public partial class frmActEmpleado : Form
    {
        public frmActEmpleado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnActEmpleado_Click(object sender, EventArgs e)
        {
            if (logProgram.consultaEmple(txtDocu.Text) == null)
            {
                MessageBox.Show("--- ERROR --- Empleado no encontrado");
                txtCargo.Clear();
                txtTele.Clear();
                txtSalario.Clear();
                txtDocu.Focus();
            }
            else
            {
                List <String> lista = new List<string>();
                lista.Add(txtDocu.Text);
                lista.Add(txtTele.Text);
                lista.Add(txtCargo.Text);
                lista.Add(txtSalario.Text);
                logProgram.actualizarEmple(lista);
                MessageBox.Show("Empleado actualizado");
                txtDocu.Clear();
                txtCargo.Clear();
                txtTele.Clear();
                txtSalario.Clear();
                txtDocu.Focus();
            }
        }
    }
}
