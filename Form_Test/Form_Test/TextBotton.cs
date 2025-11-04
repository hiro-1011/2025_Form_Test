using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public class TestButton : Button
    {
        private Color _onColor = Color.Aquamarine;

        private Color _offColor = Color.Blue;

        private bool _enable;

        private Form1 _form1;

        private int _x;

        private int _y;

        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
        }

        public void Toggle()
        {
            SetEnable(!_enable);
        }


        public TestButton(Form1 form1, int x, int y,Size size, string text)
        {

            _x = x;
            _y = y;
            //Form1の参照を保管
            _form1 = form1;


            // ボタンの位置を設定
            Location = new Point(x * size.Width, y * size.Height);
            // ボタンの大きさを設定
            Size = size;
            // ボタン内のテキストを設定
            Text = text;

            SetEnable(false);

            Click += ClickEvent;
        }


        // 自分で作成することも可能
        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(_x, _y)?.Toggle();
            _form1.GetTestButton(_x+1, _y)?.Toggle();
            _form1.GetTestButton(_x-1, _y)?.Toggle();
            _form1.GetTestButton(_x, _y+1)?.Toggle();
            _form1.GetTestButton(_x, _y-1)?.Toggle();
        }
    }
}