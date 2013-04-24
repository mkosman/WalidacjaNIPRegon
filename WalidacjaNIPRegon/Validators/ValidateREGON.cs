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
        private int _SK = 0;
        private int _suma = 0;

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

                if (value.Length != 9 && value.Length != 14)
                {
                    ValidatedOK = false;
                    return;
                }

                int a = 0;
                byte[] bREGON = new byte[value.Length];

                foreach (char l in value)
                    if (!Byte.TryParse(l.ToString(), out bREGON[a++]))
                    {
                        ValidatedOK = false;
                        return;
                    }

                if (!Int32.TryParse(value[value.Length == 9 ? 8 : 13].ToString(), out _SK))
                {
                    ValidatedOK = false;
                    return;
                }

                _suma = 0;
                for (int i = 0; i < (value.Length == 9 ? 8 : 13); i++)
                    _suma += (value.Length == 9 ? wagi_09[i] : wagi_14[i]) * bREGON[i];

                ValidatedOK = (((_suma % 11) != 10) ? (_suma % 11) : 0) == _SK;
            }
        }

        public bool IsValid(String REGON, bool DisableEvent = true)
        {
            _DisableEvent = DisableEvent;
            NrREGON = REGON;
            _DisableEvent = !DisableEvent;
            return ValidatedOK;
        }
    }
}
