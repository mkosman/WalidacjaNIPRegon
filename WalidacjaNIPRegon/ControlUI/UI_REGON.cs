using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WalidacjaNIPRegon.ControlUI
{
    public partial class UI_REGON : UserControl
    {
        Validators.REGON REGON = new Validators.REGON();

        public UI_REGON()
        {
            InitializeComponent();
            REGON.OnValidated += new EventHandler(REGON_OnValidated);
        }

        void REGON_OnValidated(object sender, EventArgs e)
        {
            if (REGON.ValidatedOK)
            {
                lbStatus.ForeColor = Color.Black;
                lbStatus.Text = "Wprowadzony numer jest poprawny";
            }
            else
            {
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Wprowadź poprawny numer REGON (9/14 cyfrowy)"; 
            }
        }

        private void textREGON_TextChanged(object sender, EventArgs e)
        {
            REGON.NrREGON = textREGON.Text;
        }
    }
}
