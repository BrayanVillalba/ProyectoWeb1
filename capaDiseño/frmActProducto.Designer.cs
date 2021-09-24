
namespace capaDiseño
{
    partial class frmActProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnACtProducto = new System.Windows.Forms.Button();
            this.cboxDescu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACTUALIZAR PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID DEL PRODUCTO QUE DESEA ACTUALIZAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUEVO PRECIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NUEVO %DESCUENTO";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(501, 145);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(173, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(426, 221);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(156, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // btnACtProducto
            // 
            this.btnACtProducto.Location = new System.Drawing.Point(382, 345);
            this.btnACtProducto.Name = "btnACtProducto";
            this.btnACtProducto.Size = new System.Drawing.Size(150, 49);
            this.btnACtProducto.TabIndex = 7;
            this.btnACtProducto.Text = "ACTUALIZAR";
            this.btnACtProducto.UseVisualStyleBackColor = true;
            this.btnACtProducto.Click += new System.EventHandler(this.btnACtProducto_Click);
            // 
            // cboxDescu
            // 
            this.cboxDescu.FormattingEnabled = true;
            this.cboxDescu.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.cboxDescu.Location = new System.Drawing.Point(426, 269);
            this.cboxDescu.Name = "cboxDescu";
            this.cboxDescu.Size = new System.Drawing.Size(156, 21);
            this.cboxDescu.TabIndex = 8;
            // 
            // frmActProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxDescu);
            this.Controls.Add(this.btnACtProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmActProducto";
            this.Text = "frmActProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnACtProducto;
        private System.Windows.Forms.ComboBox cboxDescu;
    }
}