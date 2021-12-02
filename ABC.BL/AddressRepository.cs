using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class AddressRepository
    {
        public Address Load(int addressId)
        {
            var address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.Street = "Happy Place";
                address.City = "New York";
                address.Country = "USA";
                address.PostalCode = "00-000";
            }

            return address;
        }

        public IEnumerable<Address> LoadByClientId(int klientId)
        {
            //Load all clients addresses. Hard coded for test purposes

            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                Street = "Happy Place",
                City = "New York",
                Country = "USA",
                PostalCode = "00-000",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                Street = "Unhappy Place",
                City = "New York",
                Country = "USA",
                PostalCode = "00-000",
            };
            addressList.Add(address);

            return addressList;

        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
