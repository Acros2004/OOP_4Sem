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

namespace lab4_5
{
    public class ApplicationViewModel : ViewModelBase, INotifyPropertyChanged
    {
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
                      histForBack.Form.Push(SaveData());
                      var car = new Car();
                      Cars.Insert(0, car);
                      SelectedCar = car;
                      SearchedCars = Cars;
                      OnPropertyChanged("SearchedCars");
                  }));
            }
        }
        public RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ?? (removeCommand = new RelayCommand(obj =>
                {
                    histForBack.Form.Push(SaveData());
                    Cars.Remove(SelectedCar);
                    SearchedCars = Cars;
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

            // данные по умлолчанию
            Cars = new ObservableCollection<Car>
            {new Car {Name="Jaguar E-Type", Country="Китай", Price=56000,Image=@"C:\Users\nikit\Desktop\univer\2cource2sem\OOP2sem\lab4-5\cars\1.jpg",History = "Никто иной, как Энцо Феррари, назвал E-Type самым красивым автомобилем из когда-либо созданных, и даже если красота всегда в глазах смотрящего, с тех пор немногие люди стали бы ему противоречить. Дебют XK-E под названием «E-Type» в 1961 году стал настоящей сенсацией. "},
                new Car {Name="Audi 80 (B4)", Country="Америка", Price =60000,Image=@"C:\Users\nikit\Desktop\univer\2cource2sem\OOP2sem\lab4-5\cars\2.jpg",History= "Четвертая и последняя модель в серии Audi 80, Audi 80 B4, была официально представлена в сентябре 1991 года как преемник Audi 80 B3. С измененной передней частью, капотом с интегрированной решеткой радиатора, как на Audi 100 C4."},
                new Car {Name="Land Rover", Country="Испания", Price=76000,Image=@"C:\Users\nikit\Desktop\univer\2cource2sem\OOP2sem\lab4-5\cars\3.jpg" , History ="Производство Land Rover Series 3 началось в 1971 году и закончилось в 1985 году, и примерно на полпути к производству Series 3 1 000 000 автомобилей Land Rover сошли с конвейера Солихалла. line в 1976 году. По сути, 3 была фейслифтингом Series 2/2a."},
                new Car {Name="Porsche 911", Country="Китай", Price=36000,Image=@"C:\Users\nikit\Desktop\univer\2cource2sem\OOP2sem\lab4-5\cars\4.jpg", History = "Вышло второе поколение Porsche 911 (модель G) на рынок в 1973 году как преемник Porsche 911 (оригинальная модель). Это был спортивный автомобиль с колесной формулой 2+2, доступный в версиях купе, кабриолет (с 1983 г.), Targa и Speedster."},
                new Car {Name="Jaguar 3", Country="Китай", Price=35000,Image=@"C:\Users\nikit\Desktop\univer\2cource2sem\OOP2sem\lab4-5\cars\5.jpg", History = "Никто иной, как Энцо Феррари, назвал E-Type самым красивым автомобилем из когда-либо созданных, и даже если красота всегда в глазах смотрящего, с тех пор немногие люди стали бы ему противоречить. Дебют XK-E под названием «E-Type» в 1961 году стал настоящей сенсацией. "  }
            };
            SearchedCars = new ObservableCollection<Car>(Cars);
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
