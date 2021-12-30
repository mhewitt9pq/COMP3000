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

        //[Name("Name")]
        public string Account { get; set; }

        //[Name("Encrypted Credential")]
        public string Password { get; set; }

        //Contructor
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


        /*public override string ToString()
        {
            string output = String.Format("Name: {0}, Credential: {1}", passName, pass);

            return output;
        }*/
    }
}
