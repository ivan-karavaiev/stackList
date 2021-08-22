using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Karavaev
{
    public partial class Form_text_save : Form
    {
        List<Point> vertex = new List<Point>();
        List<Point> edge = new List<Point>();

        public Form_text_save(List<Point> vertex, List<Point> edge)
        {
            InitializeComponent();
            this.vertex = vertex;
            this.edge = edge;
        }

        int button_type = 0;

        private void Button_typeA_Click(object sender, EventArgs e)
        {
            button_type = 1;
        }

        private void Button_typeB_Click(object sender, EventArgs e)
        {
            button_type = 2;
        }

        string file_name = "";
        string filePath = @"..\..\..\TextFile\Type";

        void saveTypeA()
        {
            filePath = filePath + @"A\" + file_name + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    int n = vertex.Count();
                    int m = edge.Count();
                    sw.WriteLine(n);
                    for (int i = 0; i < n; ++i)
                    {
                        sw.Write(vertex[i].X);
                        sw.Write(' ');
                        sw.WriteLine(vertex[i].Y);
                    }

                    sw.WriteLine(m);
                    for (int i = 0; i < m; ++i)
                    {
                        sw.Write(edge[i].X);
                        sw.Write(' ');
                        sw.WriteLine(edge[i].Y);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void saveTypeB()
        {
            filePath = filePath + @"B\" + file_name + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    int n = vertex.Count();
                    int m = edge.Count();
                    sw.WriteLine(n);
                    sw.WriteLine(m);
                    for (int i = 0; i < m; ++i)
                    {
                        sw.Write(edge[i].X);
                        sw.Write(' ');
                        sw.WriteLine(edge[i].Y);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            file_name = textBox_fileName.Text;
            if (button_type == 0 || file_name == "") return;
            if (button_type == 1) saveTypeA();
            if (button_type == 2) saveTypeB();
            Router.GetInstance().GoBack();
        }

        private void Button_aboutType_Click(object sender, EventArgs e) =>
            Router.GetInstance().NavigateTo(new Form_help_aboutType());
    }
}