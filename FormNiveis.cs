using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beyblade
{
    public partial class FormNiveis : Form
    {
   
        public FormNiveis()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormNiveis_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;            //Colocar A janela em FullScreen
            MenuStrip.BackColor = Color.Transparent;
        }

        private void LB_NIVEL_01_Click(object sender, EventArgs e)
        {
            float massa = 10;
            float aceleracao = 10;
            float atrito = 10;
            float velocidade = 10;

            FormPlay formPlay = new FormPlay();
            formPlay.Show();
            this.Hide();
        }

        private void LB_BACK_Click(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
            soundclick.Play();
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
            soundclick.Play();
            this.Close();
        }

        private void LB_BACK_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            LB_BACK.BorderStyle = BorderStyle.FixedSingle;
            LB_BACK.BackColor = Color.FromArgb(100, 255, 255, 255);
            soundhover.Play();
        }

        private void LB_BACK_MouseLeave(object sender, EventArgs e)
        {
            LB_BACK.BorderStyle = BorderStyle.None;
            LB_BACK.BackColor = Color.FromArgb(0, 255, 255, 255);

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
            soundclick.Play();
        }

        private void fileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            soundhover.Play();
        }

        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            soundhover.Play();
        }
    }
}
