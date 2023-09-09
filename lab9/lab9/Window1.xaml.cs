using lab9.DataModel;
using lab9.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace lab9
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            var transaction = db.Database.BeginTransaction();
            UnitOfWork unit = new UnitOfWork();

            Book book = new Book
            {
                id = Convert.ToInt32(TextBox_id.Text),
                title = TextBox_Title.Text
            };

            unit.Books.Create(book);
            unit.Save();
            transaction.Commit();
            this.Close();
        }
    }
}
