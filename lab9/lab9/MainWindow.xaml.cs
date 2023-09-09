using lab9.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using lab9.Model;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace lab9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Model1 db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Model1();
            //Author author1 = new Author { id = 1, name = "author1", bookID = 6 };
            //Author author2 = new Author { id = 2, name = "author2", bookID = 7 };
            //Author author3 = new Author { id = 3, name = "author3", bookID = 6 };
            //db.Author.Add(author1);
            //db.Author.Add(author2);
            //db.Author.Add(author3);
            //db.SaveChanges();
            updateButton_Click(new object(),new RoutedEventArgs());
            Script.Items.Add("Сортировка по убыванию Id");
            Script.Items.Add("Сортировка по убыванию BookId");
            Script.Items.Add("Поиск по одному критерию name");
            Script.Items.Add("Поиск по двум критериям name и Id");
            this.Closing += MainWindow_Closing;
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            db.Author.Load();
            UnitOfWork unit = new UnitOfWork();
            authorGrid.Items.Clear();
            List<Author> list = db.Author.ToList();
            Author temp;
            foreach (var item in list)
            {
                temp = unit.Authors.Get(item.id);
                item.name = temp.name;
                authorGrid.Items.Add(item);
            }
        }
        private void addButton_Click(object sender,RoutedEventArgs e)
        {
            AddAuthor author= new AddAuthor();
            author.ShowDialog();
        }
        private void addButtonBook_Click(object sender, RoutedEventArgs e)
        {
            Window1 author = new Window1();
            author.ShowDialog();
        }
        private void deleteButton_Click(object sender,RoutedEventArgs e)
        {
            var transaction = db.Database.BeginTransaction();
            if (authorGrid.SelectedItems.Count > 0)
            {
                for(int i = 0; i < authorGrid.SelectedItems.Count; i++)
                {
                    Author author = authorGrid.SelectedItems[i] as Author;
                    if(author != null)
                    {
                        db.Author.Remove(author);
                    }
                }
            }
            db.SaveChanges();
            transaction.Commit();
            updateButton_Click(new object(), new RoutedEventArgs());
        }
        private void queryButton_Click(object sender, RoutedEventArgs e)
        {
            UnitOfWork unit = new UnitOfWork();
            if (Script.SelectedIndex == 0)
            {
                var temp = db.Author.OrderByDescending(c => c.id).ToList();
                authorGrid.Items.Clear();
                    Author temp1;
                    foreach (var item in temp)
                    {
                        temp1 = unit.Authors.Get(item.id);
                        item.name = temp1.name;
                        authorGrid.Items.Add(item);
                    }
            }
            else if (Script.SelectedIndex == 1)
            {
                var temp = db.Author.OrderByDescending(c => c.bookID).ToList();
                authorGrid.Items.Clear();
                Author temp1;
                foreach (var item in temp)
                {
                    temp1 = unit.Authors.Get(item.id);
                    item.name = temp1.name;
                    authorGrid.Items.Add(item);
                }
            }
            else if (Script.SelectedIndex == 2)
            {
                if (TextBox_Name.Text == "")
                {
                    MessageBox.Show("Боже, да укажи ты параметры поиска");
                    return;
                }
                SqlParameter param = new SqlParameter("@name", $"%{TextBox_Name.Text}%");
                var temp = db.Database.SqlQuery<Author>("Select * from Authors where name like @name", param).ToList();
                string str = "";
                foreach (Author item in temp)
                {
                    str += $"Имя:{item.name},Id:{item.id},BookID:{item.bookID}\n";
                }
                MessageBox.Show(str);
            }
            else if (Script.SelectedIndex == 3)
            {
                if(TextBox_Id.Text == "" || TextBox_Name.Text == "")
                {
                    MessageBox.Show("Боже, да укажи ты параметры поиска");
                    return;
                }
                int id = Convert.ToInt32(TextBox_Id.Text);
                var temp = db.Author.Where(c => c.name == TextBox_Name.Text && c.id == id).ToList();
                string str = "";
                foreach (Author item in temp)
                {
                    str += $"Имя:{item.name},Id:{item.id},BookID:{item.bookID}\n";
                }
                MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("Выберите вариант запроса");
                return;
            }
        }
        private void updateItemButton_Click(object sender, RoutedEventArgs e)
        {
            if(authorGrid.SelectedItems.Count > 0)
            {
                var author = authorGrid.SelectedItem as Author;
                AddAuthor window = new AddAuthor(author.id);
                window.ShowDialog();
                db.SaveChanges();
            }
        }
    }
}
