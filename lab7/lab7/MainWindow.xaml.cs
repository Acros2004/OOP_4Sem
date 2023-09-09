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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBinding binding = new CommandBinding(Commands.Visible);
            binding.Executed += CommandBinding_Executed;

            this.CommandBindings.Add(binding);
        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (grid4.Visibility == Visibility.Collapsed)
                grid4.Visibility = Visibility.Visible;
            else
                grid4.Visibility = Visibility.Collapsed;
        }
        private void Button_MouseDown(object sender, RoutedEventArgs e)
        {
            biba.Text += "sender: " + sender.ToString() + "\n";
            biba.Text += "source: " + e.Source.ToString() + "\n";
        }
        private void Button_PreviewMouseDown(object sender, RoutedEventArgs e)
        {
            boba.Text += "sender: " + sender.ToString() + "\n";
            boba.Text += "source: " + e.Source.ToString() + "\n";
        }
        private void Button_MouseDown1(object sender, RoutedEventArgs e)
        {
            text.Text += "sender: " + sender.ToString() + "\n";
            text.Text += "source: " + e.Source.ToString() + "\n";
        }
    }
}
