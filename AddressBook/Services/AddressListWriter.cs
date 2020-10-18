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
    public class AddressListWriter
    {
        private readonly string path;

        public AddressListWriter()
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

        public void SaveAddressList(List<Subscriber> addressList)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            string json = JsonConvert.SerializeObject(addressList);
            File.WriteAllText(path, json);
        }
    }
}
