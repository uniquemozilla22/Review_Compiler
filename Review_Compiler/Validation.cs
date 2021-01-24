using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Compiler
{
    public class Validation
    {
        string error_output ="";
        public Validation(string name , string contact , string email)
        {
            if(name=="")
            {
                this.error_output = "**Name Needed**";
            }
            else if(contact=="")
            {
                this.error_output = "**Contact Needed**";
            }
            else if( email == "")
            {
                this.error_output = "**E-mail Needed**";
            }
            else
            {

            }
        }


        public string error_handling_validation()
        {
            return error_output;
        }
    }
}
