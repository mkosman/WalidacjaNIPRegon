using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WalidacjaNIPRegon
{
    public partial class Form1 : Form
    {

        Control ControlForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void FunctionSelect(object sender, EventArgs e)
        {
            if (ControlForm != null)
                ControlForm.Parent = null;
            if (rbPESEL.Checked)
            {
                ControlForm = new ControlUI.UI_PESEL();
                ControlForm.Parent = panelForm;
            }
        }
    }
}
