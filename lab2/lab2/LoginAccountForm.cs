using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    
    public partial class LoginAccountForm : Form
    {
        ToolStripLabel label;
        Account temp;
        List<Account> accounts;
        ListBox list;
        public LoginAccountForm(Account account, ToolStripLabel label,List<Account> accounts,object list)
        {

            temp = account;
            InitializeComponent();
            textBox1.Text = temp.owner.Name;
            textBox2.Text = temp.owner.Passport;
            textBox3.Text = Convert.ToString(temp.Balance);
            this.label = label;
            this.accounts = accounts;
            this.list = (ListBox)list;
        }

        private void balance_Scroll(object sender, EventArgs e)
        {
            label5.Text = $"Выберите сумму: {(sender as TrackBar).Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(temp != null)
            {
                switch (comboBox1.Text)
                {
                    case "пополнить":
                        {
                            if(trackBar1.Value > 0)
                            {
                                temp.histories.Add(new History(DateTime.Now.ToString(), trackBar1.Value, "пополнить"));
                                temp.Balance += trackBar1.Value;
                                MessageBox.Show("Успешно");
                                label.Text = comboBox1.Text;
                                list.Items.Clear();
                                list.Refresh();
                                foreach (Account account in accounts)
                                {
                                    list.Items.Add(account);
                                }
                            }
                            break;
                        }
                    case "снять":
                        {
                            if (trackBar1.Value > 0 && trackBar1.Value < temp.Balance)
                            {
                                temp.histories.Add(new History(DateTime.Now.ToString(), trackBar1.Value, "снять"));
                                temp.Balance -= trackBar1.Value;
                                MessageBox.Show("Успешно");
                                label.Text = comboBox1.Text;
                                list.Items.Clear();
                                list.Refresh();
                                foreach (Account account in accounts)
                                {
                                    list.Items.Add(account);
                                }
                            }
                            else if (trackBar1.Value > temp.Balance)
                            {
                                MessageBox.Show("Недостаточно средств");
                                comboBox1.Text = "пополнить";
                                trackBar1.Value = 0;
                            }
                            break;
                        }
                }
            }
            this.Close();
            
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if(temp.histories.Count > 0)
            {
                string strTemp = "";
                foreach(var item in temp.histories)
                {
                    if(item.ToString() != ",  сумму:0")
                    {
                        strTemp += item.ToString();
                        strTemp += "\n";
                    }
                }
                if (strTemp == "") MessageBox.Show("Пусто");
                else MessageBox.Show(strTemp);
            }
            else MessageBox.Show("Пусто");
        }
       
    }
}
