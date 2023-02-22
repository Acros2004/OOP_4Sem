using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace lab2
{
    public partial class Form1 : Form
    {
        public NHist histForBack = new NHist();
        NHist histForForward = new NHist();
        bool flagVisible = true;
        public List<Account> accounts;
        public Form1()
        {
            InitializeComponent();
            accounts = new List<Account>();
            type.KeyPress += (sender, e) => e.Handled = true;
            System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            Timer.Start();
            Timer.Tick += Tick;
        }
        public Saf SaveData()
        {
            return new Saf(ref accounts);
        }
        public void RestoreDataBack(Saf data)
        {
            histForForward.Form.Push(SaveData());
            accounts = data.accounts2;
        }
        public void RestoreDataForward(Saf data)
        {
            histForBack.Form.Push(SaveData());
            accounts = data.accounts2;
        }
        private void Tick(object sender, EventArgs e)
        {
            toolStripLabel7.Text = DateTime.Now.ToString();
            
        }
        private void balance_Scroll(object sender, EventArgs e)
        {
            label6.Text = $"Баланс: {(sender as TrackBar).Value}";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                histForBack.Form.Push(SaveData());
                var account = new Account(int.Parse(number.Text), Account.Types.open, balance.Value, opendate.Value, sms.Checked, new Owner()
                {
                    Birthdate = opendate.Value,
                    Name = name.Text,
                    Passport = passport.Text,
                });
                
                if (!sms.Checked)
                    account.Type = Account.Types.closed;
                if (type.Text == "Закрытый")
                {
                    account.Type = Account.Types.closed;
                }
                ValidationContext context = new ValidationContext(account, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                ValidationContext context2 = new ValidationContext(account.owner, null, null);
                
                if (!Validator.TryValidateObject(account, context, errors, true) || !Validator.TryValidateObject(account.owner, context2, errors, true))
                {
                    foreach (ValidationResult result in errors)
                        MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    MessageBox.Show("Одобрен!");
                    listBox1.Items.Add(account);
                    accounts.Add(account);
                }
            }
            catch
            {
                
                if (balance.Value == 0 && number.Text == "" && type.Text == "Закрытый" && name.Text == "")
                {
                    MessageBox.Show("!!! Рандомное заполнение !!!");
                }
                else
                {
                    MessageBox.Show("!!! НЕ корректно запоненная форма !!!");
                    this.Clear_Click(sender, e);
                }
            }
        }
        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account currentaccount = (Account)listBox1.SelectedItem;
            LoginAccountForm login = new LoginAccountForm(currentaccount,toolStripLabel6,accounts,listBox1);
            login.Show();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            balance.Value = 0;
            number.Text = "";
            type.Text = "Закрытый";
            name.Text = "";
            passport.Text = "";
            sms.Checked = false;
            label3.Text = $"Баланс ";
        }
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.Match(e.KeyChar.ToString(), @"[0-9]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("file.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            histForBack.Form.Push(SaveData());
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("file.xml", FileMode.Open))
            {
                accounts = serializer.Deserialize(stream) as List<Account>;
                listBox1.Items.Clear();
                foreach (var t in accounts)
                {
                    listBox1.Items.Add(t);
               
                }
            }
            
        }
        private void programInfotoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Durka version: 1.0.0\nDeveloper: Nikita");
        }
        private void exittoolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Search = new DialogForm(accounts);
            Search.ShowDialog();
        }
        private void поНомеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.num).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("Sort.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
        }
        private void поГодуОткрытияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.OpeningDate).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("Sort.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
        }
        private void типВкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.Type).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("Sort.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (flagVisible)
            {
                flagVisible= false;
                toolStripLabel1.Visible = false;
                toolStripLabel3.Visible = false;
                toolStripLabel4.Visible = false;
                toolStripLabel5.Visible = false;
                toolStripLabel6.Visible = false;
                toolStripLabel7.Visible = false;
                toolStripLabel8.Visible = false;
            }
            else
            {
                flagVisible = true;
                toolStripLabel1.Visible = true;
                toolStripLabel3.Visible = true;
                toolStripLabel4.Visible = true;
                toolStripLabel5.Visible = true;
                toolStripLabel6.Visible = true;
                toolStripLabel7.Visible = true;
                toolStripLabel8.Visible = true;
            }

        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            try
            {
                if(histForBack.Form.Count > 0)
                {
                    listBox1.Items.Clear();
                    listBox1.Refresh();
                    RestoreDataBack(histForBack.Form.Pop());
                    foreach (Account account in accounts)
                    {
                        listBox1.Items.Add(account);
                    }
                }
                else
                {
                    MessageBox.Show("Стек пуст,назад нельзя");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            try
            {
                if(histForForward.Form.Count > 0)
                {
                    listBox1.Items.Clear();
                    listBox1.Refresh();
                    RestoreDataForward(histForForward.Form.Pop());
                    foreach (Account account in accounts)
                    {
                        listBox1.Items.Add(account);
                    }
                }
                else
                {
                    MessageBox.Show("Стек пуст,вперёд нельзя");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}