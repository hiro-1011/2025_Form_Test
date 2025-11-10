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
        // constをつけると初期化時にのみ値の変更が可能になる

        /// <summary>
        /// ボタンの横幅
        /// </summary>
        const int BUTTON_SIZE_X = 100;
        /// <summary>
        /// ボタンの縦
        /// </summary>
        const int BUTTON_SIZE_Y = 100;


        /// <summary>
        /// ボタンが横に何個並ぶか
        /// </summary>
        const int BOARD_SIZE_X = 3;
        /// <summary>
        /// ボタンが縦に何個並ぶか
        /// </summary>
        const int BOARD_SIZE_Y = 3;
        private TextButton[,] _buttonArray;

        public Form1()
        {
            InitializeComponent();
            _buttonArray = new TextButton[BOARD_SIZE_Y, BOARD_SIZE_X];

            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                    // インスタンスの生成
                    TextButton testButton =
                        new TextButton(new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j)
                                     , new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "");
                    _buttonArray[j, i] = testButton;

                    testButton.SetEnable(false);

                    // コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }

            _buttonArray[0,1].SetEnable(true);
        }

        // 自動生成
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("クリック");
        }
    }
}