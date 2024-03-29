﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WalidacjaNIPRegon.ControlUI
{
    public partial class UI_PESEL : UserControl
    {
        Validators.PESEL PESEL = new Validators.PESEL();

        public UI_PESEL()
        {
            InitializeComponent();
            PESEL = new Validators.PESEL();
            PESEL.OnValidated += new EventHandler(PESEL_ValidatedOK);
        }

        void PESEL_ValidatedOK(object sender, EventArgs e)
        {
            tbData.Text = PESEL.DataUrodzenia;
            tbNrDok.Text = PESEL.NumerDokumentu;
            tbPlec.Text = PESEL.Plec;
            if (!PESEL.ValidatedOK)
            {
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Wprowadź poprawnie 11 cyfr numeru PESEL";
            }
            else
            {
                lbStatus.ForeColor = Color.Black;
                lbStatus.Text = "Wprowadzony numer jest poprawny";
            }
        }

        private void textPESEL_TextChanged(object sender, EventArgs e)
        {
            PESEL.NrPESEL = textPESEL.Text;
        }
    }
}
