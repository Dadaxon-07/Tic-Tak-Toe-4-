using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tak_Toe
{
    public partial class Form1 : Form
    {

        char kim = 'o';
        short harakat = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yangiUyinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kim = 'o';
            harakat = 0;
            b1.Enabled= true; b1.Text = ""; b1.BackColor =Color.White;
            b2.Enabled= true; b2.Text = ""; b2.BackColor = Color.White;
            b3.Enabled= true; b3.Text = ""; b3.BackColor = Color.White;
            b4.Enabled= true; b4.Text = ""; b4.BackColor = Color.White;
            b5.Enabled= true; b5.Text = ""; b5.BackColor = Color.White;
            b6.Enabled= true; b6.Text = ""; b6.BackColor = Color.White;
            b7.Enabled= true; b7.Text = ""; b7.BackColor = Color.White;
            b8.Enabled= true; b8.Text = ""; b8.BackColor = Color.White;
            b9.Enabled= true; b9.Text = ""; b9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;

        }

        private void malumotlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Tic Tak Toe o'yinining Desktop ko'rinishi.\nO'yin muallifi:" +
                "\n           Shahrisabz shahardagi Mirzo Ulug'bek nomidagi" +
                "\n           8-umumiy o'rta ta'lim maktabining 9-A sinf " +
                "\n           o'quvchisi Sharofiddinov Dadaxon ");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled= false;
            bt.BackColor= Color.Orange;
            if (kim =='o')
            {
                bt.Text = "o";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"{kim.ToString().ToUpper()} g'olib buldi"));
                    tableLayoutPanel1.Enabled= false;
                }
                else if (harakat == 8)
                {
                    MessageBox.Show("Qaytadan davom eting !!!");
                }
                kim = 'x';

            }
            else if (kim =='x')
            {
                bt.Text = "x";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                   (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                   (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                   (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                   (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                   (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                   (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                   (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"{kim.ToString().ToUpper()} g'olib buldi"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (harakat == 8)
                {
                    MessageBox.Show("Qaytadan davom eting !!!");
                }
                kim = 'o';
            }
            harakat++;
        }
    }
}
