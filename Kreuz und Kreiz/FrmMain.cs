using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreuz_und_Kreiz
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlayer1_Click(object sender, EventArgs e)
        {
            FrmPlayer1 frm = new FrmPlayer1();
            frm.Show();
            this.Hide();
        }

        private void BtnPlayer2_Click(object sender, EventArgs e)
        {
            FrmPlayer2 frm = new FrmPlayer2();
            frm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
