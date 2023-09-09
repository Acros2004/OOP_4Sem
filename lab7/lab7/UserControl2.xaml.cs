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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab7
{
    /// <summary>
    /// Логика взаимодействия для UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public static readonly DependencyProperty TitleProperty;
        public UserControl2()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name myName = (Name)this.Resources["Nikita"]; // получаем ресурс по ключу
            MessageBox.Show(myName.TextName.ToString());
        }
    }
}
