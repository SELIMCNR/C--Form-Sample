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
    public partial class Form8 : Form
    {
        public Form8()
        {
           

            InitializeComponent();
            MessageBox.Show(isim + numara);
        }
        string isim;
        int numara;
        
        private void button1_Click(object sender, EventArgs e)
        {
            isim = textBox1.Text;
            numara = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(isim + numara);
        }
    }
}
