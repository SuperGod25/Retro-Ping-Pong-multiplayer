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
    public partial class Joc : Form
    {
        bool up, down;
        float speed = 10f;
        
        float ballPosX = 6, ballPosY = 6;
        int playerScore = 0, cpuScore = 0;
        string input = Microsoft.VisualBasic.Interaction.InputBox("Ping Pong", "Introduceti-va numele de jucator"," ",800,192);
        public Joc()
        {
            InitializeComponent();
            if(input==" ")
            {
                input = "unknown";
                
            }
            else 
                playerName_lbl.Text = input;
           
            
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font("Snap ITC", 36);
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

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                up = true;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                down = true;
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                down = false;
        }

        private void timerTick(object sender, EventArgs e)
        {
            playerScore_lbl.Text = ""+ playerScore;
            cpuScore_lbl.Text = "" + cpuScore;

            ball.Top -= (int)ballPosY;
            ball.Left -= (int)ballPosX;

            cpu.Top+=(int)speed;
            
            
            if (playerScore < 20)
            {

                if (cpu.Top < 0 || cpu.Top > 495)///computer ul a ajuns la marginile ecranului
                {
                    speed = - speed;///schimba directia de deplasare
                }
            }
            else
            {
                cpu.Top =ball.Top;///daca scorul este mai mare de 5, se schimba dificultatea
                ///astfel incat computerul urmareste mingea pentru a nu o rata
            }

           

            ///daca mingea ajunge dupa jucator
            if (ball.Left < 0)
            {
                ball.Left = 495;
                ballPosX = -ballPosX;
                ballPosX-=1;
                cpuScore++;
            }

            ///daca mingea ajunge dupa computer
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 495;
                ballPosX = -ballPosX;
                ballPosX += 1;
                playerScore++;
            }
            ///daca mingea atinge extremitatile ecranului nu va iesi din ecran
            if(ball.Top<0 || ball.Top+ball.Height>ClientSize.Height)
            {
                ballPosY = -ballPosY;

            }

            ///coliziunea intre minge si jucator/cpu
            if(ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballPosX = -ballPosX;
              
            }

            if (up == true && player.Top > 0)
            {
                player.Top -= 8;
            }

            if (down == true && player.Top<495)
            {
                player.Top += 8;
            }

            if(playerScore>20)
            {
                timer1.Stop();
                DialogResult dg=MessageBox.Show("Ai castigat! Daca vrei sa joci din nou apasa butonul YES, altfel, " +
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
            if (cpuScore > 20)
            {
                timer1.Stop();
                DialogResult dg = MessageBox.Show("Computer-ul a castigat! Daca vrei sa joci din nou apasa butonul YES, altfel, " +
                     "apasa butonul NO", "LoseMessage", MessageBoxButtons.YesNo);
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
    }
}
