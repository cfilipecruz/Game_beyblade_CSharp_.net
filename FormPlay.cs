using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public static int aceleracao;
        private Arena arena;
        public FormPlay()
        {
            massa = FormNiveis.massa; 
            aceleracao = FormNiveis.aceleracao;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            arena = new Arena(panelArena.DisplayRectangle.Size);

        }

        private void FormPlay_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;            //Colocar A janela em FullScreen
            LB_Massa.Text = "Massa: " + massa;
            LB_Aceleracao.Text = "Aceleração: " + aceleracao;
           
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
            labelRaio.Text = arena.Jogador.aVelo.ToString();

            if (arena.Jogador.aVelo == 0)
            {
                timerAnima.Stop();
            }
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
