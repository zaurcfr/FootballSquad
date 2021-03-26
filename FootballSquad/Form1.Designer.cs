
namespace FootballSquad
{
    partial class Form1
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
            this.countriesCmbbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FormationCmbbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.NumberLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PositionLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FormationFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.generateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FlagPctrbx = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPctrbx)).BeginInit();
            this.SuspendLayout();
            // 
            // countriesCmbbx
            // 
            this.countriesCmbbx.Animated = true;
            this.countriesCmbbx.AutoRoundedCorners = true;
            this.countriesCmbbx.BackColor = System.Drawing.Color.Transparent;
            this.countriesCmbbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.countriesCmbbx.BorderRadius = 17;
            this.countriesCmbbx.BorderThickness = 2;
            this.countriesCmbbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.countriesCmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countriesCmbbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countriesCmbbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countriesCmbbx.FocusedState.Parent = this.countriesCmbbx;
            this.countriesCmbbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.countriesCmbbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.countriesCmbbx.HoverState.Parent = this.countriesCmbbx;
            this.countriesCmbbx.ItemHeight = 30;
            this.countriesCmbbx.ItemsAppearance.Parent = this.countriesCmbbx;
            this.countriesCmbbx.Location = new System.Drawing.Point(75, 12);
            this.countriesCmbbx.Name = "countriesCmbbx";
            this.countriesCmbbx.ShadowDecoration.Parent = this.countriesCmbbx;
            this.countriesCmbbx.Size = new System.Drawing.Size(182, 36);
            this.countriesCmbbx.TabIndex = 0;
            this.countriesCmbbx.SelectedIndexChanged += new System.EventHandler(this.countriesCmbbx_SelectedIndexChanged);
            // 
            // FormationCmbbx
            // 
            this.FormationCmbbx.Animated = true;
            this.FormationCmbbx.AutoRoundedCorners = true;
            this.FormationCmbbx.BackColor = System.Drawing.Color.Transparent;
            this.FormationCmbbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormationCmbbx.BorderRadius = 17;
            this.FormationCmbbx.BorderThickness = 2;
            this.FormationCmbbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FormationCmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormationCmbbx.Enabled = false;
            this.FormationCmbbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FormationCmbbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FormationCmbbx.FocusedState.Parent = this.FormationCmbbx;
            this.FormationCmbbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormationCmbbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FormationCmbbx.HoverState.Parent = this.FormationCmbbx;
            this.FormationCmbbx.ItemHeight = 30;
            this.FormationCmbbx.Items.AddRange(new object[] {
            "3-5-2",
            "4-3-3",
            "4-4-2",
            "5-3-2"});
            this.FormationCmbbx.ItemsAppearance.Parent = this.FormationCmbbx;
            this.FormationCmbbx.Location = new System.Drawing.Point(333, 12);
            this.FormationCmbbx.Name = "FormationCmbbx";
            this.FormationCmbbx.ShadowDecoration.Parent = this.FormationCmbbx;
            this.FormationCmbbx.Size = new System.Drawing.Size(182, 36);
            this.FormationCmbbx.TabIndex = 1;
            this.FormationCmbbx.SelectedIndexChanged += new System.EventHandler(this.FormationCmbbx_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.NumberLbl);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.PositionLbl);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(558, 79);
            this.panel1.TabIndex = 2;
            // 
            // NumberLbl
            // 
            this.NumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.NumberLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.NumberLbl.Location = new System.Drawing.Point(385, 29);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(118, 25);
            this.NumberLbl.TabIndex = 2;
            this.NumberLbl.Text = "Player Number";
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.NameLbl.Location = new System.Drawing.Point(178, 29);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(101, 25);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Player Name";
            // 
            // PositionLbl
            // 
            this.PositionLbl.BackColor = System.Drawing.Color.Transparent;
            this.PositionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PositionLbl.Location = new System.Drawing.Point(43, 29);
            this.PositionLbl.Name = "PositionLbl";
            this.PositionLbl.Size = new System.Drawing.Size(64, 25);
            this.PositionLbl.TabIndex = 0;
            this.PositionLbl.Text = "Position";
            // 
            // FormationFLP
            // 
            this.FormationFLP.Location = new System.Drawing.Point(13, 152);
            this.FormationFLP.Name = "FormationFLP";
            this.FormationFLP.Size = new System.Drawing.Size(557, 520);
            this.FormationFLP.TabIndex = 3;
            // 
            // generateBtn
            // 
            this.generateBtn.Animated = true;
            this.generateBtn.AutoRoundedCorners = true;
            this.generateBtn.BorderRadius = 30;
            this.generateBtn.CheckedState.Parent = this.generateBtn;
            this.generateBtn.CustomImages.Parent = this.generateBtn;
            this.generateBtn.Enabled = false;
            this.generateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.HoverState.Parent = this.generateBtn;
            this.generateBtn.Location = new System.Drawing.Point(390, 678);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.ShadowDecoration.Parent = this.generateBtn;
            this.generateBtn.Size = new System.Drawing.Size(180, 63);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // FlagPctrbx
            // 
            this.FlagPctrbx.BackColor = System.Drawing.Color.Transparent;
            this.FlagPctrbx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FlagPctrbx.Location = new System.Drawing.Point(1, 1);
            this.FlagPctrbx.Name = "FlagPctrbx";
            this.FlagPctrbx.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.FlagPctrbx.ShadowDecoration.Parent = this.FlagPctrbx;
            this.FlagPctrbx.Size = new System.Drawing.Size(68, 66);
            this.FlagPctrbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlagPctrbx.TabIndex = 5;
            this.FlagPctrbx.TabStop = false;
            this.FlagPctrbx.UseTransparentBackground = true;
            this.FlagPctrbx.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(602, 753);
            this.Controls.Add(this.FlagPctrbx);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.FormationFLP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FormationCmbbx);
            this.Controls.Add(this.countriesCmbbx);
            this.MaximumSize = new System.Drawing.Size(620, 800);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPctrbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox countriesCmbbx;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel PositionLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel NumberLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel NameLbl;
        private System.Windows.Forms.FlowLayoutPanel FormationFLP;
        private Guna.UI2.WinForms.Guna2Button generateBtn;
        protected internal Guna.UI2.WinForms.Guna2ComboBox FormationCmbbx;
        private Guna.UI2.WinForms.Guna2CirclePictureBox FlagPctrbx;
    }
}

