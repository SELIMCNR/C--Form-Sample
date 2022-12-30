using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vize
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int maas;     
        int fark = 100;
        double damgavergisi, toplam;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
            maas = int.Parse(textBox1.Text);
        

            damgavergisi = maas * 0.006;
            textBox2.Text = damgavergisi.ToString();
            toplam = maas + damgavergisi + fark;
            textBox3.Text = toplam.ToString();

        }

        

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            maas = int.Parse(textBox1.Text);
        
                fark = 300;
                damgavergisi = maas * 0.006;
                textBox2.Text = damgavergisi.ToString();
                toplam = maas + damgavergisi + fark;
                textBox3.Text = toplam.ToString();
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            maas = int.Parse(textBox1.Text);
            fark = 400;
            damgavergisi = maas * 0.006;
            textBox2.Text = damgavergisi.ToString();
            toplam = maas + damgavergisi + fark;
            textBox3.Text = toplam.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            maas = int.Parse(textBox1.Text);
            fark = 500;
            damgavergisi = maas * 0.006;
            textBox2.Text = damgavergisi.ToString();
            toplam = maas + damgavergisi + fark;
            textBox3.Text = toplam.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            maas = int.Parse(textBox1.Text);
            fark = 200;
            damgavergisi = maas * 0.006;
            textBox2.Text = damgavergisi.ToString();
            toplam = maas + damgavergisi + fark;
            textBox3.Text = toplam.ToString();
        }
    }
}
