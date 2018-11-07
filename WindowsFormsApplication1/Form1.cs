using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string textValue = textBox1.Text;

            label1.Text = textValue;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textvalue1 = textBox1.Text;
            string val = textvalue1;

            Form2 form2 = new WindowsFormsApplication1.Form2(val);
            form2.Show(); 
        }
    }
}
