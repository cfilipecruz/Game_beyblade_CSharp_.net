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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           // FormBorderStyle = FormBorderStyle.None;           //Retirar as bordas da janela, Clicar f10
            WindowState = FormWindowState.Maximized;            //Colocar A janela em FullScreen
            MenuStrip.BackColor = Color.Transparent;
            //  Label_MainMenu_Dark.BackColor = Color.Transparent;  //Colocar Transparente a cor da label
            //Colocar Transparente a cor do StripMenu
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LB_Rules_Click(object sender, EventArgs e)
        {
            FormRules formRules = new FormRules();
            formRules.Show();
            this.Hide();
        }

        private void LB_Play_Click(object sender, EventArgs e)
        {
            FormNiveis FormNiveis = new FormNiveis();
            FormNiveis.Show();
            this.Hide();
        }
    }
}
