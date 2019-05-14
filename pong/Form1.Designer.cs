namespace pong
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
            this.components = new System.ComponentModel.Container();
            this.CPU = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerScore = new System.Windows.Forms.Label();
            this.CPUScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.SuspendLayout();
            // 
            // CPU
            // 
            this.CPU.BackColor = System.Drawing.Color.Fuchsia;
            this.CPU.Location = new System.Drawing.Point(897, 230);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(27, 127);
            this.CPU.TabIndex = 1;
            this.CPU.TabStop = false;
            this.CPU.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(434, 239);
            this.ball.Name = "Ball";
            this.ball.Size = new System.Drawing.Size(27, 26);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Yellow;
            this.Player1.Location = new System.Drawing.Point(12, 186);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(27, 127);
            this.Player1.TabIndex = 3;
            this.Player1.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.ForeColor = System.Drawing.Color.Lime;
            this.PlayerScore.Location = new System.Drawing.Point(105, 9);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(38, 25);
            this.PlayerScore.TabIndex = 4;
            this.PlayerScore.Text = "00";
            // 
            // CPUScore
            // 
            this.CPUScore.AutoSize = true;
            this.CPUScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUScore.ForeColor = System.Drawing.Color.Red;
            this.CPUScore.Location = new System.Drawing.Point(735, 9);
            this.CPUScore.Name = "CPUScore";
            this.CPUScore.Size = new System.Drawing.Size(38, 25);
            this.CPUScore.TabIndex = 5;
            this.CPUScore.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(928, 575);
            this.Controls.Add(this.CPUScore);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.CPU);
            this.Name = "Form1";
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CPU;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label CPUScore;
    }
}

