
namespace PingPong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_lbl = new System.Windows.Forms.Label();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.multiplayer_btn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_lbl
            // 
            this.start_lbl.AutoSize = true;
            this.start_lbl.BackColor = System.Drawing.Color.Transparent;
            this.start_lbl.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_lbl.Location = new System.Drawing.Point(379, 68);
            this.start_lbl.Name = "start_lbl";
            this.start_lbl.Size = new System.Drawing.Size(501, 82);
            this.start_lbl.TabIndex = 0;
            this.start_lbl.Text = "Singleplayer";
            this.start_lbl.Click += new System.EventHandler(this.start_lbl_Click);
            this.start_lbl.MouseEnter += new System.EventHandler(this.start_lbl_MouseEnter);
            this.start_lbl.MouseLeave += new System.EventHandler(this.start_lbl_MouseLeave);
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.BackColor = System.Drawing.Color.Transparent;
            this.exit_lbl.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lbl.Location = new System.Drawing.Point(487, 529);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(209, 82);
            this.exit_lbl.TabIndex = 1;
            this.exit_lbl.Text = "Exit";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            this.exit_lbl.MouseEnter += new System.EventHandler(this.exit_lbl_MouseEnter);
            this.exit_lbl.MouseLeave += new System.EventHandler(this.exit_lbl_MouseLeave);
            // 
            // multiplayer_btn
            // 
            this.multiplayer_btn.AutoSize = true;
            this.multiplayer_btn.BackColor = System.Drawing.Color.Transparent;
            this.multiplayer_btn.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplayer_btn.Location = new System.Drawing.Point(404, 288);
            this.multiplayer_btn.Name = "multiplayer_btn";
            this.multiplayer_btn.Size = new System.Drawing.Size(476, 82);
            this.multiplayer_btn.TabIndex = 0;
            this.multiplayer_btn.Text = "Multiplayer";
            this.multiplayer_btn.Click += new System.EventHandler(this.multiplayer_btn_Click);
            this.multiplayer_btn.MouseEnter += new System.EventHandler(this.multiplayer_btn_MouseEnter);
            this.multiplayer_btn.MouseLeave += new System.EventHandler(this.multiplayer_btn_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 653);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.multiplayer_btn);
            this.Controls.Add(this.start_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label start_lbl;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Label multiplayer_btn;
    }
}

