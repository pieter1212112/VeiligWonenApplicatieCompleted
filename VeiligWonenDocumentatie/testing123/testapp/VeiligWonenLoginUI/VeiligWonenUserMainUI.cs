﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeiligWonenLoginUI
{
    public partial class VeiligWonenUserMainUI : Form
    {
        public VeiligWonenUserMainUI()
        {
            InitializeComponent();
        }

        private void VeiligWonenUserMainUI_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
