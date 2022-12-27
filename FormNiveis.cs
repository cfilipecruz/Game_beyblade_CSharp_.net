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
    public partial class FormNiveis : Form
    {
   
        public FormNiveis()
        {
            InitializeComponent();
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
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }
    }
}
