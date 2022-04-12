
namespace PingPong
{
    partial class Multiplayer
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
            this.ball = new System.Windows.Forms.PictureBox();
            this.player2Bar = new System.Windows.Forms.PictureBox();
            this.player1Bar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.player2Score_lbl = new System.Windows.Forms.Label();
            this.player1Score_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.player2Name_lbl = new System.Windows.Forms.Label();
            this.player1Name_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.Location = new System.Drawing.Point(485, 268);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(24, 21);
            this.ball.TabIndex = 19;
            this.ball.TabStop = false;
            // 
            // player2Bar
            // 
            this.player2Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.player2Bar.Location = new System.Drawing.Point(1001, 221);
            this.player2Bar.Name = "player2Bar";
            this.player2Bar.Size = new System.Drawing.Size(21, 109);
            this.player2Bar.TabIndex = 18;
            this.player2Bar.TabStop = false;
            // 
            // player1Bar
            // 
            this.player1Bar.BackColor = System.Drawing.Color.Lime;
            this.player1Bar.Location = new System.Drawing.Point(-8, 221);
            this.player1Bar.Name = "player1Bar";
            this.player1Bar.Size = new System.Drawing.Size(21, 109);
            this.player1Bar.TabIndex = 17;
            this.player1Bar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-24, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 14);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 562);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1054, 14);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 55);
            this.label2.TabIndex = 22;
            this.label2.Text = "-";
            // 
            // player2Score_lbl
            // 
            this.player2Score_lbl.AutoSize = true;
            this.player2Score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score_lbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.player2Score_lbl.Location = new System.Drawing.Point(519, 24);
            this.player2Score_lbl.Name = "player2Score_lbl";
            this.player2Score_lbl.Size = new System.Drawing.Size(62, 42);
            this.player2Score_lbl.TabIndex = 21;
            this.player2Score_lbl.Text = "00";
            // 
            // player1Score_lbl
            // 
            this.player1Score_lbl.AutoSize = true;
            this.player1Score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score_lbl.ForeColor = System.Drawing.Color.Lime;
            this.player1Score_lbl.Location = new System.Drawing.Point(421, 24);
            this.player1Score_lbl.Name = "player1Score_lbl";
            this.player1Score_lbl.Size = new System.Drawing.Size(62, 42);
            this.player1Score_lbl.TabIndex = 20;
            this.player1Score_lbl.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(838, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 48);
            this.label1.TabIndex = 25;
            this.label1.Text = "Inapoi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // player2Name_lbl
            // 
            this.player2Name_lbl.AutoSize = true;
            this.player2Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name_lbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.player2Name_lbl.Location = new System.Drawing.Point(606, 37);
            this.player2Name_lbl.Name = "player2Name_lbl";
            this.player2Name_lbl.Size = new System.Drawing.Size(113, 20);
            this.player2Name_lbl.TabIndex = 24;
            this.player2Name_lbl.Text = "player2Name";
            // 
            // player1Name_lbl
            // 
            this.player1Name_lbl.AutoSize = true;
            this.player1Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name_lbl.ForeColor = System.Drawing.Color.Lime;
            this.player1Name_lbl.Location = new System.Drawing.Point(289, 37);
            this.player1Name_lbl.Name = "player1Name_lbl";
            this.player1Name_lbl.Size = new System.Drawing.Size(113, 20);
            this.player1Name_lbl.TabIndex = 23;
            this.player1Name_lbl.Text = "player1Name";
            // 
            // Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1016, 575);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player2Bar);
            this.Controls.Add(this.player1Bar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player2Score_lbl);
            this.Controls.Add(this.player1Score_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2Name_lbl);
            this.Controls.Add(this.player1Name_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Multiplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplayer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Multiplayer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Multiplayer_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player2Bar;
        private System.Windows.Forms.PictureBox player1Bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player2Score_lbl;
        private System.Windows.Forms.Label player1Score_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player2Name_lbl;
        private System.Windows.Forms.Label player1Name_lbl;
    }
}