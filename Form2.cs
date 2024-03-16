using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            checkBox1.Text = Form1.lista[0].Nev;
            checkBox2.Text = Form1.lista[1].Nev;
            checkBox3.Text = Form1.lista[2].Nev;
            checkBox4.Text = Form1.lista[3].Nev;
            checkBox5.Text = Form1.lista[4].Nev;

            radioButton1.Text = Form1.lista[0].Kicsi.ToString() + " Ft";
            radioButton2.Text = Form1.lista[1].Kicsi.ToString() + " Ft";
            radioButton3.Text = Form1.lista[2].Kicsi.ToString() + " Ft";
            radioButton4.Text = Form1.lista[3].Kicsi.ToString() + " Ft";
            radioButton5.Text = Form1.lista[4].Kicsi.ToString() + " Ft";
            
            radioButton6.Text = Form1.lista[0].Nagy.ToString() + " Ft";
            radioButton7.Text = Form1.lista[1].Nagy.ToString() + " Ft";
            radioButton8.Text = Form1.lista[2].Nagy.ToString() + " Ft";
            radioButton9.Text = Form1.lista[3].Nagy.ToString() + " Ft";
            radioButton10.Text = Form1.lista[4].Nagy.ToString() + " Ft";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox1.Checked)
			{
				radioButton6.Checked = true;
				numericUpDown1.Value = 1;
			}
			else
			{
				radioButton6.Checked = false;
				radioButton1.Checked = false;
				numericUpDown1.Value = 0;
			}
		}
    }
}
