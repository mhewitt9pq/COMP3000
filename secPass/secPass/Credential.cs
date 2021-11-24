using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secPass
{
    public class Credential
    {
        public string passName { get; set; }
        public string pass { get; set; }


        public Credential(string passName,
            string pass)
        {
            this.passName = passName;
            this.pass = pass;
        }



        public override string ToString()
        {
            string output = String.Format("Name: {0}, Credential: {1}", passName, pass);

            return output;
        }
    }
}
