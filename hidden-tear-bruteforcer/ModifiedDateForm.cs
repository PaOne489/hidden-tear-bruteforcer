﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hidden_tear_bruteforcer
{
    public partial class ModifiedDateForm : Form
    {

        // Flag for close by button
        public bool closedByButton = false;

        public ModifiedDateForm()
        {
            InitializeComponent();
        }

        private void SetModifiedButton_Click(object sender, EventArgs e)
        {

            // Set close flag
            closedByButton = true;

            // Close the form
            Close();

        }
    }
}
