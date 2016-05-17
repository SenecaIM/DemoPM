﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portfolio;

namespace Portfolio
{
    public partial class Navibar : UserControl
    {
        public event EventHandler showInstruments;
        public event EventHandler showPortfolio;
        public event EventHandler showClients;
        public Navibar()
        {
            InitializeComponent();
        }

        private void optionsgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            showClients(sender, e);
        }

        private void btnInstruments_Click(object sender, EventArgs e)
        {
            showInstruments(sender, e);
        }
        }
    }

