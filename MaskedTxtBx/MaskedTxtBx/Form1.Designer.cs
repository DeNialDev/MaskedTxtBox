namespace MaskedTxtBx
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCambiarFecha = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mskTxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCambiarFecha
            // 
            this.btnCambiarFecha.Location = new System.Drawing.Point(26, 160);
            this.btnCambiarFecha.Name = "btnCambiarFecha";
            this.btnCambiarFecha.Size = new System.Drawing.Size(111, 23);
            this.btnCambiarFecha.TabIndex = 0;
            this.btnCambiarFecha.Text = "Cambiar Fecha";
            this.btnCambiarFecha.UseVisualStyleBackColor = true;
            this.btnCambiarFecha.Click += new System.EventHandler(this.btnCambiarFecha_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(23, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 23);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            // 
            // mskTxtFecha
            // 
            this.mskTxtFecha.Location = new System.Drawing.Point(179, 162);
            this.mskTxtFecha.Mask = "00/00/0000";
            this.mskTxtFecha.Name = "mskTxtFecha";
            this.mskTxtFecha.Size = new System.Drawing.Size(100, 20);
            this.mskTxtFecha.TabIndex = 2;
            this.mskTxtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 236);
            this.Controls.Add(this.mskTxtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnCambiarFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox mskTxtFecha;
    }
}

