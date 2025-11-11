using System;
using System.Drawing;
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

        public TestButton(Form1 form1, int x, int y, Size size, string text)
        {
            _x = x;
            _y = y;
            _form1 = form1;

            // ボタンの位置とサイズを設定
            Location = new Point(x * size.Width, y * size.Height);
            Size = size;
            Text = text;

            SetEnable(false);

            Click += ClickEvent;
        }

        public void SetEnable(bool on)
        {
            _enable = on;
            BackColor = on ? _onColor : _offColor;
        }

        public void Toggle()
        {
            SetEnable(!_enable);
        }

        public bool IsEnabled()
        {
            return _enable;
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(_x, _y)?.Toggle();
            _form1.GetTestButton(_x + 1, _y)?.Toggle();
            _form1.GetTestButton(_x - 1, _y)?.Toggle();
            _form1.GetTestButton(_x, _y + 1)?.Toggle();
            _form1.GetTestButton(_x, _y - 1)?.Toggle();

            // クリック後にクリア判定
            _form1.CheckClear();
        }
    }
}

