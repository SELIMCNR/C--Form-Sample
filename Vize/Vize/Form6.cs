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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }



        int sayi1, sayi2, tektoplam, çifttoplam, sonuc;
        private void button1_Click(object sender, EventArgs e)
        {
     
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            for(int i = sayi1; sayi1<sayi2; i++)
            {
                if(i%2 == 0)
                {
                    listBox1.Items.Add(i);
                    çifttoplam =+ i;
                    
                }
                else if(i%2 == 1)
                {
                    listBox2.Items.Add(i);
                    tektoplam =+ i;
                }
               
            }
            sonuc = tektoplam + çifttoplam;
            textBox3.Text = sonuc.ToString();

        }
    }
}
