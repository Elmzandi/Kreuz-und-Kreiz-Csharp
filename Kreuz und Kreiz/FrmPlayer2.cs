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
    public partial class FrmPlayer2 : Form
    {
        public FrmPlayer2()
        {
            InitializeComponent();
        }

        int xo = 0;
        int player1 = 0;
        int player2 = 0;
        bool win = false;

        void checkwinner()
        {
            if (Btn1.Text != "" && Btn1.Text == Btn2.Text && Btn1.Text == Btn3.Text)
            {
                wincolor(Btn1, Btn2, Btn3);
                win = true;
            }

            else if (Btn4.Text != "" && Btn4.Text == Btn5.Text && Btn4.Text == Btn6.Text)
            {
                wincolor(Btn4, Btn5, Btn6);
                win = true;
            }

            else if (Btn7.Text != "" && Btn7.Text == Btn8.Text && Btn7.Text == Btn9.Text)
            {
                wincolor(Btn7, Btn8, Btn9);
                win = true;
            }

            else if (Btn1.Text != "" && Btn1.Text == Btn4.Text && Btn1.Text == Btn7.Text)
            {
                wincolor(Btn1, Btn4, Btn7);
                win = true;
            }

            else if (Btn2.Text != "" && Btn2.Text == Btn5.Text && Btn2.Text == Btn8.Text)
            {
                wincolor(Btn2, Btn5, Btn8);
                win = true;
            }

            else if (Btn3.Text != "" && Btn3.Text == Btn6.Text && Btn3.Text == Btn9.Text)
            {
                wincolor(Btn3, Btn6, Btn9);
                win = true;
            }

            else if (Btn1.Text != "" && Btn1.Text == Btn5.Text && Btn1.Text == Btn9.Text)
            {
                wincolor(Btn1, Btn5, Btn9);
                win = true;
            }

            else if (Btn3.Text != "" && Btn3.Text == Btn5.Text && Btn3.Text == Btn7.Text)
            {
                wincolor(Btn3, Btn5, Btn7);
                win = true;
            }

            }
        void wincolor(Guna.UI2.WinForms.Guna2Button b1, Guna.UI2.WinForms.Guna2Button b2, Guna.UI2.WinForms.Guna2Button b3)
        {
            b1.ForeColor = Color.BlueViolet;
            b2.ForeColor = Color.BlueViolet;
            b3.ForeColor = Color.BlueViolet;
            if (b1.Text == "X")
            {
                player1++;
                lbl1.Text = player1.ToString();

            }
            else
            {
                player2++;
                lbl2.Text = player1.ToString();

            }
        }


        private void FrmPlayer2_Load(object sender, EventArgs e)
        {

            foreach (Control c in panel2.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
        }
        void btn_click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if (btn.Text.Equals(""))
            {
                if (xo % 2 == 0)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Yellow;
                    checkwinner();
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Red;
                    checkwinner();
                }
                xo++;
            }

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlayer2_Click(object sender, EventArgs e)
        {
            xo = 0;
            win = false;
            foreach (Control c in panel2.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Text = "";
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain frm = new FormMain();
            frm.Show();
        }
    }
}
