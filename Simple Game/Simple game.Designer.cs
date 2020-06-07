namespace Simple_Game
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_shootAway = new System.Windows.Forms.Button();
            this.gamegif_PictureBox = new System.Windows.Forms.PictureBox();
            this.btn_Playagain = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Simple_Game = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamegif_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Maiandra GD", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Load.Location = new System.Drawing.Point(712, 109);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(100, 30);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.Font = new System.Drawing.Font("Maiandra GD", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_spin.Location = new System.Drawing.Point(713, 181);
            this.btn_spin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(100, 30);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // btn_shoot
            // 
            this.btn_shoot.Font = new System.Drawing.Font("Maiandra GD", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shoot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_shoot.Location = new System.Drawing.Point(714, 265);
            this.btn_shoot.Margin = new System.Windows.Forms.Padding(4);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(100, 30);
            this.btn_shoot.TabIndex = 2;
            this.btn_shoot.Text = "Shoot";
            this.btn_shoot.UseVisualStyleBackColor = true;
            this.btn_shoot.Click += new System.EventHandler(this.btn_shoot_Click);
            // 
            // btn_shootAway
            // 
            this.btn_shootAway.Font = new System.Drawing.Font("Maiandra GD", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shootAway.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_shootAway.Location = new System.Drawing.Point(717, 342);
            this.btn_shootAway.Margin = new System.Windows.Forms.Padding(4);
            this.btn_shootAway.Name = "btn_shootAway";
            this.btn_shootAway.Size = new System.Drawing.Size(100, 30);
            this.btn_shootAway.TabIndex = 3;
            this.btn_shootAway.Text = "Shoot Away";
            this.btn_shootAway.UseVisualStyleBackColor = true;
            this.btn_shootAway.Click += new System.EventHandler(this.btn_shootAway_Click);
            // 
            // gamegif_PictureBox
            // 
            this.gamegif_PictureBox.Location = new System.Drawing.Point(194, 99);
            this.gamegif_PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamegif_PictureBox.Name = "gamegif_PictureBox";
            this.gamegif_PictureBox.Size = new System.Drawing.Size(468, 279);
            this.gamegif_PictureBox.TabIndex = 4;
            this.gamegif_PictureBox.TabStop = false;
            // 
            // btn_Playagain
            // 
            this.btn_Playagain.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playagain.Location = new System.Drawing.Point(378, 453);
            this.btn_Playagain.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Playagain.Name = "btn_Playagain";
            this.btn_Playagain.Size = new System.Drawing.Size(169, 30);
            this.btn_Playagain.TabIndex = 5;
            this.btn_Playagain.Text = "Play Again";
            this.btn_Playagain.UseVisualStyleBackColor = true;
            this.btn_Playagain.Click += new System.EventHandler(this.btn_Playagain_Click);
            // 
            // Simple_Game
            // 
            this.Simple_Game.AutoSize = true;
            this.Simple_Game.Font = new System.Drawing.Font("Maiandra GD", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simple_Game.ForeColor = System.Drawing.Color.MediumBlue;
            this.Simple_Game.Location = new System.Drawing.Point(337, 38);
            this.Simple_Game.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Simple_Game.Name = "Simple_Game";
            this.Simple_Game.Size = new System.Drawing.Size(229, 42);
            this.Simple_Game.TabIndex = 8;
            this.Simple_Game.Text = "Simple Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(913, 509);
            this.Controls.Add(this.Simple_Game);
            this.Controls.Add(this.btn_Playagain);
            this.Controls.Add(this.gamegif_PictureBox);
            this.Controls.Add(this.btn_shootAway);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_Load);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Simple Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamegif_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_shootAway;
        private System.Windows.Forms.PictureBox gamegif_PictureBox;
        private System.Windows.Forms.Button btn_Playagain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Simple_Game;
    }
}

