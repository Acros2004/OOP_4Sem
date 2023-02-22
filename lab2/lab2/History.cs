using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class History
    {
        string date;
        int count;
        string operation;
        public History (string OpeningDate, int count,string operation) 
        {
            date = OpeningDate;
            this.count = count;
            this.operation = operation;
        }
        public History()
        {
            date = "";
            count = 0;
            operation = "";
        }
        public override string ToString()
        {
            return $"{date}, {operation} сумму:{count}";
        }
    }
}
