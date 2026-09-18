namespace CompÑ
{
    partial class Ejemplos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejemplos));
            this.Panel = new System.Windows.Forms.Panel();
            this.Copiar = new System.Windows.Forms.Button();
            this.Texto_Ejemplo = new System.Windows.Forms.RichTextBox();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Copiar);
            this.Panel.Location = new System.Drawing.Point(1, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(628, 37);
            this.Panel.TabIndex = 0;
            // 
            // Copiar
            // 
            this.Copiar.Location = new System.Drawing.Point(7, 6);
            this.Copiar.Name = "Copiar";
            this.Copiar.Size = new System.Drawing.Size(75, 23);
            this.Copiar.TabIndex = 0;
            this.Copiar.Text = "Copiar";
            this.Copiar.UseVisualStyleBackColor = true;
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // Texto_Ejemplo
            // 
            this.Texto_Ejemplo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Texto_Ejemplo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Ejemplo.Location = new System.Drawing.Point(0, 38);
            this.Texto_Ejemplo.Name = "Texto_Ejemplo";
            this.Texto_Ejemplo.ReadOnly = true;
            this.Texto_Ejemplo.Size = new System.Drawing.Size(628, 410);
            this.Texto_Ejemplo.TabIndex = 1;
            this.Texto_Ejemplo.Text = "";
            // 
            // Ejemplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.Texto_Ejemplo);
            this.Controls.Add(this.Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejemplos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplos";
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button Copiar;
        public System.Windows.Forms.RichTextBox Texto_Ejemplo;
    }
}