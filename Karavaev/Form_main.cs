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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void Button_main_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_main_name_Click(object sender, EventArgs e) => Router.GetInstance().NavigateTo(new Form_menu());
    }
}
