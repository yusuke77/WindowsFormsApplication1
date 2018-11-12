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
        //グローバル変数
        float push_num = 0;//押された数字
        float ans_save = 0;//数字保存用
        int enzann=0;//演算の種類決め
        int hyouji=0;//例外処理（一回目の演算の時はそのまま数字表示、二回目からは演算行う）
        int syousuu = 0;//少数点が押されたときの処理
        int syousuu_cnt = 0;//少数点の桁数
        int i;//forに用いたカウント用
        int waruzero = 0;//少数点のときの"0"の表示個数

        public Form2()
        {
            InitializeComponent();
            label2.Text = push_num.ToString();//はじめは0表示
        }

        //CLOSEボタンを押したとき
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();　//終了コマンド
        }
        
        //９が押された時
        private void button11_Click(object sender, EventArgs e)
        {
            if (syousuu==1)//小数点ボタンが押されたときの処理（小数点ボタンが押されるとsyousuu=1となる）
            {
                syousuu_cnt = syousuu_cnt + 1;//小数点以下の桁数
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;//１０をpush_numにかける→二桁目三桁目の表示のため→一桁目であれば初期化０になってるので０となる(ex)1*10=10
                }
                    push_num = push_num + 9;//上の一行に９を足し算(ex)1*10=10 10+9=19
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;//全体を少数点桁数分で割ることで小数点表示できる(ex)1955/10=195.5 195.5/10=19.55など
                }
            }
            else {
                push_num = push_num * 10;  //１０をpush_numにかける→二桁目三桁目の表示のため→一桁目であれば初期化０になってるので０となる(ex)1*10=10
                push_num = push_num + 9;   //上の一行に９を足し算(ex)1*10=10 10+9=19
            }
            label2.Text = push_num.ToString();//label2に数字を表示
            //以降のボタン１～９が押された時は同じ操作
        }

        //８が押された時
        private void button10_Click(object sender, EventArgs e)
        {
            if (syousuu == 1)
            {
                syousuu_cnt = syousuu_cnt + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;
                }
                push_num = push_num + 8;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;
                }
            }else {
                push_num = push_num * 10;
                push_num = push_num + 8;
            }
           
            label2.Text = push_num.ToString();
        }

        //７が押された時
        private void button9_Click(object sender, EventArgs e)
        {
            if (syousuu == 1)
            {
                syousuu_cnt = syousuu_cnt + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;
                }
                push_num = push_num + 7;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;
                }
            }
            else
            {
                push_num = push_num * 10;
                push_num = push_num + 7;
            }

            label2.Text = push_num.ToString();
        }

        //６が押された時
        private void button8_Click(object sender, EventArgs e)
        {
            if (syousuu == 1)
            {
                syousuu_cnt = syousuu_cnt + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;
                }
                push_num = push_num + 6;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;
                }
            }
            else
            {
                push_num = push_num * 10;
                push_num = push_num + 6;
            }

            label2.Text = push_num.ToString();
        }

        //５が押された時
        private void button7_Click(object sender, EventArgs e)
        {
            if (syousuu == 1)
            {
                syousuu_cnt = syousuu_cnt + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;
                }
                push_num = push_num + 5;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;
                }
            }
            else
            {
                push_num = push_num * 10;
                push_num = push_num + 5;
            }

            label2.Text = push_num.ToString();
        }

        //４が押された時
        private void button6_Click(object sender, EventArgs e)
        {
            if (syousuu == 1)
            {
                syousuu_cnt = syousuu_cnt + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;
                }
                push_num = push_num + 4;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;
                }
            }
            else
            {
                push_num = push_num * 10;
                push_num = push_num +4;
            }

            label2.Text = push_num.ToString();
        }

        //３が押された時
        private void button5_Click(object sender, EventArgs e)
        {
            if (syousuu == 1)
            {
                syousuu_cnt = syousuu_cnt + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;
                }
                push_num = push_num + 3;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;
                }
            }
            else
            {
                push_num = push_num * 10;
                push_num = push_num + 3;
            }

            label2.Text = push_num.ToString();
        }

        //２が押された時
        private void button4_Click(object sender, EventArgs e)
        {
            if (syousuu == 1)
            {
                syousuu_cnt = syousuu_cnt + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;
                }
                push_num = push_num + 2;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;
                }
            }
            else
            {
                push_num = push_num * 10;
                push_num = push_num + 2;
            }

            label2.Text = push_num.ToString();
        }

        //１が押された時
        private void button3_Click(object sender, EventArgs e)
        {
            if (syousuu == 1)
            {
                syousuu_cnt = syousuu_cnt + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;
                }
                push_num = push_num + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;
                }
            }
            else
            {
                push_num = push_num * 10;
                push_num = push_num + 1;
            }

            label2.Text = push_num.ToString();
        }

        //０が押された時
        private void button12_Click(object sender, EventArgs e)
        {
            if (syousuu == 1)
            {
                syousuu_cnt = syousuu_cnt + 1;
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num * 10;
                }
                for (i = 0; i < syousuu_cnt; i++)
                {
                    push_num = push_num / 10;
                }

                switch (syousuu_cnt)
                {
                    case 1:
                        label2.Text = push_num.ToString() + ".0";//小数点以下桁数表示
                        break;
                    case 2:
                        label2.Text = push_num.ToString() + ".00";
                        break;
                    case 3:
                        label2.Text = push_num.ToString() + ".000";
                        break;
                    case 4:
                        label2.Text = push_num.ToString() + ".0000";
                        break;
                    case 5:
                        label2.Text = push_num.ToString() + ".00000";
                        break;
                    case 6:
                        label2.Text = push_num.ToString() + ".000000";
                        break;
                    default:
                        label2.Text = "エラー";
                        break;
                }
            }
            else
            {
                push_num = push_num * 10;
                label2.Text = push_num.ToString();
            }         
        }

        //CAが押された時
        private void button18_Click(object sender, EventArgs e)
        {
            push_num = 0;//0オールクリアする　
            syousuu_cnt = 0;
            syousuu = 0;
            ans_save = 0;
            enzann = 0;
            hyouji = 0;
            label2.Text = push_num.ToString(); //0を表示
        }

        //＋が押された時
        private void button14_Click(object sender, EventArgs e)
        {

            if (enzann == 2)//マイナス処理
            {
                push_num = -push_num;//打たれた数字をマイナス反転
            }
            enzann = 1;//変数に１を代入する→後に「＝」押されたときに変数1の処理を行うため

            if (hyouji == 0) {

                if (ans_save == 0)
                {
                    label2.Text = push_num.ToString(); //左辺の数字表示
                    ans_save = push_num;//左辺の数字を保存
                }else
                {
                    label2.Text = ans_save.ToString();//=後+処理（(ex)＝１０+５＝１５）
                }
            }
            else
            {
                ans_save=ans_save + push_num;//保存していた数字と押された数字の足し算をans_saveに保存
                label2.Text = ans_save.ToString();//ans_saveを表示
            }
            push_num = 0;//続きの計算するために最初の状態に戻す
            hyouji = 1;//１回目の例外処理
            syousuu_cnt = 0;//小数点処理も0クリアする
            syousuu = 0;
        }

        // -が押されたとき
        private void button15_Click(object sender, EventArgs e)
        {
            enzann = 2;
            if (hyouji == 0)
            {
                if (ans_save == 0)
                {
                    label2.Text = push_num.ToString();
                    ans_save = push_num;
                }
                else
                {
                    label2.Text = ans_save.ToString();
                }
            }
            else
            {
                ans_save = ans_save - push_num;
                label2.Text = ans_save.ToString();
            }
            push_num = 0;
            hyouji = 1;
            syousuu_cnt = 0;
            syousuu = 0;

        }

        //×押されたとき
        private void button16_Click(object sender, EventArgs e)
        {
            if (enzann == 2)//マイナス処理
            {
                label2.Text = push_num.ToString();//打たれた数字表示
                ans_save = -push_num;//打たれた数字をマイナス反転
            }
            else
            {
                if (hyouji == 0)
                {
                    if (ans_save == 0)
                    {
                        label2.Text = push_num.ToString();
                        ans_save = push_num;
                    }
                    else
                    {
                        label2.Text = ans_save.ToString();
                    }
                }
                else
                {
                    ans_save = ans_save * push_num;
                    label2.Text = ans_save.ToString();
                }
            }
            enzann = 3;
            push_num = 0;
            hyouji = 1;
            syousuu_cnt = 0;
            syousuu = 0;
        }

        // ÷が押されたとき
        private void button17_Click(object sender, EventArgs e)
        {
            if (enzann == 2)//マイナス処理
            {
                label2.Text = push_num.ToString();//打たれた数字表示
                ans_save = -push_num;//打たれた数字をマイナス反転
            }
            else
            {
                if (hyouji == 0)
                {
                    if (ans_save == 0)
                    {
                        label2.Text = push_num.ToString();
                        ans_save = push_num;
                    }
                    else
                    {
                        label2.Text = ans_save.ToString();
                    }
                }
                else
                {
                    ans_save = ans_save / push_num;
                    if (ans_save == 0)
                    {
                        label2.Text = waruzero.ToString();//0÷数字＝0
                    }
                    else if (push_num == 0)
                    {
                        label2.Text = "エラー";//□÷0＝エラー
                    }
                    else
                    {
                        label2.Text = ans_save.ToString();
                    }
                }
            }
            enzann = 4;
            push_num = 0;
            hyouji = 1;
            syousuu_cnt = 0;
            syousuu = 0;
        }

        //＝が押されたとき
        private void button19_Click(object sender, EventArgs e)
        {
                switch (enzann)
                {
                    case 1://+処理
                        ans_save = (push_num + ans_save);//答え保管
                        label2.Text = ans_save.ToString();//答え表示
                        break;
                    case 2://-処理
                        ans_save = (ans_save -push_num);
                        label2.Text = ans_save.ToString();
                        break;
                    case 3://*処理
                        ans_save = (push_num * ans_save);
                        label2.Text = ans_save.ToString();
                        break;
                    case 4://÷処理
                        ans_save = (ans_save / push_num);

                        if (ans_save == 0){
                        label2.Text = waruzero.ToString(); //0÷数字＝0
                        }if (push_num == 0){
                        label2.Text = "エラー";//□÷0＝エラー
                        }else {
                        label2.Text = ans_save.ToString();
                        }
                        break;
                }
                enzann = 0;
                hyouji = 0;
                push_num = 0;
                syousuu_cnt = 0;
                syousuu = 0;
        }

        //小数点が押されたとき
        private void button13_Click(object sender, EventArgs e)
        {
            label2.Text = push_num.ToString()+".";//小数点表示
            syousuu = syousuu+1;//小数点が1以上の時は小数点計算になる（初期値０）
            if (syousuu >= 2)
            {
                label2.Text = "エラー";//小数点二回以上連続はエラー
                syousuu = 1;//小数点を1個に戻す
            }
        }

        //CEが押されたとき
        private void button20_Click_1(object sender, EventArgs e)
        {
            if (hyouji == 0)
            {
                push_num = 0;//0表示する
                label2.Text = push_num.ToString();
                syousuu_cnt = 0;
                syousuu = 0;
                enzann = 0;
            }
            else//hyouji=1の時
            {
                // ans_saveはそのまま保存push_numはクリアenzannもそのまま
                push_num = 0;
                label2.Text = push_num.ToString();
            }

        }
    }
}
