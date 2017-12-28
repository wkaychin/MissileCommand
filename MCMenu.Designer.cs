namespace MissileCommandRun
{
    partial class MCMenu
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
            this.EasyMode = new System.Windows.Forms.Label();
            this.UnlimitedMissilesMode = new System.Windows.Forms.Label();
            this.MediumMode = new System.Windows.Forms.Label();
            this.HardMode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MissileCommandPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MissileCommandPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EasyMode
            // 
            this.EasyMode.BackColor = System.Drawing.Color.Cyan;
            this.EasyMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EasyMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EasyMode.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyMode.ForeColor = System.Drawing.Color.Red;
            this.EasyMode.Location = new System.Drawing.Point(104, 640);
            this.EasyMode.Name = "EasyMode";
            this.EasyMode.Size = new System.Drawing.Size(396, 43);
            this.EasyMode.TabIndex = 0;
            this.EasyMode.Text = "Easy ";
            this.EasyMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EasyMode.Click += new System.EventHandler(this.label1_Click);
            // 
            // UnlimitedMissilesMode
            // 
            this.UnlimitedMissilesMode.BackColor = System.Drawing.Color.Yellow;
            this.UnlimitedMissilesMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnlimitedMissilesMode.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlimitedMissilesMode.ForeColor = System.Drawing.Color.Red;
            this.UnlimitedMissilesMode.Location = new System.Drawing.Point(104, 585);
            this.UnlimitedMissilesMode.Name = "UnlimitedMissilesMode";
            this.UnlimitedMissilesMode.Size = new System.Drawing.Size(396, 42);
            this.UnlimitedMissilesMode.TabIndex = 1;
            this.UnlimitedMissilesMode.Text = "Unlimited Missiles ";
            this.UnlimitedMissilesMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UnlimitedMissilesMode.Click += new System.EventHandler(this.UnlimitedMissilesMode_Click);
            // 
            // MediumMode
            // 
            this.MediumMode.BackColor = System.Drawing.Color.Lime;
            this.MediumMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MediumMode.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumMode.ForeColor = System.Drawing.Color.Red;
            this.MediumMode.Location = new System.Drawing.Point(104, 695);
            this.MediumMode.Name = "MediumMode";
            this.MediumMode.Size = new System.Drawing.Size(396, 43);
            this.MediumMode.TabIndex = 2;
            this.MediumMode.Text = "Medium";
            this.MediumMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MediumMode.Click += new System.EventHandler(this.MediumMode_Click);
            // 
            // HardMode
            // 
            this.HardMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HardMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HardMode.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardMode.ForeColor = System.Drawing.Color.Red;
            this.HardMode.Location = new System.Drawing.Point(104, 754);
            this.HardMode.Name = "HardMode";
            this.HardMode.Size = new System.Drawing.Size(396, 43);
            this.HardMode.TabIndex = 3;
            this.HardMode.Text = "Hard";
            this.HardMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HardMode.Click += new System.EventHandler(this.HardMode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(198, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 45);
            this.label5.TabIndex = 5;
            this.label5.Text = "Welcome to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(101, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "Choose your gameplay:";
            // 
            // MissileCommandPicBox
            // 
            this.MissileCommandPicBox.BackgroundImage = global::MissileCommandRun.Properties.Resources.ms_menu2;
            this.MissileCommandPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MissileCommandPicBox.Location = new System.Drawing.Point(12, 126);
            this.MissileCommandPicBox.Name = "MissileCommandPicBox";
            this.MissileCommandPicBox.Size = new System.Drawing.Size(618, 353);
            this.MissileCommandPicBox.TabIndex = 4;
            this.MissileCommandPicBox.TabStop = false;
            this.MissileCommandPicBox.Click += new System.EventHandler(this.MissileCommandPicBox_Click);
            // 
            // MCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(631, 878);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MissileCommandPicBox);
            this.Controls.Add(this.HardMode);
            this.Controls.Add(this.MediumMode);
            this.Controls.Add(this.UnlimitedMissilesMode);
            this.Controls.Add(this.EasyMode);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MCMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MCMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MissileCommandPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EasyMode;
        private System.Windows.Forms.Label UnlimitedMissilesMode;
        private System.Windows.Forms.Label MediumMode;
        private System.Windows.Forms.Label HardMode;
        private System.Windows.Forms.PictureBox MissileCommandPicBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}