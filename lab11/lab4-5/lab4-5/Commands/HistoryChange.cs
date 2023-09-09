using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace lab4_5.Commands
{
    public class NHist
    {
        public Stack<Saf> Form { get; private set; }
        public NHist()
        {
            Form = new Stack<Saf>();
        }
    }
    public class Saf
    {
        public ObservableCollection<Car> list = new ObservableCollection<Car>();
        public int count = 0;
        public Saf(ref ObservableCollection<Car> accounts)
        {
            foreach (Car account in accounts)
            {
                this.list.Add(account);
            }
        }
    }
}
