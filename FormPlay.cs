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
        public FormPlay()
        {
            InitializeComponent();
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
    }
}
