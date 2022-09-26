using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CV
{
    public partial class Form1 : Form
    {
        public string path = @".\Dati.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Caratteri;
            int CaratPrec = 0;
            StreamReader sr = new StreamReader(path);
            int count = 0;
            string check = "Certamente";

            while (sr.ReadLine() != null)
            {
                Caratteri = sr.ReadLine().Length;

                if (count != 0)
                {
                    if (CaratPrec != Caratteri)
                    {
                        check = "Non credo";
                        MessageBox.Show(check);
                        return;
                    }
                }

                CaratPrec = Caratteri;
                count++;
            }
            MessageBox.Show(check);
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y = 0;
            int y1 = 0;
            StreamReader sr = new StreamReader(@"./Dati.csv");
            int count = 0;
            while (sr.ReadLine() != null)
            {
                y1 = sr.ReadLine().Length;
                if (count != 0)
                {
                    if (y1 >= y)
                    {
                        y = y1;
                    }
                }
                count++;
            }
            y--;
            string m = Convert.ToString(y);
            MessageBox.Show(m, "Max:");
            sr.Close();
        }
    }
}
