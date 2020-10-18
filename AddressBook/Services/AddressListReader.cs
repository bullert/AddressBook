using AddressBook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    public class AddressListReader
    {
        private readonly string path;

        public AddressListReader()
        {
            path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/AddressList.json";
        }

        //public List<Subscriber> AddressList
        //{
        //    get
        //    {
        //        using (StreamReader sr = new StreamReader(path))
        //        {
        //            string json = sr.ReadToEnd();
        //            return JsonConvert.DeserializeObject<List<Subscriber>>(json);
        //        }
        //    }
        //}

        public List<Subscriber> LoadAddressList()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Subscriber>>(json);
            }
        }
    }
}
