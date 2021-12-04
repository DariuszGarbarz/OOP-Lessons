using System.Collections.Generic;
using System.Linq;

namespace ABC.BL
{
    public class KlientRepository
    {
        private AddressRepository addressRepository { get; set; }
        public KlientRepository()
        {
            addressRepository = new AddressRepository();
        }

        

        /// <summary>
        /// We are going to save current Client
        /// </summary>
        /// <returns>bool</returns>
        public bool Save(Klient client)
        {
            var success = true;

            if (client.HasChanges && client.IsValid)
            {
                if (client.IsNew)
                {
                    // insert procedure
                }
                else
                {
                    //update procedure
                }
            }
            return success;
        }

        /// <summary>
        /// We are going to load Client based on ID
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns>Klient</returns>
        public Klient Load(int klientId)
        {

            Klient klient = new Klient(klientId); // Adding new Client
            klient.AddressList = addressRepository.LoadByClientId(klientId).ToList();

            //Hard coding for test purposes
            if (klientId == 1)
            {
                klient.Email = "dariusz@gmail.com";
                klient.Imie = "Dariusz";
                klient.Nazwisko = "Mariusz";

              
            }
            return klient;
        }

        /// <summary>
        /// Load all Clients
        /// </summary>
        /// <returns></returns>
        public List<Klient> Load()
        {
            return new List<Klient>();
        }
    }
}

