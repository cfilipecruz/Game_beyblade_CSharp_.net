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
    public partial class FormRules : Form
    {
        public FormRules()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormRules_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;            //Colocar A janela em FullScreen
        }

        private void LB_GoBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
            soundclick.Play();
            Application.Exit();
        }

        private void MenuStrip_Click(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
            soundclick.Play();
        }

        private void LB_GoBack_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            LB_GoBack.BorderStyle = BorderStyle.FixedSingle;
            LB_GoBack.BackColor = Color.FromArgb(100, 255, 255, 255);
            soundhover.Play();
        }

        private void LB_GoBack_MouseLeave(object sender, EventArgs e)
        {
            LB_GoBack.BorderStyle = BorderStyle.None;
            LB_GoBack.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void MenuStrip_MouseHover(object sender, EventArgs e)
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
