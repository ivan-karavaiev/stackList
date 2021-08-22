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
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void Button_menu_test_Click(object sender, EventArgs e)
        {
            Form_tests newForm = new Form_tests();
            newForm.Show();
        }

        private void Button_menu_theory_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Fileopen = new System.Diagnostics.Process();
            Fileopen.StartInfo.FileName = @"..\..\..\Documentation.docx";
            Fileopen.StartInfo.Verb = "Open";
            Fileopen.StartInfo.CreateNoWindow = false;
            Fileopen.Start();
        }

        private void Button_menu_practic_Click(object sender, EventArgs e)
        {
            Form_practic newForm = new Form_practic();
            newForm.Show();
        }

        private void Button_menu_build_Click(object sender, EventArgs e)
        {
            Form_buildTree newForm = new Form_buildTree();
            newForm.Show();
        }

        private void Button_menu_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
