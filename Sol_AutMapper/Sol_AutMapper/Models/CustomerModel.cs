using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_AutMapper.Models
{
    public class CustomerModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AddressModel Address { get; set; }
    }
    public class AddressModel
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }

   
}
