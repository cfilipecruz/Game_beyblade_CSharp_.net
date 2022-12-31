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
        public static int massa;
        public static int rotacao;

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



        private void LB_BACK_Click(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
          //  soundclick.Play();
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
          //  soundclick.Play();
            Application.Exit();
        }

        private void LB_BACK_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            LB_BACK.BorderStyle = BorderStyle.FixedSingle;
            LB_BACK.BackColor = Color.FromArgb(100, 255, 255, 255);
          //  soundhover.Play();
        }

        private void LB_BACK_MouseLeave(object sender, EventArgs e)
        {
            LB_BACK.BorderStyle = BorderStyle.None;
            LB_BACK.BackColor = Color.FromArgb(0, 255, 255, 255);

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
          //  soundclick.Play();
        }

        private void fileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
          //  soundhover.Play();
        }

        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
          //  soundhover.Play();
        }

        private void LB_NIVEL_01_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            LB_NIVEL_01.BorderStyle = BorderStyle.FixedSingle;
            LB_NIVEL_01.BackColor = Color.FromArgb(100, 255, 255, 255);
          //  soundhover.Play();
        }

        private void LB_NIVEL_01_MouseLeave(object sender, EventArgs e)
        {
            LB_NIVEL_01.BackColor = Color.FromArgb(0, 255, 255, 255);
            LB_NIVEL_01.BorderStyle = BorderStyle.None;
        }
        private void LB_NIVEL_01_Click(object sender, EventArgs e)
        {
            FormNiveis.massa = 40; //Assign values to static members
            FormNiveis.rotacao = 40; //Assign values to static members

            FormPlay formPlay = new FormPlay();
            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
          //  soundclick.Play();
            formPlay.Show();
            this.Hide();
        }

        private void LB_NIVEL_2_Click(object sender, EventArgs e)
        {
            FormNiveis.massa = 60; //Assign values to static members
            FormNiveis.rotacao = 60; //Assign values to static members

            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
           // soundclick.Play();
            FormPlay formPlay = new FormPlay();
            formPlay.Show();
            this.Hide();
        }

        private void LB_NIVEL_3_Click(object sender, EventArgs e)
        {

            FormNiveis.massa = 80; //Assign values to static members
            FormNiveis.rotacao = 80; //Assign values to static members

            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
          //  soundclick.Play();
            FormPlay formPlay = new FormPlay();
            formPlay.Show();
            this.Hide();
        }

        private void LB_NIVEL_4_Click(object sender, EventArgs e)
        {
            FormNiveis.massa = 100; //Assign values to static members
            FormNiveis.rotacao = 100; //Assign values to static members

            SoundPlayer soundclick = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\click.mp3");
          //  soundclick.Play();
            FormPlay formPlay = new FormPlay();
            formPlay.Show();
            this.Hide();
        }

        private void LB_NIVEL_2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            LB_NIVEL_2.BorderStyle = BorderStyle.FixedSingle;
            LB_NIVEL_2.BackColor = Color.FromArgb(100, 255, 255, 255);
          //  soundhover.Play();
        }

        private void LB_NIVEL_2_MouseLeave(object sender, EventArgs e)
        {
            LB_NIVEL_2.BackColor = Color.FromArgb(0, 255, 255, 255);
            LB_NIVEL_2.BorderStyle = BorderStyle.None;
        }

        private void LB_NIVEL_3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            LB_NIVEL_3.BorderStyle = BorderStyle.FixedSingle;
            LB_NIVEL_3.BackColor = Color.FromArgb(100, 255, 255, 255);
          //  soundhover.Play();
        }

        private void LB_NIVEL_3_MouseLeave(object sender, EventArgs e)
        {
            LB_NIVEL_3.BackColor = Color.FromArgb(0, 255, 255, 255);
            LB_NIVEL_3.BorderStyle = BorderStyle.None;
        }

        private void LB_NIVEL_4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer soundhover = new SoundPlayer(@"D:\Escola\Licenciatura\4º Ano\1º Semestre\Progig\Projeto\beyblade\Assets\Sounds\mouseHoover.wav");
            LB_NIVEL_4.BorderStyle = BorderStyle.FixedSingle;
            LB_NIVEL_4.BackColor = Color.FromArgb(100, 255, 255, 255);
         //   soundhover.Play();
        }

        private void LB_NIVEL_4_MouseLeave(object sender, EventArgs e)
        {
            LB_NIVEL_4.BackColor = Color.FromArgb(0, 255, 255, 255);
            LB_NIVEL_4.BorderStyle = BorderStyle.None;
        }
    }
}
