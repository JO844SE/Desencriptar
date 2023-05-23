namespace Desencriptar
{
    partial class Decrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decrypt));
            this.label1 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btndescript = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la clave encriptada";
            // 
            // txtclave
            // 
            this.txtclave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtclave.Location = new System.Drawing.Point(246, 125);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(253, 20);
            this.txtclave.TabIndex = 1;
            this.txtclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndescript
            // 
            this.btndescript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescript.Location = new System.Drawing.Point(305, 162);
            this.btndescript.Name = "btndescript";
            this.btndescript.Size = new System.Drawing.Size(134, 37);
            this.btndescript.TabIndex = 2;
            this.btndescript.Text = "Desencriptar";
            this.btndescript.UseVisualStyleBackColor = true;
            this.btndescript.Click += new System.EventHandler(this.btndescript_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(184, 296);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(376, 23);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Red;
            this.lbltitulo.Location = new System.Drawing.Point(327, 259);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(91, 20);
            this.lbltitulo.TabIndex = 4;
            this.lbltitulo.Text = "Resultado";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(305, 364);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(134, 37);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btndescript);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Decrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btndescript;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

