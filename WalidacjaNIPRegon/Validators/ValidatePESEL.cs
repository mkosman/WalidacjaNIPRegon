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

        public event EventHandler OnValidated;

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

        private bool _ValidateOK = false;
        public bool ValidateOK
        {
            get { return _ValidateOK; }
            private set
            {
                _ValidateOK = value;
                if (OnValidated != null)
                    OnValidated(this, new EventArgs());
            }
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
                    if (OnValidated != null)
                        OnValidated(this, new EventArgs());
                }
            }
        }

        private String ParseDate(String DataUr)
        {
            int rok = 0;
            int mies = 0;
            int dzien = Convert.ToInt32(DataUr[4].ToString()) * 10 + Convert.ToInt32(DataUr[5].ToString());
            int[] data = new int[6];

            for (int i = 0; i < 6; i++)
                if (!Int32.TryParse(DataUr[i].ToString(), out data[i]))
                    return "b/d";

            if (data[2] == 0 || data[2] == 1)
            {
                rok = 1900;
                mies = data[2] * 10 + data[3];
            }
            else if (data[2] == 2 || data[2] == 3)
            {
                rok = 2000;
                mies = (data[2] - 20) * 10 + data[3];
            }
            else if (data[2] == 4 || data[2] == 5)
            {
                rok = 2100;
                mies = (data[2] - 40) * 10 + data[3];
            }
            else if (data[2] == 6 || data[2] == 7)
            {
                rok = 2200;
                mies = (data[2] - 60) * 10 + data[3];
            }
            else if (data[2] == 8 || data[2] == 9)
            {
                rok = 1800;
                mies = (data[2] - 80) * 10 + data[3];
            }
            rok += data[0] * 10 + data[1];
            DateTime _date;
            if (!DateTime.TryParse(String.Format("{0}-{1}-{2}", rok, mies, dzien), out _date))
                return "b/d";
            else
                return _date.ToLongDateString();
        }
    }
}
