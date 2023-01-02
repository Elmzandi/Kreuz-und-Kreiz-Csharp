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
    public partial class FrmPlayer1 : Form
    {
        public FrmPlayer1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain frm = new FormMain();
            frm.Show();




        }

        List<Guna.UI2.WinForms.Guna2Button> buttons;
        Random Rand = new Random();
        int player1 = 0;
        int Player2 = 0;

        void Loadbtn()
        {
            buttons = new List<Guna.UI2.WinForms.Guna2Button> { Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8, Btn9 };

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
                Player2++;
                lbl2.Text = player1.ToString();

            }                                       
        }


        bool win = false;

        void checkwinner() 
        {
            if (Btn1.Text !="" && Btn1.Text == Btn2.Text && Btn1.Text==Btn3.Text) 
            {
                wincolor(Btn1, Btn2, Btn3);
                win = true;
            }

            else if(Btn4.Text != "" && Btn4.Text == Btn5.Text && Btn4.Text == Btn6.Text)
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

        private void FrmPlayer1_Load(object sender, EventArgs e)
        {
            foreach(Control c in panel2.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new System.EventHandler(btn_click);

                }

            }
            Loadbtn();

        }

        public void btn_click(object sender , EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if(btn.Text.Equals(""))
            {
                btn.Text = "X";
                btn.ForeColor = Color.Yellow;
                buttons.Remove(btn);
                checkwinner();
                move.Start();
            }
        }

        private void move_Tick(object sender, EventArgs e)
        {
            if (buttons.Count > 0 && win == false)
            {
                int index = Rand.Next(buttons.Count);
                if (buttons[index].Text == "")
                {
                    buttons[index].ForeColor = Color.Lime;
                    buttons[index].Text = "O";
                    buttons.RemoveAt(index);
                    checkwinner();
                    move.Stop();
                }
            }
        }

        private void Btnagain_Click(object sender, EventArgs e)
        {
            Loadbtn();
            win = false;
            foreach (Control c in panel2.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Text = "";
                }
            }
        }
    }
}
