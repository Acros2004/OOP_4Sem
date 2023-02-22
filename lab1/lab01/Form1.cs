using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    public partial class Form1 : Form , ICalculator
    {
        
        public string firstNumber;
        public bool secondNumberFlag;
        public bool resaultFlag = false;
        public bool operationFlag = false;
        public string operation;
        public int Max = 10;
        int temp = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void OneInput_Click(object sender, EventArgs e)
        {
            try
            {
                Button Butt = (Button)sender;
                if (inputTextBox.Text.Length < Max)
                {
                    if (inputTextBox.Text == "0")
                    {
                        inputTextBox.Text = Butt.Text;
                    }
                    else
                    {
                        inputTextBox.Text = inputTextBox.Text + Butt.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Слишком длинное число");
                    ClearLowInput_Click(sender, e);
                }
            }
            catch (PersonException ex) 
            {
                MessageBox.Show(ex.Message);
                ClearLowInput_Click(sender, e);
            }
            
        }
        public void ClearLowInput_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "0";
            comboBox1.Text = "Bin";
            resaultBox.Text = "0";
            temp = 0;
        }
        private void ClearInput_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "0";
            comboBox1.Text = "Bin";
            resaultBox.Text = "0";
            temp = 0;
            secondNumberFlag = false;
            operationFlag= false;
            resaultFlag = false;
        }

        private void OperationInput_Click(object sender, EventArgs e)
        {
            Button Butt = (Button)sender;
            operation = Butt.Text;
            if (!resaultFlag)
            {
                firstNumber = inputTextBox.Text;
            }
            if(Butt.Text != "~")
            {
                secondNumberFlag = true;
                inputTextBox.Text = "0";
            }
            operationFlag = true;
        }
        private void EquallyInput_Click(object sender, EventArgs e)
        {
            int tempNumberFirst = Convert.ToInt32(firstNumber, 2);
            int tempNumberSecond = Convert.ToInt32(inputTextBox.Text, 2);
            if (!resaultFlag)
            {
                temp = Convert.ToInt32(inputTextBox.Text, 2);
            }
            else temp = tempNumberFirst;
            try
            {
                if (operationFlag)
                {
                    try
                    {
                        switch (operation)
                        {
                            case "&&":
                                AND(tempNumberFirst, tempNumberSecond);
                                break;
                            case "|":
                                OR(tempNumberFirst, tempNumberSecond);
                                break;
                            case "^":
                                XOR(tempNumberFirst, tempNumberSecond);
                                break;
                            case "~":
                                NOT(tempNumberFirst);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new PersonException(ex.Message, sender, e);
                    }
                    
                }
            
            
                switch (comboBox1.Text)
                {
                    case "Oct":
                        resaultBox.Text = Convert.ToString(temp, 8);
                        firstNumber = Convert.ToString(temp, 2);
                        break;
                    case "Dec":
                        resaultBox.Text = Convert.ToString(temp, 10);
                        firstNumber = Convert.ToString(temp, 2);
                        break;
                    case "Hex":
                        resaultBox.Text = Convert.ToString(temp, 16);
                        firstNumber = Convert.ToString(temp, 2);
                        break;
                    case "Bin":
                    default:
                        resaultBox.Text = Convert.ToString(temp, 2);
                        firstNumber = Convert.ToString(temp, 2);
                        break;
                }
                operationFlag = false;
                secondNumberFlag = false;
                resaultFlag = true;
                temp = 0;
            }
            catch (PersonException ex)
            {
                MessageBox.Show(ex.Message);
                ClearInput_Click(sender, e);
            }
        }
        public void AND(int first, int second)
        {
            temp = first & second;
        }

        public void OR(int first, int second)
        {
            temp = first | second;
        }

        public void XOR(int first, int second)
        {
            temp = first ^ second;
        }

        public void NOT(int first)
        {
            if (secondNumberFlag)
            {
                throw new Exception("Некорректные данные!\n" +
                    "Операция НЕ: введите только 1 число");
            }
            else
            {
                string number = Convert.ToString(first, 2);
                string resault = "";
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] == '1')
                    {
                        resault += "0";
                    }
                    else if (number[i] == '0')
                    {
                        resault += "1";
                    }
                }
                temp = Convert.ToInt32(resault,2);
            }
        }

       
    }
}
