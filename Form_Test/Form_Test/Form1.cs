using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //インスタンスの生成
                    Button testButton = new Button();

                    //ボタンの位置を設定
                    testButton.Location = new Point(50 + i * 50, 50 * j);
                    //ボタンの大きさを設定
                    testButton.Size = new Size(50, 50);
                    //ボタン内のテキストを設定
                    testButton.Text = "あいうえお";

                    testButton.MouseHover += button1_Click;
                    //コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("インパクト");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
