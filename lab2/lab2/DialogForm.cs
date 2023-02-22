using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static lab2.Account;

namespace lab2
{
    public partial class DialogForm : Form
    {
        public List<Account> accounts;
        public DialogForm(List<Account> accounts)
        {
            InitializeComponent();
            this.accounts = accounts;
            typeDealog.KeyPress += (sender, e) => e.Handled = true;

        }
        private void checksearch_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = checkDialog.Checked;
            label3.Visible = checkDialog.Checked;
            label4.Visible = checkDialog.Checked;
            nameDialog.Visible = checkDialog.Checked;
            balanceDialog.Visible = checkDialog.Checked;
            typeDealog.Visible = checkDialog.Checked;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var temp = accounts;
            listBox1.Items.Clear();
            if (!checkDialog.Checked)
            {
                var str = textSearch.Text;
                var reg = new Regex(str);
                foreach (var i in accounts)
                {
                    if (reg.IsMatch(i.ToString()))
                    {
                        listBox1.Items.Add(i);
                        
                    }
                }
                return;
            }
            else
            {
                if (nameDialog.Text != "")
                {
                    accounts = accounts.Where(x => x.owner.Name.Equals(nameDialog.Text)).ToList();
                }
                if (balanceDialog.Text != "")
                {
                    accounts = accounts.Where(x => x.Balance == (int.TryParse(balanceDialog.Text, out var result) ? result : Int32.MaxValue)).ToList();
                }
                if (typeDealog.Text != "")
                {
                    accounts = accounts.Where(x =>
                    {
                        if (typeDealog.Text == "Закрытый")
                        {
                            return x.Type == Account.Types.closed;
                        }
                        else
                            return x.Type == Account.Types.open;
                    }).ToList();
                }
            }
            foreach (var item in accounts)
            {
                listBox1.Items.Add(item);
            }
            accounts = temp;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("Search.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
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
        private void balance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.Match(e.KeyChar.ToString(), @"[0-9]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
