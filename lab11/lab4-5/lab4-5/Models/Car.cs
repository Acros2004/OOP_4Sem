using lab4_5.Commands;
using lab4_5.files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace lab4_5
{
    public class Car : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private int price;
        private string country;
        private string image;
        private string history;
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
        public string History
        {
            get { return history; }
            set
            {
                history = value;
                OnPropertyChanged("History");
            }
        }

        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
                
        }
        //IFileService fileService = new JsonFileService();
        IDialogService dialogService = new DefaultDialogService();
        private RelayCommand openFoto;
        public RelayCommand OpenFoto
        {
            get
            {
                return openFoto ?? (openFoto = new RelayCommand(obj =>
                {
                    try
                    {
                        if (dialogService.OpenFileDialog() == true)
                        {

                            Image = dialogService.FilePath;
                            OnPropertyChanged("SelectedCar");
                            dialogService.ShowMessage("Файл открыт");
                        }
                    }
                    catch (Exception ex)
                    {
                        dialogService.ShowMessage(ex.Message);
                    }
                }));
            }
        }
        public RelayCommand saveItem;
        public RelayCommand SaveSelectedItem
        {
            get
            {
                return saveItem ?? (saveItem = new RelayCommand(obj =>
                {
                    SaveMyItem();
                }));
            }
        }
        private void SaveMyItem()
        {
            string connectionString = "server=ACROSS;DataBase = Lab11;Trusted_Connection = Yes;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // string sqlExpression = $"insert into Product(id,Name,Country,Price,History,Image) values({SelectedCar.ID},'{SelectedCar.Name}','{SelectedCar.Country}',{SelectedCar.Price},'{SelectedCar.History}','{SelectedCar.Image}')";
            string sqlExpression = $"update Product set Name = '{Name}',Country = '{Country}', Price = {Price}, History = '{History}', Image = '{Image}' where id = {id}";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.ExecuteNonQuery();
        }
        private void PerformOpenFoto(object commandParameter)
        {
        }
    }
}
