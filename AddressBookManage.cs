using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addre
{
    internal class AddBookManage
    {
        List<Address> addresses;

        public AddBookManage()
        {
            addresses = new List<Address>();
        }

        public bool add(string firstname, string lastName, string address, string city, string state, int zipcode, string email, long phoneNo)
        {

            Address addr = new Address(firstname, lastName, address, city, state, zipcode, email, phoneNo);
            string name = firstname + lastName;
            Address result = find(name);


            if (result == null)
            {
                addresses.Add(addr);
                return true;
            }
            else
            {
                return false;
            }
            Address find(string name)
            {
                Address addr = addresses.Find((a) => a.name == name);
                return addr;
            }
        }
    }
}
