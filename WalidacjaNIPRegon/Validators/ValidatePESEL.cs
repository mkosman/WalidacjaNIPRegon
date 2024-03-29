﻿/*
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
        private int[] stulecie = new int[]{
            00, 00,     // 1900
            20, 20,     // 2000
            40, 40,     // 2100
            60, 60,     // 2200
            80, 80,     // 1800
        };
        private int[] lata = new int[] {
            1900, 1900,
            2000, 2000,
            2100, 2100,
            2200, 2200,
            1800, 1800,
        };
        int _SK = 0;
        int _suma = 0;

        public event EventHandler OnValidated;

        public PESEL()
        {
            DataUrodzenia = "b/d";
            NumerDokumentu = "b/d";
            Plec = "b/d";
            ValidatedOK = false;
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

        private bool _DisableEvent = false;
        private bool _ValidateOK = false;
        public bool ValidatedOK
        {
            get { return _ValidateOK; }
            private set
            {
                _ValidateOK = value;
                if (OnValidated != null && value == false && _DisableEvent == false)
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
                ValidatedOK = false;

                value = value.Trim();

                if (value.Length != 11)
                {
                    ValidatedOK = false;
                    return;
                }

                int a = 0;
                int[] bPesel = new int[value.Length];
                foreach (char l in value)
                    if (!Int32.TryParse(l.ToString(), out bPesel[a++]))
                    {
                        ValidatedOK = false;
                        return;
                    }

                if (!Int32.TryParse(value[10].ToString(), out _SK))
                {
                    ValidatedOK = false;
                    return;
                }

                _suma = 0;
                for (int i = 0; i < 10; i++)
                    _suma += wagi[i] * bPesel[i];

                int mod = _suma % 10;

                ValidatedOK = mod != 0 ? ((10 - mod) == _SK) : true;

                if (ValidatedOK)
                {
                    DataUrodzenia = ParseDate(value.Substring(0, 6));
                    NumerDokumentu = value.Substring(6, 4);
                    Plec = (bPesel[9] % 2 != 0) ? Sex[0] : Sex[1];
                    ValidatedOK = ValidatedOK;
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

            mies = (data[2] - stulecie[data[2]]) * 10 + data[3];
            rok = lata[data[2]] + data[0] * 10 + data[1];

            DateTime _date;
            if (!DateTime.TryParse(String.Format("{0}-{1}-{2}", rok, mies, dzien), out _date))
            {
                ValidatedOK = false;
                return "b/d";
            }
            else
                return _date.ToLongDateString();
        }

        public bool IsValid(String PESEL, bool DisableEvent = true)
        {
            _DisableEvent = DisableEvent;
            NrPESEL = PESEL;
            _DisableEvent = !DisableEvent;
            return ValidatedOK;
        }
    }
}
