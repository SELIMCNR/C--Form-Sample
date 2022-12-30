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
    public partial class Form1 : Form
    {
     
        Form3 frm3 = new Form3();

        public Form1()
        {
            InitializeComponent();
           
        }
        String sifre;
        string tc;
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void button0_Click(object sender, EventArgs e)
        {
            int i = 0;
           //Şifre giriş alanı 1 .soru 
            do
            {
                i++;
                tc = (textBox1.Text);
                sifre = (textBox2.Text);
                if ((tc=="123456789") && (sifre == "1234"))
                {
                    MessageBox.Show("Giriş başarılı");
                    frm3.Show();
                    this.Close();
                }
                else
                {
                   
                    MessageBox.Show("Hatalı tc veya şifre","Şifre hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
             
             
            }
            while (i < 3);

            MessageBox.Show("Giriş hakkınız bitti");
            this.Close();
        }

        
    }
}
