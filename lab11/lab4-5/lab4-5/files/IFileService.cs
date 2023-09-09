using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_5.files
{
    public interface IFileService
    {
        List<Car> Open(string filename);
        void Save(string filename, List<Car> phonesList);
    }
}
