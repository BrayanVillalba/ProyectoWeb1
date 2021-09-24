using System;
using System.Windows.Forms;
using capaEntidades;
using capaLogica;

namespace capaDiseño
{
    public partial class frmRegEmpleado : Form
    {
        
        public frmRegEmpleado()
        {
            InitializeComponent();
        }
        
        private void frmRegEmpleado_Load(object sender, EventArgs e)
        {

        }
        
        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            clsEmpleado emple = new clsEmpleado();
            emple.Documento = txtDocumento.Text;
            emple.PrimerNombre = txtPrimerNombre.Text;
            emple.SegundoNombre = txtSegundoNombre.Text;
            emple.PrimerApellido = txtPrimerApellido.Text;
            emple.SegundoApellido = txtSegundoApellido.Text;
            emple.Telefono = txtTelefono.Text;
            emple.Sexo = cboxSexo.Text;
            emple.Cargo = txtCargo.Text;
            emple.Salario = txtSalario.Text;

            logProgram.agregar(emple);
            
            MessageBox.Show("Empleado registrado correctamente");
            txtDocumento.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            cboxSexo.Text = "";
            txtTelefono.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
