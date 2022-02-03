using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace secPass
{
    public class Credential
    {
        //Getters and setters
        public string Account { get; set; }
        
        public string Password { get; set; }

        //Contructor that takes data in string form from datagrid and formats it to store properties
        public Credential(string rowData)
        {
            string[] data = rowData.Split(',');

            //Parse the data into the object's properties
            this.Account = data[0];
            this.Password = data[1];
        }
        public Credential()
        {
        }
    }
}