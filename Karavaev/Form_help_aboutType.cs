using System;
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
    public partial class Form_help_aboutType : Form
    {
        public Form_help_aboutType()
        {
            InitializeComponent();
        }

        private void Button_aboutType_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
