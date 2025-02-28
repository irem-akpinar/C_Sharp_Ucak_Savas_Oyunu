using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Ucak_Savasi
{
    public partial class Form1 : Form
    {
        bool solaGit, sagaGit, atis, isGameOver;
        int skor;
        int playerHizi = 12;
        int dusmanHizi;
        int mermiHizi;


        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            lbl_skor.Text = skor.ToString();

            dusman_1.Top += dusmanHizi;
            dusman_2.Top += dusmanHizi;
            dusman_3.Top += dusmanHizi;

            if (dusman_1.Top > 774 || dusman_2.Top > 774 || dusman_3.Top > 774)
            {
                gameOver();
            }
            if (dusman_1.Bottom >= player.Top + player.Height / 2)
            {
                if ((dusman_1.Right > player.Left && dusman_1.Right < player.Right) || (dusman_1.Left > player.Left && dusman_1.Left < player.Right))
                {
                    dusman_1.Top = -500;
                    gameOver();
                }
            }
            else if (dusman_2.Bottom >= player.Top + player.Height / 2)
            {
                if ((dusman_2.Right > player.Left && dusman_2.Right < player.Right) || (dusman_2.Left > player.Left && dusman_2.Left < player.Right))
                {
                    dusman_2.Top = -900;
                    gameOver();
                }
            }
            else if (dusman_3.Bottom >= player.Top + player.Height / 2)
            {
                if ((dusman_3.Right > player.Left && dusman_3.Right < player.Right) || (dusman_3.Left > player.Left && dusman_3.Left < player.Right))
                {
                    dusman_3.Top = -1300;
                    gameOver();
                }
            }







            if (solaGit == true && player.Left > 0)
            {
                player.Left -= playerHizi;
            }
            if (sagaGit == true && player.Left < 717)
            {
                player.Left += playerHizi;
            }

            if (atis == true)
            {
                mermiHizi = 20;
                mermi.Top -= mermiHizi;
            }
            else
            {
                mermi.Left = -300;
                mermiHizi = 0;
            }

            if (mermi.Top < -30)
            {
                atis = false;
            }

            if (mermi.Bounds.IntersectsWith(dusman_1.Bounds))
            {
                skor += 1;
                dusman_1.Top = -450;
                dusman_1.Left = rnd.Next(20, 600);
                atis = false;
            }
            if (mermi.Bounds.IntersectsWith(dusman_2.Bounds))
            {
                skor += 1;
                dusman_2.Top = -650;
                dusman_2.Left = rnd.Next(20, 600);
                atis = false;
            }
            if (mermi.Bounds.IntersectsWith(dusman_3.Bounds))
            {
                skor += 1;
                dusman_3.Top = -750;
                dusman_3.Left = rnd.Next(20, 600);
                atis = false;
            }

            if (skor == 5)
            {
                dusmanHizi = 9;
            }
            if (skor == 10)
            {
                dusmanHizi = 11;
            }
            if (skor == 15)
            {
                dusmanHizi = 13;
            }


        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solaGit = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                sagaGit = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solaGit = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                sagaGit = false;
            }
            if (e.KeyCode == Keys.Space && atis == false)
            {
                atis = true;

                mermi.Top = player.Top - 65;
                mermi.Left = player.Left + (player.Width / 2);
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            lbl_bitis.Text = " ";
            dusmanHizi = 6;


            dusman_1.Left = rnd.Next(20, 600);
            dusman_2.Left = rnd.Next(20, 600);
            dusman_3.Left = rnd.Next(20, 600);

            dusman_1.Top = rnd.Next(0, 200) * -1;
            dusman_2.Top = rnd.Next(0, 500) * -1;
            dusman_3.Top = rnd.Next(0, 900) * -1;

            skor = 0;
            mermiHizi = 0;
            mermi.Left = -300;
            atis = false;

            lbl_skor.Text = skor.ToString();
        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            lbl_bitis.Text += "Skor: " + lbl_skor.Text + Environment.NewLine + "Oyun Bitti!" + Environment.NewLine + "Yeni oyun için ENTER'a basın.";

        }


    }
}