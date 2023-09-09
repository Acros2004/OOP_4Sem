using lab9.DataModel;
using lab9.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab9
{
    /// <summary>
    /// Логика взаимодействия для AddAuthor.xaml
    /// </summary>
    public partial class AddAuthor : Window
    {
        bool flag = false;
        Author temp;
        public AddAuthor()
        {
            InitializeComponent();  
        }
        public AddAuthor(int id)
        {
            UnitOfWork unit = new UnitOfWork();
            InitializeComponent();
            TextBox_id.IsReadOnly = true ;
            TextBox_id.Text = id.ToString();
            flag= true;
            temp = unit.Authors.Get(id);
            TextBox_name.Text = temp.name;
            TextBox_planeId.Text = temp.bookID.ToString();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            var transaction = db.Database.BeginTransaction();
            UnitOfWork unit = new UnitOfWork();
            if (!flag)
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_planeId.Text == "")
                {
                    MessageBox.Show("Заполните данные");
                    return;
                }
                Author author = new Author();
                author.id = Convert.ToInt32(TextBox_id.Text);
                author.name = TextBox_name.Text;
                author.bookID = Convert.ToInt32(TextBox_planeId.Text);

                unit.Authors.Create(author);
            }
            else
            {
                if(TextBox_id.Text == ""|| TextBox_name.Text == ""|| TextBox_planeId.Text == "")
                {
                    MessageBox.Show("Заполните данные");
                    return;
                }
                temp.name = TextBox_name.Text;
                temp.bookID = Convert.ToInt32(TextBox_planeId.Text);
                unit.Authors.Update(temp);
               
            }
            unit.Save();
            transaction.Commit();
            this.Close();

        }
    }
}
