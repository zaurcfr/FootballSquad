
namespace FootballSquad
{
    partial class UCShirt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerNameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PlayerNumberLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // PlayerNameLbl
            // 
            this.PlayerNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.PlayerNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLbl.ForeColor = System.Drawing.Color.White;
            this.PlayerNameLbl.Location = new System.Drawing.Point(26, 13);
            this.PlayerNameLbl.Name = "PlayerNameLbl";
            this.PlayerNameLbl.Size = new System.Drawing.Size(49, 25);
            this.PlayerNameLbl.TabIndex = 0;
            this.PlayerNameLbl.Text = "Name";
            // 
            // PlayerNumberLbl
            // 
            this.PlayerNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.PlayerNumberLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNumberLbl.ForeColor = System.Drawing.Color.White;
            this.PlayerNumberLbl.Location = new System.Drawing.Point(43, 35);
            this.PlayerNumberLbl.Name = "PlayerNumberLbl";
            this.PlayerNumberLbl.Size = new System.Drawing.Size(15, 30);
            this.PlayerNumberLbl.TabIndex = 1;
            this.PlayerNumberLbl.Text = "0";
            // 
            // UCShirt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FootballSquad.Properties.Resources.football_jersey;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PlayerNumberLbl);
            this.Controls.Add(this.PlayerNameLbl);
            this.DoubleBuffered = true;
            this.Name = "UCShirt";
            this.Size = new System.Drawing.Size(101, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel PlayerNameLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel PlayerNumberLbl;
    }
}
