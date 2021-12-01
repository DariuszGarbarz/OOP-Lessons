using System;

namespace ABC.BL
{
    public class Klient
    {
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

    }
}
