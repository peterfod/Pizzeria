using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        public static List<Pizza> lista = new List<Pizza>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("pizzak.txt");
            while (!sr.EndOfStream)
            {
                Pizza sor = new Pizza(sr.ReadLine());
                lista.Add(sor);
            }

            this.Hide();
            Form2 menu = new Form2();
            menu.ShowDialog();
            menu.Dispose();
            this.Show();
        }
    }
}
