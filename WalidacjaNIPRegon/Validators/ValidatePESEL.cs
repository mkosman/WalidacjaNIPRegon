/*
 * http://pl.wikipedia.org/wiki/PESEL
 */

using System;

namespace WalidacjaNIPRegon.Validators
{
    class PESEL
    {
        private String[] Sex = new String[]
        {
            "Mężczyzna",
            "Kobieta",
        };

        private byte[] wagi = new byte[10] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        int _SK = 0;
        int _suma = 0;
        byte a = 0;

        public PESEL()
        {
            DataUrodzenia = "b/d";
            NumerDokumentu = "b/d";
            Plec = "b/d";
            ValidateOK = false;
        }

        ~PESEL() { }

        public String DataUrodzenia
        {
            get;
            private set;
        }

        public String NumerDokumentu
        {
            get;
            private set;
        }

        public String Plec
        {
            get;
            private set;
        }

        public bool ValidateOK
        {
            get;
            private set;
        }

        public String NrPESEL
        {
            set
            {
                DataUrodzenia = "b/d";
                NumerDokumentu = "b/d";
                Plec = "b/d";
                ValidateOK = false;

                value = value.Trim();

                if (value.Length != 11)
                    return;

                foreach (char l in value)
                    if (!Byte.TryParse(l.ToString(), out a))
                        return;

                if (!Int32.TryParse(value[10].ToString(), out _SK))
                    return;

                _suma = 0;
                for (int i = 0; i < 10; i++)
                    _suma += wagi[i] * Convert.ToInt32(value[i].ToString());

                int mod = _suma % 10;

                ValidateOK = mod != 0 ? ((10 - mod) == _SK) : true;

                if (ValidateOK)
                {
                    DataUrodzenia = ParseDate(value.Substring(0, 6));
                    NumerDokumentu = value.Substring(6, 4);
                    Plec = (Convert.ToInt32(value[9].ToString()) % 2 != 0) ? Sex[0] : Sex[1];
                }
            }
        }

        private String ParseDate(String DataUr)
        {
            int rok = 0;
            int mies = 0;
            int dzien = Convert.ToInt32(DataUr[4].ToString()) * 10 + Convert.ToInt32(DataUr[5].ToString());

            if (DataUr[2] == '0' || DataUr[2] == '1')
            {
                rok = 1900;
                mies = Convert.ToInt32(DataUr[2].ToString()) * 10 + Convert.ToInt32(DataUr[3].ToString());
            }
            else if (DataUr[2] == '2' || DataUr[2] == '3')
            {
                rok = 2000;
                mies = (Convert.ToInt32(DataUr[2].ToString()) - 20) * 10 + Convert.ToInt32(DataUr[3].ToString());
            }
            else if (DataUr[2] == '4' || DataUr[2] == '5')
            {
                rok = 2100;
                mies = (Convert.ToInt32(DataUr[2].ToString()) - 40) * 10 + Convert.ToInt32(DataUr[3].ToString());
            }
            else if (DataUr[2] == '6' || DataUr[2] == '7')
            {
                rok = 2200;
                mies = (Convert.ToInt32(DataUr[2].ToString()) - 60) * 10 + Convert.ToInt32(DataUr[3].ToString());
            }
            else if (DataUr[2] == '8' || DataUr[2] == '9')
            {
                rok = 1800;
                mies = (Convert.ToInt32(DataUr[2].ToString()) - 80) * 10 + Convert.ToInt32(DataUr[3].ToString());
            }
            rok += Convert.ToInt32(DataUr[0].ToString()) * 10 + Convert.ToInt32(DataUr[1].ToString());
            DateTime _date;
            if (!DateTime.TryParse(String.Format("{0}-{1}-{2}", rok, mies, dzien), out _date))
                return "b/d";
            else
                return _date.ToLongDateString();
        }
    }
}
