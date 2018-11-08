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

            //branchの練習
            //このコメントのみ
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //テキストボックスに文字列が打たれたものをtextvalueに保管し表示
            label1.Text= textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //テキストボックスに新たに文字列が打たれたものをtextvalue1に保管
            string textvalue1 = textBox1.Text;

            //newForm2の作成
            Form2 form2 = new WindowsFormsApplication1.Form2( textvalue1);
            form2.Show(); //フォーム２を表示
        }
    }
}
