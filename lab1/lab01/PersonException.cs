using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class PersonException : Exception
    {
        public object send;
        public EventArgs even;
        public PersonException(string message,object sender,EventArgs e)
            : base(message) 
        {
            send = sender;
            even = e;
        }
    }
}
