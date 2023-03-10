using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAddressLibrary
{
    public interface ISavedAddress
    {
        void SaveAddress(AddressModel address);
    }
}
