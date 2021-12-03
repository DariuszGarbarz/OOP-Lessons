using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class Klient
    {
        public Klient() : this(0)
        {
            
        }

        public Klient(int klientId)
        {
            this.KlientId = klientId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }

        public int ClientType { get; set; }
        public static int Counter { get; set; }
        private string _nazwisko;
        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }

        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko 
        {
            get
            {
                if(string.IsNullOrWhiteSpace(Nazwisko)==true || string.IsNullOrWhiteSpace(Imie) == true)
                {
                    return Nazwisko + Imie;
                }
                else
                {
                    return Nazwisko + ", " + Imie;
                }

            }
        }

        public bool Validate()
        {
            var correct = true;
            if (string.IsNullOrWhiteSpace(Nazwisko))
            {
                correct = false;
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                correct = false;
            }

            return correct;
        }

        /// <summary>
        /// We are going to save current Client
        /// </summary>
        /// <returns>bool</returns>
        public bool Save()
        {
            //
            return true;
        }

        /// <summary>
        /// We are going to load Client based on ID
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns>Klient</returns>
        public Klient Load(int klientId)
        {
            //
            return new Klient();
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
