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

        private void Button_menu_test_Click(object sender, EventArgs e) =>
            Router.GetInstance().NavigateTo(new Form_tests());

        private void Button_menu_theory_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Fileopen = new System.Diagnostics.Process();
            Fileopen.StartInfo.FileName = @"..\..\..\Documentation.docx";
            Fileopen.StartInfo.Verb = "Open";
            Fileopen.StartInfo.CreateNoWindow = false;
            // FIXME: try catch
            Fileopen.Start();
        }

        private void Button_menu_practic_Click(object sender, EventArgs e) =>
            Router.GetInstance().NavigateTo(new Form_practic());

        private void Button_menu_build_Click(object sender, EventArgs e) =>
            Router.GetInstance().NavigateTo(new Form_buildTree());

        private void Button_menu_back_Click(object sender, EventArgs e) => Router.GetInstance().GoBack();
    }
}