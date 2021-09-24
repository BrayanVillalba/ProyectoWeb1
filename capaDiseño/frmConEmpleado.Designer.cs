
namespace capaDiseño
{
    partial class frmConEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdBuscar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.pnlBuscar.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID A BUSCAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdBuscar
            // 
            this.txtIdBuscar.Location = new System.Drawing.Point(121, 37);
            this.txtIdBuscar.Name = "txtIdBuscar";
            this.txtIdBuscar.Size = new System.Drawing.Size(180, 20);
            this.txtIdBuscar.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(384, 26);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 40);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.txtSexo);
            this.pnlBuscar.Controls.Add(this.txtSalario);
            this.pnlBuscar.Controls.Add(this.txtCargo);
            this.pnlBuscar.Controls.Add(this.label9);
            this.pnlBuscar.Controls.Add(this.label8);
            this.pnlBuscar.Controls.Add(this.label7);
            this.pnlBuscar.Controls.Add(this.txtTelefono);
            this.pnlBuscar.Controls.Add(this.txtSegundoApellido);
            this.pnlBuscar.Controls.Add(this.txtPrimerApellido);
            this.pnlBuscar.Controls.Add(this.txtSegundoNombre);
            this.pnlBuscar.Controls.Add(this.txtPrimerNombre);
            this.pnlBuscar.Controls.Add(this.txtDocumento);
            this.pnlBuscar.Controls.Add(this.label6);
            this.pnlBuscar.Controls.Add(this.label5);
            this.pnlBuscar.Controls.Add(this.label4);
            this.pnlBuscar.Controls.Add(this.label3);
            this.pnlBuscar.Controls.Add(this.label2);
            this.pnlBuscar.Controls.Add(this.label10);
            this.pnlBuscar.Location = new System.Drawing.Point(12, 140);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(518, 345);
            this.pnlBuscar.TabIndex = 3;
            this.pnlBuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBuscar_Paint);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.txtIdBuscar);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.btnConsultar);
            this.pnl1.Location = new System.Drawing.Point(12, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(518, 100);
            this.pnl1.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSalario.Location = new System.Drawing.Point(219, 319);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(161, 20);
            this.txtSalario.TabIndex = 57;
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCargo.Location = new System.Drawing.Point(219, 282);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(161, 20);
            this.txtCargo.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "Salario";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Cargo";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Sexo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTelefono.Location = new System.Drawing.Point(219, 205);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(161, 20);
            this.txtTelefono.TabIndex = 52;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSegundoApellido.Location = new System.Drawing.Point(219, 166);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(161, 20);
            this.txtSegundoApellido.TabIndex = 51;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrimerApellido.Location = new System.Drawing.Point(219, 125);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(161, 20);
            this.txtPrimerApellido.TabIndex = 50;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSegundoNombre.Location = new System.Drawing.Point(219, 86);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(161, 20);
            this.txtSegundoNombre.TabIndex = 49;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrimerNombre.Location = new System.Drawing.Point(219, 47);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(161, 20);
            this.txtPrimerNombre.TabIndex = 48;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDocumento.Location = new System.Drawing.Point(219, 9);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(161, 20);
            this.txtDocumento.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Primer Nombre";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "Documento";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(219, 245);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(161, 20);
            this.txtSexo.TabIndex = 58;
            // 
            // frmConEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 497);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnlBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConEmpleado";
            this.Text = "frmConEmpleado";
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdBuscar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}