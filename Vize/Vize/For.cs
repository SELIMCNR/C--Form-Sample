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
    public partial class For : Form
    {
        public For()
        {
            InitializeComponent();
        }
        int sayi1, sayi2, toplam,ortalama;
        private void button1_Click(object sender, EventArgs e)
        {

            sayi1 = 1;
            sayi2 = 500;

            for(int i = sayi1; i< sayi2;i++)
            {
                listBox1.Items.Add(i);
                toplam += i;
                ortalama = toplam / 200;
                if (i == 200)
                {
                  
                    
                    listBox1.Items.Add("\n" + toplam);
         
                    listBox1.Items.Add(ortalama);
               
                    textBox2.Text = i.ToString();
                    textBox4.Text = toplam.ToString();
                    textBox5.Text = ortalama.ToString();
                    break;
                }

            }


        }
    }
}
