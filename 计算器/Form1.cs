using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class MainForm : Form
    {
        //-----------------------------------------------------
        char tmp;
        int number = 0, check = 0, numberTmp = 0;
        Nullable<double> num1 = null, num2 = null, sum = null, sumTmp = null;
        //-----------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
            tmp = ' ';
            number = 0;
            textBoxTmp.Text = "";
            _screen.Text = ("\r\n" + "0");
        }
        //键盘事件-----------------------------------------------------
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    {
                        button0.PerformClick();
                        break;
                    }
                case Keys.NumPad1:
                    {
                        button1.PerformClick();
                        break;
                    }
                case Keys.NumPad2:
                    {
                        button2.PerformClick();
                        break;
                    }
                case Keys.NumPad3:
                    {
                        button3.PerformClick();
                        break;
                    }
                case Keys.NumPad4:
                    {
                        button4.PerformClick();
                        break;
                    }
                case Keys.NumPad5:
                    {
                        button5.PerformClick();
                        break;
                    }
                case Keys.NumPad6:
                    {
                        button6.PerformClick();
                        break;
                    }
                case Keys.NumPad7:
                    {
                        button7.PerformClick();
                        break;
                    }
                case Keys.NumPad8:
                    {
                        button8.PerformClick();
                        break;
                    }
                case Keys.NumPad9:
                    {
                        button9.PerformClick();
                        break;
                    }
                case Keys.Add:
                    {
                        buttonAdd.PerformClick();
                        break;
                    }
                case Keys.Subtract:
                    {
                        buttonSub.PerformClick();
                        break;
                    }
                case Keys.Multiply:
                    {
                        buttonMul.PerformClick();
                        break;
                    }
                case Keys.Divide:
                    {
                        buttonDiv.PerformClick();
                        break;
                    }
                case Keys.Decimal:
                    {
                        buttonPoint.PerformClick();
                        break;
                    }
                case Keys.Back:
                    {
                        _backspace.PerformClick();
                        break;
                    }
            }
        }

        public void CacularWith(int number)
        {//连续算数实现方法
            switch (number)
            {
                case 1:
                    {
                        check = 1;
                        number = 1;
                        //tmp = '+';
                        if (textBoxTmp.Text == "")
                        {
                            return;
                        }else
                        {
                            num2 = Convert.ToDouble(textBoxTmp.Text);
                        }
                        
                        num1 = num1 + num2;
                        textBoxTmp.Clear(); _screen.Clear();
                        _screen.Text = (num1.ToString() + tmp + "\r\n");
                        break;
                    }
                case 2:
                    {
                        check = 1;
                        number = 2;
                        //tmp = '-';
                       // _screen.Text = (num1 + tmp + "\r\n");
                        if (textBoxTmp.Text == "")
                        {
                            return;
                        }
                        else
                        {
                            num2 = Convert.ToDouble(textBoxTmp.Text);
                        }
                        num1 = num1 - num2;
                        textBoxTmp.Clear(); _screen.Clear();
                        _screen.Text = (num1.ToString() + tmp + "\r\n");
                        break;
                    }
                case 3:
                    {
                        check = 1;
                        number = 3;
                        //tmp = '×';
                        //_screen.Text = (num1 + tmp + "\r\n");
                        if (textBoxTmp.Text == "")
                        {
                            return;
                        }
                        else
                        {
                            num2 = Convert.ToDouble(textBoxTmp.Text);
                        }
                        num1 = num1 * num2;
                        textBoxTmp.Clear();
                        _screen.Clear();
                        _screen.Text = (num1.ToString() + tmp + "\r\n");
                        break;
                    }
                case 4:
                    {
                        check = 1;
                        number = 4;
                        //tmp = '÷';
                        if (textBoxTmp.Text == "")
                        {
                            return;
                        }
                        else
                        {
                            num2 = Convert.ToDouble(textBoxTmp.Text);
                            if (num2 == 0)
                            {
                                textBoxTmp.Clear();
                                _screen.Text = ("\r\n无意义的值");
                                num1 = 0;
                                break;
                            }
                            else
                            {
                                //tmp = '÷';
                                num1 = num1 / num2;
                                textBoxTmp.Clear(); _screen.Clear();
                                _screen.Text = (num1.ToString() + tmp + "\r\n");
                                break;
                            }
                        }
                    }
                case 0:
                    {
                        break;
                    }
            }
        }

        private void _clear_Click(object sender, EventArgs e)
        {//归零点击事件
            tmp = ' ';
            number = 0;
            numberTmp = 0;
            textBoxTmp.Text = "";
            _screen.Text = ("\r\n" + "0");
            num1 = null;num2 = null;sum = null;check = 0;sumTmp = null;
        }

        private void ButtonCaculer(string s,int number)
        {//数值按钮按下计算sum值
            if (num2 != null && sum == null) 
            {
                sumTmp = null;
            }
            textBoxTmp.Text = (textBoxTmp.Text + s);
            if (num1 == null)
            {
                _screen.Text = (tmp + "\r\n" + textBoxTmp.Text);
            }
            else
            {
                _screen.Text = (num1.ToString() + tmp + "\r\n" + textBoxTmp.Text);
            }
            if (sumTmp != null)
            {
                sumTmp = null;
            }
            numberTmp = number;
        }

        private void button1_Click(object sender, EventArgs e)
        {//1点击事件
            //textBoxTmp.Text = (textBoxTmp.Text + "1");
            //_screen.Text = (tmp+"\r\n"+textBoxTmp.Text);
            ButtonCaculer("1", number);
        }

        private void button2_Click(object sender, EventArgs e)
        {//2
            //textBoxTmp.Text = (textBoxTmp.Text + "2");
            //_screen.Text = (tmp+"\r\n" + textBoxTmp.Text);
            ButtonCaculer("2", number);
        }

        private void button3_Click(object sender, EventArgs e)
        {//3
            ButtonCaculer("3", number);
        }

        private void button4_Click(object sender, EventArgs e)
        {//4
            ButtonCaculer("4", number);
        }

        private void button5_Click(object sender, EventArgs e)
        {//5
            ButtonCaculer("5", number);
        }

        private void button6_Click(object sender, EventArgs e)
        {//6
            ButtonCaculer("6", number);
        }

        private void button7_Click(object sender, EventArgs e)
        {//7
            ButtonCaculer("7", number);
        }

        private void button8_Click(object sender, EventArgs e)
        {//8
            ButtonCaculer("8", number);
        }

        private void button9_Click(object sender, EventArgs e)
        {//9
            ButtonCaculer("9", number);
        }

        private void button0_Click(object sender, EventArgs e)
        {//0
            ButtonCaculer("0", number);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {//.
            textBoxTmp.Text = (textBoxTmp.Text + ".");
            _screen.Text = (tmp+"\r\n" + textBoxTmp.Text);
        }

        private void _backspace_Click(object sender, EventArgs e)
        {//退格点击事件
            if (textBoxTmp.Text == "")
            {
                tmp = ' ';
                number = 0;
            }
            int _tmp = textBoxTmp.Text.ToString().Length;
            if (_tmp > 1)
            {
                textBoxTmp.Text = textBoxTmp.Text.Remove(_tmp - 1, 1);
                _screen.Text = (tmp+"\r\n" + textBoxTmp.Text);
            }
            else
            {

                textBoxTmp.Clear();
                _screen.Text = ("\r\n");
            }
        }

        private void CheckCacular(char c,int _number)
        {
            tmp = c;
            if (sumTmp != null)
            {
                textBoxTmp.Text = (sumTmp.ToString());
            }
            if (num1 != null)
            {
                number = _number;
            }
            CacularWith(numberTmp);
            if (check == 1)
            {
                return;
            }
            if (textBoxTmp.Text == "")
            {
                _screen.Text = (num1.ToString() + tmp + "\r\n");
            }
            else
            {
                _screen.Text = (textBoxTmp.Text + tmp + "\r\n");
            }
            

            if (num1 == null && textBoxTmp.Text == "")
            {//防止出现赋空值
                number = 0;
                return;
            }
            number = _number;
            if (num1 != null)
            {
                textBoxTmp.Text = num1.ToString();
            }
            num1 = Convert.ToDouble(textBoxTmp.Text);
            
            textBoxTmp.Clear();
        }
        //复制到剪贴板
        private void _buttonCopy_Click(object sender, EventArgs e)
        {
            if (sumTmp != null)
            {
                Clipboard.SetDataObject(sumTmp.ToString());
                MessageBox.Show("目标已复制到剪贴板,按Ctrl+v粘贴","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {//+
            CheckCacular('+', 1);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {//-
            CheckCacular('-', 2);

        }

        private void buttonMul_Click(object sender, EventArgs e)
        {//×
            CheckCacular('×',3);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {//÷
            CheckCacular('÷', 4);
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {//=
            if (textBoxTmp.Text == "")
            {
                return;
            }
            switch (number)
            {
                case 1:
                    {
                        num2 = Convert.ToDouble(textBoxTmp.Text);
                        sum = num1 + num2;
                        textBoxTmp.Text = "";
                        _screen.Text = ("\r\n" + sum);
                        break;
                    }
                case 2:
                    {
                        num2 = Convert.ToDouble(textBoxTmp.Text);
                        sum = num1 - num2;
                        textBoxTmp.Clear();
                        _screen.Text = ("\r\n" + sum);
                        break;
                    }
                case 3:
                    {
                        num2 = Convert.ToDouble(textBoxTmp.Text);
                        sum = num1 * num2;
                        textBoxTmp.Clear();
                        _screen.Text = ("\r\n" + sum);
                        break;
                    }
                case 4:
                    {
                        num2 = Convert.ToDouble(textBoxTmp.Text);
                        if (num2 == 0)
                        {
                            textBoxTmp.Clear();
                            _screen.Text = ("\r\n无意义的值");
                            num1 = 0;
                            break;
                        }
                        else
                        {
                            sum = num1 / num2;
                            textBoxTmp.Clear();
                            _screen.Text = ("\r\n" + sum);
                            break;
                        }
                    }
            }
            check = 0; numberTmp = 0;number = 0;tmp = ' ';
            sumTmp = sum;sum = null;num1 = null;
        }
    }
}
