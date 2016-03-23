using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class EmailAddress
    {
        public int BusinessEntityID { get; set; }
        public int EmailAddressID { get; set; }
        public string Email { get; set; }

        public EmailAddress()
        {

        }

        public EmailAddress(int businessEntityID, int emailAddressID, string emailAddress)
        {
            BusinessEntityID = businessEntityID;
            EmailAddressID = emailAddressID;
            Email = emailAddress;
        }

        public String toString()
        {
            return BusinessEntityID + " " + EmailAddressID + " " + Email;
        }
    }
}
