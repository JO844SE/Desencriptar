namespace Desencriptar
{
    partial class Desencriptar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desencriptar));
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btndescript = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(338, 341);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(134, 37);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Red;
            this.lbltitulo.Location = new System.Drawing.Point(360, 246);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(91, 20);
            this.lbltitulo.TabIndex = 10;
            this.lbltitulo.Text = "Resultado";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndescript
            // 
            this.btndescript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescript.Location = new System.Drawing.Point(338, 149);
            this.btndescript.Name = "btndescript";
            this.btndescript.Size = new System.Drawing.Size(134, 37);
            this.btndescript.TabIndex = 8;
            this.btndescript.Text = "Encriptar";
            this.btndescript.UseVisualStyleBackColor = true;
            this.btndescript.Click += new System.EventHandler(this.btndescript_Click);
            // 
            // txtclave
            // 
            this.txtclave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtclave.Location = new System.Drawing.Point(279, 112);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(253, 20);
            this.txtclave.TabIndex = 7;
            this.txtclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese la clave que desea encriptar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblresultado
            // 
            this.lblresultado.Location = new System.Drawing.Point(219, 289);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(373, 20);
            this.lblresultado.TabIndex = 12;
            this.lblresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Desencriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btndescript);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Desencriptar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt";
            this.Load += new System.EventHandler(this.Desencriptar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btndescript;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblresultado;
    }
}