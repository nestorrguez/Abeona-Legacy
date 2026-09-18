namespace CompÑ
{
    partial class ByR
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
            this.Search = new System.Windows.Forms.TextBox();
            this.Replace = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Label();
            this.Reemplazar = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(101, 29);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(278, 20);
            this.Search.TabIndex = 0;
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(101, 76);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(278, 20);
            this.Replace.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Buscar.Location = new System.Drawing.Point(25, 32);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(43, 13);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar:";
            // 
            // Reemplazar
            // 
            this.Reemplazar.AutoSize = true;
            this.Reemplazar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reemplazar.Location = new System.Drawing.Point(15, 79);
            this.Reemplazar.Name = "Reemplazar";
            this.Reemplazar.Size = new System.Drawing.Size(63, 26);
            this.Reemplazar.TabIndex = 3;
            this.Reemplazar.Text = "Reemplazar\r\n      por:";
            // 
            // Aceptar
            // 
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(350, 120);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(108, 27);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // ByR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(470, 159);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Reemplazar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Search);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(486, 197);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 197);
            this.Name = "ByR";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar y Reemplazar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.TextBox Replace;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.Label Reemplazar;
        private System.Windows.Forms.Button Aceptar;
    }
}