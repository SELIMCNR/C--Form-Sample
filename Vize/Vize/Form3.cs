using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double vize, final, ort;
                string Harfnotu, sonuc;

                vize = Double.Parse(textBox1.Text);
                final = Double.Parse(textBox2.Text);

                ort = vize * 0.4 + final * 0.6;
                textBox3.Text = ort.ToString();
                if (ort > 85 && ort < 100)
                {
                    Harfnotu = "aa";
                    textBox5.Text = Harfnotu;
                    sonuc = "Geçti";
                    textBox4.Text = sonuc;
                }
                else if (ort > 70 && ort < 85)
                {
                    Harfnotu = "bb";
                    textBox5.Text = Harfnotu;
                    sonuc = "Geçti";
                    textBox4.Text = sonuc;
                }
                else if (ort > 50 && ort < 70)
                {
                    Harfnotu = "cc";
                    sonuc = "Geçti";
                    textBox5.Text = Harfnotu;
                    textBox4.Text = sonuc;
                }
                else if (ort > 30 && ort < 50)
                {
                    Harfnotu = "ff";
                    sonuc = "Kaldı";
                    textBox5.Text = Harfnotu;
                    textBox4.Text = sonuc;
                }
                textBox3.Text = ort.ToString();
            }
            catch
            {
                MessageBox.Show("Hatalı giriş");
            }


        }
    }
    }

