using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalidacjaNIPRegon.Validators
{
    class REGON
    {
        private byte[] wagi_09 = new byte[] { 8, 9, 2, 3, 4, 5, 6, 7, };
        private byte[] wagi_14 = new byte[] { 2, 4, 8, 5, 0, 9, 7, 3, 6, 1, 2, 4, 8, };

        private EventHandler _OnValidated = null;
        public EventHandler OnValidated
        {
            get { return _OnValidated; }
            set { _OnValidated = value; }
        }

        public REGON() { }
        ~REGON() { }

        private bool _DisableEvent = false;
        private bool _validatedOK = false;
        public bool ValidatedOK
        {
            get { return _validatedOK; }
            private set
            {
                _validatedOK = value;
                if (OnValidated != null && _DisableEvent == false)
                    OnValidated(this, new EventArgs());
            }
        }

        public String NrREGON
        {
            set
            {
                value = value.Trim();
                int _suma9 = 0, _suma14 = 0;
                int _SK9 = 0, _SK14 = 0;
                if (value.Length != 9 && value.Length != 14)
                {
                    ValidatedOK = false;
                    return;
                }

                int[] bREGON = new int[value.Length];

                int a = 0;
                foreach (char l in value)
                    if (!Int32.TryParse(l.ToString(), out bREGON[a++]))
                    {
                        ValidatedOK = false;
                        return;
                    }
                                                                
                // wyznaczenie dla 9 cyfrowego regonu
                _SK9 = bREGON[8];
                for (int i = 0; i < 9; i++)
                    _suma9 += wagi_09[i] * bREGON[i];

                if (value.Length == 14)
                {
                    _SK14 = bREGON[13];
                for (int i = 0; i < 14; i++)
                    _suma14 += wagi_14[i] * bREGON[i];
                }

               bool bSK9 =((((_suma9 % 11) != 10) ? (_suma9 % 11) : 0) == _SK9);
               if (value.Length == 14)
               {
                   bool bSK14 = ((((_suma14 % 11) != 10) ? (_suma14 % 11) : 0) == _SK14);
                   ValidatedOK = (bSK9 == true) && (bSK14 == true);
               }
               else
                   ValidatedOK = bSK9;
            }
        }

        public bool IsValid(String nREGON, bool DisableEvent = true)
        {
            _DisableEvent = DisableEvent;
            NrREGON = nREGON;
            _DisableEvent = !DisableEvent;
            return ValidatedOK;
        }
    }
}
