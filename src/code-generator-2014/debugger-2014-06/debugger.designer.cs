namespace CodeGenCS
{
    partial class debugger
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
            this.wrongs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // wrongs
            // 
            this.wrongs.BackColor = System.Drawing.Color.Black;
            this.wrongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrongs.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongs.ForeColor = System.Drawing.Color.White;
            this.wrongs.Location = new System.Drawing.Point(0, 0);
            this.wrongs.Name = "wrongs";
            this.wrongs.ReadOnly = true;
            this.wrongs.Size = new System.Drawing.Size(534, 149);
            this.wrongs.TabIndex = 0;
            this.wrongs.Text = "";            
            // 
            // debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 149);
            this.Controls.Add(this.wrongs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "debugger";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depurador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox wrongs;

    }
}