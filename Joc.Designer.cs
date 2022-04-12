
namespace PingPong
{
    partial class Joc
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playerScore_lbl = new System.Windows.Forms.Label();
            this.cpuScore_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playerName_lbl = new System.Windows.Forms.Label();
            this.computerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-9, 601);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1054, 14);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 14);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Lime;
            this.player.Location = new System.Drawing.Point(2, 240);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(21, 109);
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cpu.Location = new System.Drawing.Point(1011, 240);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(21, 109);
            this.cpu.TabIndex = 7;
            this.cpu.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.Location = new System.Drawing.Point(495, 287);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(24, 21);
            this.ball.TabIndex = 8;
            this.ball.TabStop = false;
            // 
            // playerScore_lbl
            // 
            this.playerScore_lbl.AutoSize = true;
            this.playerScore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore_lbl.ForeColor = System.Drawing.Color.Lime;
            this.playerScore_lbl.Location = new System.Drawing.Point(431, 43);
            this.playerScore_lbl.Name = "playerScore_lbl";
            this.playerScore_lbl.Size = new System.Drawing.Size(62, 42);
            this.playerScore_lbl.TabIndex = 9;
            this.playerScore_lbl.Text = "00";
            // 
            // cpuScore_lbl
            // 
            this.cpuScore_lbl.AutoSize = true;
            this.cpuScore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScore_lbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.cpuScore_lbl.Location = new System.Drawing.Point(529, 43);
            this.cpuScore_lbl.Name = "cpuScore_lbl";
            this.cpuScore_lbl.Size = new System.Drawing.Size(62, 42);
            this.cpuScore_lbl.TabIndex = 10;
            this.cpuScore_lbl.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timerTick);
            // 
            // playerName_lbl
            // 
            this.playerName_lbl.AutoSize = true;
            this.playerName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName_lbl.ForeColor = System.Drawing.Color.Lime;
            this.playerName_lbl.Location = new System.Drawing.Point(299, 56);
            this.playerName_lbl.Name = "playerName_lbl";
            this.playerName_lbl.Size = new System.Drawing.Size(103, 20);
            this.playerName_lbl.TabIndex = 12;
            this.playerName_lbl.Text = "playerName";
            // 
            // computerName
            // 
            this.computerName.AutoSize = true;
            this.computerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerName.ForeColor = System.Drawing.Color.Fuchsia;
            this.computerName.Location = new System.Drawing.Point(616, 56);
            this.computerName.Name = "computerName";
            this.computerName.Size = new System.Drawing.Size(84, 20);
            this.computerName.TabIndex = 13;
            this.computerName.Text = "computer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(848, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "Inapoi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1032, 614);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computerName);
            this.Controls.Add(this.playerName_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpuScore_lbl);
            this.Controls.Add(this.playerScore_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Joc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label playerScore_lbl;
        private System.Windows.Forms.Label cpuScore_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label playerName_lbl;
        private System.Windows.Forms.Label computerName;
        private System.Windows.Forms.Label label1;
    }
}