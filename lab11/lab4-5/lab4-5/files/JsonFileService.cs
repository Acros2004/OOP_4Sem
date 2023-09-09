using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using lab4_5.files;

namespace lab4_5
{
    public class JsonFileService : IFileService
    {
        public List<Car> Open(string filename)
        {
            List<Car> cars = new List<Car>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Car>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                cars = jsonFormatter.ReadObject(fs) as List<Car>;
            }

            return cars;
        }

        public void Save(string filename, List<Car> cars)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Car>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, cars);
            }
        }
        
    }
}
