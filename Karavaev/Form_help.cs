﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karavaev
{
    public partial class Form_help : Form
    {
        public Form_help()
        {
            InitializeComponent();
        }

        private void Button_practic_back_Click(object sender, EventArgs e)
        {
            Router.GetInstance().GoBack();
        }
    }
}