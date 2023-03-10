using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAddressLibrary
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        public string AddressDisplayValue =>  $"{StreetAddress}, {City}, {PostCode}";
       

        
    }
}
