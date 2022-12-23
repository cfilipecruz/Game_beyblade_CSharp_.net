using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beyblade
{
    public partial class FormPlay : Form
    {
        private Arena arena;
        public FormPlay()
        {
            InitializeComponent();
            arena = new Arena(panelArena.DisplayRectangle.Size);
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;            //Colocar A janela em FullScreen
            MenuStrip.BackColor = Color.Transparent;
        }

        private void LB_GoBack_Click(object sender, EventArgs e)
        {
            FormNiveis formMain = new FormNiveis();
            formMain.Show();
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
            labelRaio.Text = arena.Objecto.aVelo.ToString();

            if (arena.Objecto.aVelo == 0)
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
    }
}
