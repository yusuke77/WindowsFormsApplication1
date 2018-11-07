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
    public partial class Form2 : Form
    {

        public Form2(string textvalue1)
        {
            InitializeComponent();
            label2.Text = textvalue1;//フォーム１から受け取った文字列を表示
        }
        //CLOSEボタンを押したとき
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();　//終了コマンド
        }
    }
}
