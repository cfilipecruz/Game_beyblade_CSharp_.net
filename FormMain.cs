using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beyblade
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;           //Retirar as bordas da janela, Clicar f10
            WindowState = FormWindowState.Maximized;            //Colocar A janela em FullScreen
           //SoundPlayer soundtrack = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\soundtrack.wav");
            //soundtrack.PlayLooping();
            //MenuStrip.BackColor = Color.Transparent;
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
            soundclick.Play();
            Application.Exit();
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
            soundclick.Play();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
          
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
             soundclick.Play();
             FormNiveis formNiveis = new FormNiveis();
             formNiveis.Show();
             this.Hide();


        }

        private void LB_Rules_Click_1(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
            soundclick.Play();
            FormRules formRules = new FormRules();
            formRules.Show();
            this.Hide();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.BackColor = Color.FromArgb(100, 255, 255, 255);
            soundhover.Play();
          
        }

        private void LB_Rules_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            LB_Rules.BorderStyle = BorderStyle.FixedSingle;
            LB_Rules.BackColor = Color.FromArgb(100, 255, 255, 255);
             soundhover.Play();

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BorderStyle = BorderStyle.None;
            label2.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void LB_Rules_MouseLeave(object sender, EventArgs e)
        {
            LB_Rules.BackColor = Color.FromArgb(0, 255, 255, 255);
            LB_Rules.BorderStyle = BorderStyle.None;
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
