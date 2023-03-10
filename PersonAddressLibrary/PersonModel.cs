using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAddressLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<AddressModel> Addresses { get; set; }

        public PersonModel(string firstName, string lastName, string email, List<AddressModel> addresses)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Addresses = addresses;
        }
    }
}
