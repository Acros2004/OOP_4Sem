using lab4_5.Commands;
using lab4_5.files;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace lab4_5
{
    public class ApplicationViewModel : ViewModelBase, INotifyPropertyChanged
    {
        
        SqlConnection connection;
        string connectionString;
        Car selectedCar;
        IFileService fileService;
        IDialogService dialogService;
        public NHist histForBack = new NHist();
        public NHist histForForward = new NHist();
        public Saf SaveData()
        {
            return new Saf(ref searchedCars);
        }
        public void RestoreDataBack(Saf data)
        {
            histForForward.Form.Push(SaveData());
            SearchedCars = data.list;
        }
        public void RestoreDataForward(Saf data)
        {
            histForBack.Form.Push(SaveData());
            SearchedCars = data.list;
        }
        public void RestoreBack(Saf data,bool flag)
        {
            SqlTransaction tx = null;

        }
        private RelayCommand undo;
        private RelayCommand redo;
        public RelayCommand Undo
        {
            get
            {
                return undo ??
                  (undo = new RelayCommand(obj =>
                  {
                      if (histForBack.Form.Count > 0)
                      {
                          RestoreDataBack(histForBack.Form.Pop());
                      }
                      else
                      {
                          MessageBox.Show("Стек пуст,назад нельзя");
                      }
                      OnPropertyChanged("SearchedCars");
                  }));
            }
        }
        public RelayCommand Redo
        {
            get
            {
                return redo ??
                  (redo = new RelayCommand(obj =>
                  {
                      if (histForForward.Form.Count > 0)
                      {
                          RestoreDataForward(histForForward.Form.Pop());
                      }
                      else
                      {
                          MessageBox.Show("Стек пуст,вперёд нельзя");
                      }
                      OnPropertyChanged("SearchedCars");
                  }));
            }
        }
        public ObservableCollection<Car> Cars { get; set; }
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      connectionString = "server=ACROSS;DataBase = Lab11;Trusted_Connection = Yes;";
                      connection = new SqlConnection(connectionString);
                      connection.Open();
                      string sqlExpression = "insert into Product(Name,Country,Price,History,Image) values('Temp','Temp',0,'Temp','')";
                      SqlCommand command = new SqlCommand(sqlExpression, connection);
                      command.ExecuteNonQuery();
                      RefreshMyList();
                      OnPropertyChanged("SearchedCars");
                  }));
            }
        }
        public RelayCommand removeCommand;
        public RelayCommand refreshCommand;
        public RelayCommand RefreshCommand
        {
            get
            {
                return refreshCommand ?? (refreshCommand = new RelayCommand(obj =>
                {
                    RefreshMyList();
                    OnPropertyChanged("SearchedCars");
                }));
            }
        }
        private void RefreshMyList()
        {
            connectionString = "server=ACROSS;DataBase = Lab11;Trusted_Connection = Yes;";

            connection = new SqlConnection(connectionString);
            connection.Open();
            string sqlExpression = "Select id,Name,Country,Price,History,Image from Product";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            Cars = new ObservableCollection<Car>();
            if (reader.HasRows) // если есть данные
            {

                while (reader.Read()) // построчно считываем данные
                {
                    Cars.Add(new Car { ID = (int)reader.GetValue(0), Name = (reader.GetValue(1)).ToString(), Country = (reader.GetValue(2)).ToString(), Price = (int)reader.GetValue(3), History = (reader.GetValue(4)).ToString(), Image = (reader.GetValue(5)).ToString() });
                }
            }
            SearchedCars = new ObservableCollection<Car>(Cars);
        }
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ?? (removeCommand = new RelayCommand(obj =>
                {

                    connectionString = "server=ACROSS;DataBase = Lab11;Trusted_Connection = Yes;";
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    string sqlExpression = $"Delete from Product where id = {SelectedCar.ID}";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                    RefreshMyList();
                    OnPropertyChanged("SearchedCars");
                },
                (obj) => Cars.Count > 0));
            }
        }
        public Car SelectedCar
        {
            get { return selectedCar; }
            set
            {
                selectedCar = value;
                OnPropertyChanged("SelectedCar");
            }
        }
        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ?? (saveCommand = new RelayCommand(obj =>
                {
                    try
                    {
                        if (dialogService.SaveFileDialog() == true)
                        {
                            fileService.Save(dialogService.FilePath, Cars.ToList());
                            dialogService.ShowMessage("Файл сохранён");
                        }
                    }
                    catch (Exception ex) { dialogService.ShowMessage(ex.Message); }
                }));
            }
        }
       
        

        private RelayCommand openCommand;

        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ?? (openCommand = new RelayCommand(obj =>
                {
                    try
                    {
                        if (dialogService.OpenFileDialog() == true)
                        {
                            var cars = fileService.Open(dialogService.FilePath);
                            Cars.Clear();
                            foreach (var p in cars)
                                Cars.Add(p);
                            OnPropertyChanged("SearchedCars");
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
        private ObservableCollection<Car> searchedCars;
        public ObservableCollection<Car> SearchedCars {
            get
            {
                return searchedCars;
            }
            set
            {
                searchedCars = value;
            }
        }

        public int filterOfCost;
        public int FilterOfCost
        {
            get { return filterOfCost; }
            set
            {
                filterOfCost = value;
                SearchedCars = new ObservableCollection<Car>(Cars.Where(e => e.Price < filterOfCost));
                OnPropertyChanged("SearchedCars");
            }
        }

        public string filterOfCountry;
        public string FilterOfCountry
        {
            get { return filterOfCountry; }
            set
            {
                filterOfCountry = value;
                SearchedCars = new ObservableCollection<Car>(Cars.Where(e => e.Country.ToLower().Contains(filterOfCountry.ToLower())));
                OnPropertyChanged("SearchedCars");
            }
        }
        private string search;
        public string Search
        {
            get { return search; }
            set
            {
                search = value;
                SearchedCars = new ObservableCollection<Car>(Cars.Where(e => e.Name.ToLower().Contains(search.ToLower())));
                OnPropertyChanged("SearchedCars");
            }
        }
       
        public ICommand CloseAppComm { get; }
        private void OnCloseAppCommExecute(object d)
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseAppCommExecute(object d) => true;
        public ICommand ChangeLanguageCommand { get; }
        private void OnChangeLanguageCommandExecuted(object o)
        {
            string lang = o as string;
            switch (lang)
            {
                case "Анг":
                    Application.Current.Resources.MergedDictionaries[0].Source = new Uri("C:/Users/nikit/Desktop/univer/2cource2sem/OOP2sem/lab4-5/lab4-5/Resources/Eng.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case "Рус":
                    Application.Current.Resources.MergedDictionaries[0].Source = new Uri("C:/Users/nikit/Desktop/univer/2cource2sem/OOP2sem/lab4-5/lab4-5/Resources/Rus.xaml", UriKind.RelativeOrAbsolute);
                    break;
                default:
                    break;
            }
        }
        public ICommand ChangeThemeCommand { get; }
        private void OnChangeThemeCommandExecuted(object o)
        {
            string lang = o as string;
            switch (lang)
            {
                case "Light":
                    Application.Current.Resources.MergedDictionaries[1].Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case "Dark":
                    Application.Current.Resources.MergedDictionaries[1].Source = new Uri("C:\\Users\\nikit\\Desktop\\univer\\2cource2sem\\OOP2sem\\lab4-5\\lab4-5\\Resources\\Dark.xaml", UriKind.RelativeOrAbsolute);
                    break;
                default:
                    break;
            }
        }


        public ApplicationViewModel(IDialogService dialogService, IFileService fileService)
        {
           
            searchedCars = new ObservableCollection<Car> { new Car() };
            histForBack.Form.Push(SaveData());
            this.dialogService = dialogService;
            this.fileService = fileService;
            RefreshMyList();
            CloseAppComm = new RelayCommand(OnCloseAppCommExecute, CanCloseAppCommExecute);
            ChangeLanguageCommand = new RelayCommand(OnChangeLanguageCommandExecuted);
            ChangeThemeCommand = new RelayCommand(OnChangeThemeCommandExecuted);
            //ChangeThemeCommand = new RelayCommand(OnChangeThemeCommandExecuted);

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
