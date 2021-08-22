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
    public partial class Form_tests : Form
    {
        public Form_tests()
        {
            InitializeComponent();
        }

        int full = 6, counter = 0;
        private void Button_testEnd_Click(object sender, EventArgs e)
        {
            if (radioButton_Q1_3.Checked) ++counter;
            if (radioButton_Q2_2.Checked) ++counter;
            if (radioButton_Q3_3.Checked) ++counter;
            if (radioButton_Q4_1.Checked) ++counter;
            if (radioButton_Q5_1.Checked) ++counter;
            if (radioButton_Q6_4.Checked) ++counter;
                if (counter == full)
            {
                MessageBox.Show("Все правильно! Ви молодець!");
            }
            else
            {
                MessageBox.Show("Кількість неправильних відповідей: " + (full - counter).ToString());
            }
            this.Close();
        }
    }
}
