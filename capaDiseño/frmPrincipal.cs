using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDiseño
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
        private void personalizarDiseño()
        {
            pnlSubRegistrar.Visible = false;
            pnlSubActualizar.Visible = false;
            pnlSubConsultar.Visible = false;
            pnlSubEliminar.Visible = false;

        }
        public void ocultarSubmenu()
        {
            if (pnlSubRegistrar.Visible)
                pnlSubRegistrar.Visible = false;
            if (pnlSubActualizar.Visible)
                pnlSubActualizar.Visible = false;
            if (pnlSubConsultar.Visible)
                pnlSubConsultar.Visible = false;
            if (pnlSubEliminar.Visible)
                pnlSubEliminar.Visible = false;
        }
        public void mostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //si hay un submenu abierto lo cierra
                ocultarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubRegistrar);
        }
        #region Registrar
        private void btnRegEmpleado_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmRegEmpleado());
            ocultarSubmenu();
        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmRegCliente());
            ocultarSubmenu();
        }

        private void btnRegProducto_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmRegProducto());
            ocultarSubmenu();
        }
#endregion
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubActualizar);
        }
        #region Actualizar
        private void btnActEmpleado_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmActEmpleado());
            ocultarSubmenu();
        }

        private void btnActCliente_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmActCliente());
            ocultarSubmenu();
        }

        private void btnActProducto_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmActProducto());
            ocultarSubmenu();
        }
#endregion
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubConsultar);
        }
        #region Consultar
        private void btnConEmpleado_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmConEmpleado());
            ocultarSubmenu();
        }

        private void btnConCliente_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmConCliente());
            ocultarSubmenu();
        }

        private void btnConProducto_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmConProducto());
            ocultarSubmenu();
        }
#endregion
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubEliminar);
        }
        #region Eliminar
        private void btnEliEmpleado_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmElimEmpleado());
            ocultarSubmenu();
        }

        private void btnEliCliente_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmElimCliente());
            ocultarSubmenu();
        }

        private void btnEliProducto_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormHijos(new frmElimProducto());
            ocultarSubmenu();
        }
        #endregion
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form forActivo = null;
        private void abrirFormHijos(Form forHijo)
        {
            if(forActivo != null)
            {
                forActivo.Close();
            }
            forActivo = forHijo;
            forHijo.TopLevel = false; //se comporta igual que un control (no es de nivel superior)
            forHijo.FormBorderStyle = FormBorderStyle.None;//quitar bordes
            forHijo.Dock = DockStyle.Fill;//rellenar todo el panel contenedor
            pnlContenedor.Controls.Add(forHijo);
            pnlContenedor.Tag = forHijo;
            forHijo.BringToFront();//traer al frente
            forHijo.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
