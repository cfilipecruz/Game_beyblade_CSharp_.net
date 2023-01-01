using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace beyblade
{
    public partial class FormPlay : Form
    {
        public static int massa;
        public static int rotacao;
        private Arena arena;
        private int ganhou;
        private int barJump = 5;
        private bool direction = true;
        private int barWidth = 5;
        private int position = 50;
        private ColorBlend cb = new ColorBlend();

        int valorDiv = 5;
        double percentage;


        public FormPlay()
        {
            massa = FormNiveis.massa; 
            rotacao = FormNiveis.rotacao;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            arena = new Arena(panelArena.DisplayRectangle.Size);

            cb.Positions = new[] { 0, 0.85f, 1 };
            cb.Colors = new[] {  Color.Red, Color.Yellow,  Color.Green };
            timer1.Interval = 1;
            timer1.Enabled = false;

        }

        private void FormPlay_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;            //Colocar A janela em FullScreen
            LB_Massa.Text = "Massa: " + massa;
            LB_Aceleracao.Text = "Aceleração: " + rotacao;

            arena.Inimigo.Massa = massa;
            arena.Inimigo.aVelo = rotacao;

            LB_Vencedor.Visible = false;

        }

        private void LB_GoBack_Click(object sender, EventArgs e)
        {
            FormNiveis formMain = new FormNiveis();
            formMain.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LB_GoBack_Click_1(object sender, EventArgs e)
        {
            FormNiveis formNiveis = new FormNiveis();
            formNiveis.Show();
            this.Hide();
        }

        private void desenhaTudo(Graphics g)
        {

            g.Clear(panelArena.BackColor);
            arena.draw(g);

        }

        private void panelArena_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            desenhaTudo(g);
        }

        private void timerAnima_Tick(object sender, EventArgs e)
        {
            arena.move();
            reDesenha();
            
            labelRaio.Text = arena.Jogador.aVelo.ToString() + " , " + arena.Jogador.Massa.ToString();
            labelInimigo.Text=arena.Inimigo.aVelo.ToString() +" , "+arena.Inimigo.Massa.ToString();

        }

        private void vencedor()
        {
            ganhou = arena.Vencedor;
        }

        private void reDesenha()
        {
            BufferedGraphicsContext currentContext;
            BufferedGraphics myBuffer;
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate(this.panelArena.CreateGraphics(),
            this.panelArena.DisplayRectangle);
            Graphics g = myBuffer.Graphics;
            desenhaTudo(g);
            myBuffer.Render();
            myBuffer.Dispose();
        }


        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //arena.Jogador.aVelo = float.Parse(textBox1.Text);
            arena.Jogador.aVelo = (float)percentage;


            timerAnima.Enabled = !timerAnima.Enabled;
            if (!timerAnima.Enabled)
            {
                buttonPlay.Text = "Play";
            }
            {
                buttonPlay.Visible = false;
            }

            if (RB_10.Checked)
            {
                arena.Jogador.Massa = 10;
            }
            if (RB_20.Checked)
            {
                arena.Jogador.Massa = 20;
            }
            if (RB_30.Checked)
            {
                arena.Jogador.Massa = 30;
            }
            if (RB_40.Checked)
            {
                arena.Jogador.Massa = 40;
            }
            if (RB_50.Checked)
            {
                arena.Jogador.Massa = 50;
            }
            if (RB_60.Checked)
            {
                arena.Jogador.Massa = 60;
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (direction)
            {
                if (position < 100)
                {
                    position = Math.Min(100, position + barJump);
                }
                else
                {
                    direction = false;
                    position = Math.Max(0, position - barJump);
                }
            }
            else
            {
                if (position > 0)
                {
                    position = Math.Max(0, position - barJump);
                }
                else
                {
                    direction = true;
                    position = Math.Min(100, position + barJump);
                }
            }
            pictureBox1.Invalidate();
    }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush lgb = new LinearGradientBrush(pictureBox1.ClientRectangle, Color.Black, Color.Black, 0, false))
            {
                lgb.InterpolationColors = cb;
                e.Graphics.FillRectangle(lgb, pictureBox1.ClientRectangle);
            }
            int x = (int)(pictureBox1.ClientRectangle.Width * (double)position / 100);
            Rectangle rc = new Rectangle(new Point(x, 0), new Size(1, pictureBox1.ClientRectangle.Height - 1));
            rc.Inflate(barWidth, 0);
            e.Graphics.DrawRectangle(Pens.Black, rc);
            e.Graphics.FillRectangle(Brushes.Black, rc);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (timer1.Enabled && e.Button == MouseButtons.Left)
            {
                if (RBA_10.Checked)
                {
                    valorDiv = 10;
                }
                if (RBA_25.Checked)
                {
                    valorDiv = 4;
                }
                if (RBA_50.Checked)
                {
                    valorDiv = 2;
                }
                if (RBA_100.Checked)
                {
                    valorDiv = 1;
                }

                timer1.Stop();
                button1.Enabled = true;
                percentage = (int)position/valorDiv;

                LB_MAceleracao.Text = "You got: " + percentage;
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restart();

        }

        private void restart()
        {
           arena.iniciaBeyblade();
           timerAnima.Stop();
           panelArena.Invalidate();           
           buttonPlay.Visible = true;
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void labelInimigo_Click(object sender, EventArgs e)
        {

        }

        private void labelRaio_Click(object sender, EventArgs e)
        {

        }

        private void LB_Massa_Click(object sender, EventArgs e)
        {

        }

        private void LB_Aceleracao_Click(object sender, EventArgs e)
        {

        }
    }
}
