using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private int barJump = 5;
        private bool direction = true;
        private int barWidth = 5;
        private int position = 50;
        private ColorBlend cb = new ColorBlend();

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

            //if (arena.Jogador.aVelo == 0)
            //{
            //    timerAnima.Stop();
            //}
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
            arena.Jogador.aVelo = float.Parse(textBox1.Text);

            timerAnima.Enabled = !timerAnima.Enabled;
            if (!timerAnima.Enabled)
            {
                buttonPlay.Text = "Play";

            }
            {
                buttonPlay.Visible = false;
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
                timer1.Stop();
                button1.Enabled = true;
                double percentage = (double)position / 100;
                LB_MAceleracao.Text = $"percentage = {percentage}";
            }
        }

        private void B_Massa_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled && e.Button == MouseButtons.Left)
            {
                timer1.Stop();
                button1.Enabled = true;
                double percentage = (double)position / 100;
                LB_MAceleracao.Text = $"percentage = {percentage}";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
