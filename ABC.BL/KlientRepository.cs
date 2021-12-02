using System.Collections.Generic;

namespace ABC.BL
{
    public class KlientRepository
    {
        public KlientRepository()
        {

        }

        /// <summary>
        /// We are going to save current Client
        /// </summary>
        /// <returns>bool</returns>
        public bool Save()
        {
            
            return true;
        }

        /// <summary>
        /// We are going to load Client based on ID
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns>Klient</returns>
        public Klient Load(int klientId)
        {

            Klient klient = new Klient(klientId); // Adding new Client

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

