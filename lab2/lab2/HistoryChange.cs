using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
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
        public List<Account> accounts2 = new List<Account>();
        public int count = 0;
        public Saf(ref List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                this.accounts2.Add(account);
            }
        }
    }
}
