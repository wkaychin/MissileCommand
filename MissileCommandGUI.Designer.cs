namespace MissileCommandRun
{
    partial class MissileCommandGUI
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Player1Label = new System.Windows.Forms.Label();
            this.HiScoreLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(62, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 48);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(537, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 48);
            this.textBox2.TabIndex = 1;
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.ForeColor = System.Drawing.Color.Red;
            this.Player1Label.Location = new System.Drawing.Point(106, 75);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(93, 25);
            this.Player1Label.TabIndex = 3;
            this.Player1Label.Text = "Player 1";
            this.Player1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HiScoreLabel
            // 
            this.HiScoreLabel.AutoSize = true;
            this.HiScoreLabel.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.HiScoreLabel.Location = new System.Drawing.Point(581, 75);
            this.HiScoreLabel.Name = "HiScoreLabel";
            this.HiScoreLabel.Size = new System.Drawing.Size(90, 25);
            this.HiScoreLabel.TabIndex = 4;
            this.HiScoreLabel.Text = "Hi Score";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(951, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(855, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MissileCommandGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HiScoreLabel);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MissileCommandGUI";
            this.Text = "Missile Command Gameplay";
            this.Load += new System.EventHandler(this.MissileCommandGUI_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MissileCommandGUI_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MissileCommandGUI_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label HiScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

