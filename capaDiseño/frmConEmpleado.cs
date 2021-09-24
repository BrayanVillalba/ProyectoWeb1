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
    public partial class frmConEmpleado : Form
    {
        clsEmpleado resEmpleado;
        public frmConEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlBuscar_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(logProgram.consultaEmple(txtIdBuscar.Text) == null)
            {
                MessageBox.Show("Empleado no encontrado");
            }
            else
            {
                resEmpleado = logProgram.consultaEmple(txtIdBuscar.Text);
                txtDocumento.Text = resEmpleado.Documento;
                txtPrimerNombre.Text = resEmpleado.PrimerNombre;
                txtSegundoNombre.Text = resEmpleado.SegundoNombre;
                txtPrimerApellido.Text = resEmpleado.PrimerApellido;
                txtSegundoApellido.Text = resEmpleado.SegundoApellido;
                txtTelefono.Text = resEmpleado.Telefono;
                txtSexo.Text = resEmpleado.Sexo;
                txtCargo.Text = resEmpleado.Cargo;
                txtSalario.Text = resEmpleado.Salario;
            }
            
            
            
        }
        
        private void lisViewEpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
