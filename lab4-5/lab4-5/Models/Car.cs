using lab4_5.Commands;
using lab4_5.files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace lab4_5
{
    public class Car : INotifyPropertyChanged
    {
        private string name;
        private int price;
        private string country;
        private string image;
        private string history;
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
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
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

        private void PerformOpenFoto(object commandParameter)
        {
        }
    }
}
