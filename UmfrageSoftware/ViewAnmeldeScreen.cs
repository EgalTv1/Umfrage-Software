﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    public partial class ViewAnmeldeScreen : Form
    {
        public ViewAnmeldeScreen()
        {
            InitializeComponent();
        }

        private void buttonGastLogin_Click(object sender, EventArgs e)
        {
            StartSeite hartSeite = new StartSeite();
            hartSeite.Show();
        }

        private void buttonAnmelden_Click(object sender, EventArgs e)
        {

        }
    }
}