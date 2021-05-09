using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Calc
{
    public enum Modes { First=1,Second,Trigono}
    public enum Operations { Add=1,Minus,Mult,Div};
    public enum TrigonoModes { Sin =1, Cos, Tang};
    
    delegate decimal Operation(decimal one, decimal two);
    
    public partial class Form1 : Form
    {
        private TrigonoModes trigmode;
        private Operations operation;
        //public static decimal Add(decimal one, decimal two)
        //{
        //    return one + two;
        //}
        //public static decimal Minus(decimal one, decimal two)
        //{
        //    return one - two;
        //}
        //Operation operation;
        Modes mode = Modes.First;
        bool firstMinus = false;
        // decimal first = 0;
        // decimal second = 0;
        bool [] commas= new bool[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.mode = Modes.First;
            this.displayTxtBox.Text = "0";
            for (int i = 0; i < commas.Length; i++)
            {
                commas[i] = false;
            }
        }
        private bool TrigonoCheck(byte num)
        {
            if (mode == Modes.Trigono)
            {
                if (displayTxtBox.Text.Length == 4)
                {
                    displayTxtBox.Text += num;
                    return true;
                }
                if (displayTxtBox.Text.Length == 5 && displayTxtBox.Text[4] == '0')
                {
                    displayTxtBox.Text = displayTxtBox.Text.Remove(4);
                    displayTxtBox.Text = displayTxtBox.Text.Insert(4, num.ToString());
                    return true;
                }

            }
                return false;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (TrigonoCheck(1))
            {
                return;
            }
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "1";
                return;
            }
            displayTxtBox.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (TrigonoCheck(2))
            {
                return;
            }
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "2";
                return;
            }
            displayTxtBox.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (TrigonoCheck(3))
            {
                return;
            }
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "3";
                return;
            }
            displayTxtBox.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (TrigonoCheck(4))
            {
                return;
            }
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "4";
                return;
            }
            displayTxtBox.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (TrigonoCheck(5))
            {
                return;
            }
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "5";
                return;
            }
            displayTxtBox.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (TrigonoCheck(6))
            {
                return;
            }
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "6";
                return;
            }
            displayTxtBox.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (TrigonoCheck(7))
            {
                return;
            }
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "7";
                return;
            }
            displayTxtBox.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (TrigonoCheck(8))
            {
                return;
            }
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "8";
                return;
            }
            displayTxtBox.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (TrigonoCheck(9))
            {
                return;
            }
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "9";
                return;
            }
            displayTxtBox.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (displayTxtBox.Text == "0")
            {
                displayTxtBox.Text = "0";
                return;
            }
            if (mode== Modes.Trigono)
            {
                if (displayTxtBox.Text.Length == 5 && displayTxtBox.Text[4] == '0')
                {
                    return;
                }
            }
            if (mode == Modes.Second)
            {
                String str = this.displayTxtBox.Text;
                char symb = ' ';
                if (str[0] == '-')
                {
                    str = str.Remove(0);
                }
                switch (operation)
                {
                    case Operations.Add:
                        symb = '+';
                        break;
                    case Operations.Minus:
                        symb = '-';
                        break;
                    case Operations.Mult:
                        symb = '*';
                        break;
                    case Operations.Div:
                        symb = '/';
                        break;
                    default:
                        break;
                }
                int indexafterplus = str.IndexOf(symb);
                if (indexafterplus+1 >= str.Length)
                {
                    displayTxtBox.Text += '0';
                    return;
                }
                if (str[indexafterplus+1]=='0')
                {
                    return;
                }
            }
            displayTxtBox.Text += '0';
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if (mode == Modes.Second)
            {
                return;
            }
            this.mode = Modes.Second;
            operation = Operations.Add;
            //this.operation = Add;
            //this.first = Decimal.Parse(this.displayTxtBox.Text);
            this.displayTxtBox.Text += '+';
            System.Diagnostics.Debug.WriteLine($"{System.Environment.NewLine} Hui {System.Environment.NewLine}");
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (mode == Modes.First)
            {
                return;
            }
            else if (mode == Modes.Trigono)
            {
                int index = displayTxtBox.Text.IndexOf('(');
                if (++index >= displayTxtBox.Text.Length)
                {
                    return;
                }
                string res = displayTxtBox.Text.Substring(index);
                switch (trigmode)
                {
                    case TrigonoModes.Sin:
                        displayTxtBox.Text = Math.Sin(Double.Parse(res)).ToString();
                        break;
                    case TrigonoModes.Cos:
                        displayTxtBox.Text = Math.Cos(Double.Parse(res)).ToString();
                        break;
                    case TrigonoModes.Tang:
                        displayTxtBox.Text = Math.Tan(Double.Parse(res)).ToString();
                        break;
                    default:
                        break;
                }
                
                mode = Modes.First;

            }
            try { 
            string value = this.displayTxtBox.Text;
            value = value.Replace(',', '.');
            System.Diagnostics.Debug.WriteLine($"{System.Environment.NewLine} {value} {System.Environment.NewLine}");
            this.displayTxtBox.Text = (new DataTable().Compute(value, null)).ToString();
            //String str = this.displayTxtBox.Text;
            //char symb =' ';
            //switch (operation.Method.Name)
            //{
            //    case "Add":
            //        symb = '+';
            //        break;

            //    default:
            //        break;
            //}
            ////char[] symb = { '+', '-', '*', '/' };
            //str.Replace(',','.');
            //int indexafterplus = str.IndexOf(symb) + 1;
            //this.second = Decimal.Parse(str.Substring(indexafterplus, str.Length- indexafterplus));
            //this.displayTxtBox.Text = (operation?.Invoke(first,second)).ToString();
            this.mode = Modes.First;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comaBtn_Click(object sender, EventArgs e)
        {
            
            if (displayTxtBox.Text.Length<=0)
            {
                return;
            }
            if (mode == Modes.First)
            {
                if (commas[0] == true)
                {
                    return;
                }
                commas[0] = true;
            }
            else if (mode == Modes.Second)
            {
                if (commas[1] == true)
                {
                    return;
                }
                commas[1] = true;
            }
            displayTxtBox.Text += ',';
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (mode == Modes.Second)
            {
                return;
            }
            this.mode = Modes.Second;
            operation = Operations.Minus;
            //this.operation = Minus;
            //this.first = Decimal.Parse(this.displayTxtBox.Text);
            this.displayTxtBox.Text += '-';
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            if (mode == Modes.Second)
            {
                return;
            }
            this.mode = Modes.Second;
            operation = Operations.Mult;
            this.displayTxtBox.Text += '*';
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (mode == Modes.Second)
            {
                return;
            }
            this.mode = Modes.Second;
            operation = Operations.Div;
            this.displayTxtBox.Text += '/';
        }

        private void clearOneBtn_Click(object sender, EventArgs e)
        {
            if (displayTxtBox.Text.Length <= 0)
            {
                return;
            }
            var str = displayTxtBox.Text;
            char last = str[str.Length - 1];
            char[] symbols = new char[] { '+','-','*','/'};
            bool have = false;
            for (int i = 0; i < symbols.Length; i++)
            {
                if (last == symbols[i])
                {
                    have = true;
                    break;
                }
            }
            if (have)
            {
                mode = Modes.First;
            }
            displayTxtBox.Text = displayTxtBox.Text.Remove(str.Length - 1, 1);
        }

        private void changleSymbBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (displayTxtBox.Text.Length <= 0 || displayTxtBox.Text == "0")
                {
                    return;
                }
                if (mode == Modes.First)
                {
                    if (displayTxtBox.Text[0] == '-')
                    {
                        displayTxtBox.Text = displayTxtBox.Text.Remove(0, 1);
                        firstMinus = false;
                    }
                    else
                    {
                        displayTxtBox.Text = displayTxtBox.Text.Insert(0, "-");
                        firstMinus = true;
                    }
                }
                else if (mode == Modes.Second)
                {
                    char[] operations = { '+', '-', '*', '/' };
                    int index = displayTxtBox.Text.IndexOfAny(operations);
                    if (firstMinus)
                    {
                        string tmp = displayTxtBox.Text.Remove(0, 1);
                        index = tmp.IndexOfAny(operations);
                    }
                    if (displayTxtBox.Text[index + 2] == '-')
                    {
                        displayTxtBox.Text = displayTxtBox.Text.Remove(index + 1, 1);
                        return;
                    }
                    displayTxtBox.Text = displayTxtBox.Text.Insert(index+2, "-");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bigRb_AppearanceChanged(object sender, EventArgs e)
        {
            
        }

        private void modesGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void littleRb_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void littleRb_CheckedChanged(object sender, EventArgs e)
        {
            if (bigRb.Checked)
            {
                this.angleGroupBox.Visible = true;
                this.buttonsGroupBox.Height = 580;
                this.Height = 600;
                SetTrigonometricFuncVisisble(true);
            }
            else
            {
                this.angleGroupBox.Visible = false;
                this.Width = 510;
                this.Height = 470;
                this.buttonsGroupBox.Height = 409;
                SetTrigonometricFuncVisisble(false);
            }
        }
        private void SetTrigonometricFuncVisisble(bool visible)
        {
            this.cosBtn.Visible = visible;
            this.sinBtn.Visible = visible;
            this.tanBtn.Visible = visible;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.angleGroupBox.Visible = false;
            this.Width = 510;
            this.Height = 470;
            SetTrigonometricFuncVisisble(false);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Alt)
            {
                changleSymbBtn_Click(null, null);
            }
            else if (e.KeyCode == Keys.Back)
            {
                clearOneBtn_Click(null, null);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                plusBtn_Click(null, null);
            }
            else if (e.KeyChar == '1')
            {
                btn1_Click(null,null);
                //this.InvokeOnClick(btn1, EventArgs.Empty);
            }
            else if (e.KeyChar=='2')
            {
                btn2_Click(null, null);
            }
            else if (e.KeyChar == '3')
            {
                btn3_Click(null, null);
            }
            else if (e.KeyChar == '4')
            {
                btn4_Click(null, null);
            }
            else if (e.KeyChar == '5')
            {
                btn5_Click(null, null);
            }
            else if (e.KeyChar == '6')
            {
                btn6_Click(null, null);
            }
            else if (e.KeyChar == '7')
            {
                btn7_Click(null, null);
            }
            else if (e.KeyChar == '8')
            {
                btn8_Click(null, null);
            }
            else if (e.KeyChar == '9')
            {
                btn9_Click(null, null);
            }
            else if (e.KeyChar == '0')
            {
                btn0_Click(null, null);
            }
            else if (e.KeyChar == '-')
            {
                minusBtn_Click(null, null);
            }
            else if (e.KeyChar == '/')
            {
                divBtn_Click(null, null);
            }
            else if (e.KeyChar == ',')
            {
                comaBtn_Click(null, null);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                equalsBtn_Click(null, null);
            }
        }

        private void sinBtn_Click(object sender, EventArgs e)
        {
            mode = Modes.Trigono;
            trigmode = TrigonoModes.Sin;
            this.displayTxtBox.Text = "sin(";
        }

        private void cosBtn_Click(object sender, EventArgs e)
        {
            mode = Modes.Trigono;
            trigmode = TrigonoModes.Cos;
            this.displayTxtBox.Text = "cos(";
        }

        private void tanBtn_Click(object sender, EventArgs e)
        {
            mode = Modes.Trigono;
            trigmode = TrigonoModes.Tang;
            this.displayTxtBox.Text = "tg(";
        }
    }
}
