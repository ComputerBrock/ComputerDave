﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WillBallingerBrockButtsworthAssgt.Forms
{
    public partial class welcomeScreen : Form
    {
        public welcomeScreen()
        {
            InitializeComponent();
        }

        private void btnGameRules_Click(object sender, EventArgs e)
        {
            var form = new Game_Rules();
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }
    }
}
