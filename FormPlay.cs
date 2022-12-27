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
        public static int massa;
        public static int aceleracao;
        public FormPlay()
        {
            massa = FormNiveis.massa; 
            aceleracao = FormNiveis.aceleracao;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
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
    }
}
