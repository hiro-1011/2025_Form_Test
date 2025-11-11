using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sourcetreeを信じるな

namespace Form_Test
{
    public partial class Form1 : Form
    {
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        private TestButton[,] _buttonArray;
        private Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();

            _buttonArray = new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];

            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                   
                    TestButton testButton =
                        new TestButton(this, i, j,
                                     new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "");
                    _buttonArray[j, i] = testButton;

                    // フォームに追加
                    Controls.Add(testButton);
                }
            }

            // 初期盤面をランダムに設定
            ResetBoard();
        }

        // 盤面をランダムに初期化
        public void ResetBoard()
        {
            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    bool randomState = _rand.Next(2) == 0;
                    _buttonArray[y, x].SetEnable(randomState);
                }
            }
        }

        // ボタン取得
        public TestButton GetTestButton(int x, int y)
        {
            if (x < 0 || x >= BOARD_SIZE_X) return null;
            if (y < 0 || y >= BOARD_SIZE_Y) return null;
            return _buttonArray[y, x];
        }

        // クリア判定
        public void CheckClear()
        {
            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    if (!_buttonArray[y, x].IsEnabled())
                    {
                        return; // まだOFFがある
                    }
                }
            }

            MessageBox.Show("こんなゲームにまじになっちゃってどうするの");

            ResetBoard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("クリック");
        }
    }
}
