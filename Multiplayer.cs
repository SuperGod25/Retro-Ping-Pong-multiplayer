using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Multiplayer : Form
    {

        public bool up1, down1, up2, down2;
        

        float ballPosX = 10, ballPosY = 10;
        int player1Score = 0, player2Score = 0;
        public string playerName1 = Microsoft.VisualBasic.Interaction.InputBox("Ping Pong", "Introduceti-va numele de jucator", " ", 800, 192);
        public string playerName2 = Microsoft.VisualBasic.Interaction.InputBox("Ping Pong", "Introduceti-va numele de jucator", " ", 800, 192);
        public Multiplayer()
        {
            InitializeComponent();
            player1Name_lbl.Text = playerName1;
            player2Name_lbl.Text = playerName2;
        }

        
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font("Snap ITC", 28);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Doresti sa parasesti jocul?", "Chiar vrei sa iesi?", MessageBoxButtons.OKCancel);
            if (dg == DialogResult.OK)
            {
                Form1 menuScreen = new Form1();
                this.Hide();
                menuScreen.Closed += (s, args) => this.Close();
                menuScreen.Show();
            }
        }

        
        

        private void Multiplayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                up2 = true;
            if (e.KeyCode == Keys.Down)
                down2 = true;
            if (e.KeyCode == Keys.W)
                up1 = true;
            if (e.KeyCode == Keys.S)
                down1 = true;
        }

        private void Multiplayer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                up1 = false;
            if (e.KeyCode == Keys.S)
                down1 = false;
            if (e.KeyCode == Keys.Up)
                up2 = false;
            if (e.KeyCode == Keys.Down)
                down2 = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player1Score_lbl.Text = "" + player1Score;
            player2Score_lbl.Text = "" + player2Score;

            ball.Top -= (int)ballPosY;
            ball.Left -= (int)ballPosX;

            
            

            



            ///daca mingea ajunge dupa jucatorul 1
            if (ball.Left < 0)
            {
                ball.Left = 495;
                ballPosX = -ballPosX;
                ballPosX -= 1;
                player2Score++;
            }

            ///daca mingea ajunge dupa jucatorul 2
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 495;
                ballPosX = -ballPosX;
                ballPosX += 1;
                player1Score++;
            }
            ///daca mingea atinge extremitatile ecranului nu va iesi din ecran
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                ballPosY = -ballPosY;

            }

            ///coliziunea intre minge si jucator1/jucator2
            if (ball.Bounds.IntersectsWith(player1Bar.Bounds) || ball.Bounds.IntersectsWith(player2Bar.Bounds))
            {
                ballPosX = -ballPosX;

            }

            if (up1 == true && player1Bar.Top > 0)
            {
                player1Bar.Top -= 10;
            }
            if(up2==true && player2Bar.Top > 0)
            {
                player2Bar.Top -= 10;
            }
            

            if (down1 == true && player1Bar.Top < 495)
            {
                player1Bar.Top += 10;
            }

            if(down2==true && player2Bar.Top<495)
            {
                player2Bar.Top += 10;
            }

            if (player1Score==30)
            {
                timer1.Stop();
                
                
                    DialogResult dg = MessageBox.Show(player1Name_lbl.Text + " a castigat! Daca vrei sa joci din nou apasa butonul YES, altfel, " +
                        "apasa butonul NO", "WinMessage", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        Joc joc = new Joc();
                        this.Hide();
                        joc.Closed += (s, args) => this.Close();
                        joc.Show();
                    }
                    else if (dg == DialogResult.No)
                    {
                        Form1 menuScreen = new Form1();
                        this.Hide();
                        menuScreen.Closed += (s, args) => this.Close();
                        menuScreen.Show();
                    }
                
            }
            if (player2Score==30)
            {
                timer1.Stop();
                DialogResult dg = MessageBox.Show(player2Name_lbl.Text+" a castigat! Daca vrei sa joci din nou apasa butonul YES, altfel, " +
                     "apasa butonul NO", "WinMessage", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    Joc joc = new Joc();
                    this.Hide();
                    joc.Closed += (s, args) => this.Close();
                    joc.Show();
                }
                else if (dg == DialogResult.No)
                {
                    Form1 menuScreen = new Form1();
                    this.Hide();
                    menuScreen.Closed += (s, args) => this.Close();
                    menuScreen.Show();
                }

            }


        
    }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font("Snap ITC", 36);
        }

        
    }
}
