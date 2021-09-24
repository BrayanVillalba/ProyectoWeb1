
namespace capaDiseño
{
    partial class frmActEmpleado
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnActEmpleado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVO TELEFONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUEVO SALARIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NUEVO CARGO";
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(433, 186);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(141, 20);
            this.txtTele.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(433, 248);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(141, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(433, 216);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(141, 20);
            this.txtCargo.TabIndex = 6;
            // 
            // btnActEmpleado
            // 
            this.btnActEmpleado.Location = new System.Drawing.Point(404, 306);
            this.btnActEmpleado.Name = "btnActEmpleado";
            this.btnActEmpleado.Size = new System.Drawing.Size(110, 43);
            this.btnActEmpleado.TabIndex = 7;
            this.btnActEmpleado.Text = "ACTUALIZAR";
            this.btnActEmpleado.UseVisualStyleBackColor = true;
            this.btnActEmpleado.Click += new System.EventHandler(this.btnActEmpleado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ACTUALIZAR EMPLEADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DOCUMENTO DE EMPLEADO QUE DESEA ACTUALIZAR";
            // 
            // txtDocu
            // 
            this.txtDocu.Location = new System.Drawing.Point(506, 123);
            this.txtDocu.Name = "txtDocu";
            this.txtDocu.Size = new System.Drawing.Size(162, 20);
            this.txtDocu.TabIndex = 10;
            // 
            // frmActEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDocu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActEmpleado);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmActEmpleado";
            this.Text = "frmActEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnActEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocu;
    }
}