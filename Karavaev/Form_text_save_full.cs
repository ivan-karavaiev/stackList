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
    public partial class Form_save_to_text : Form
    {
        List<Point> vertex = new List<Point>();
        List<Point> edge = new List<Point>();
        List<List<int>> stackList = new List<List<int>>();

        public Form_save_to_text(List<Point> vertex, List<Point> edge, List<List<int>> stackList)
        {
            InitializeComponent();
            this.vertex = vertex;
            this.edge = edge;
            this.stackList = stackList;
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

        private void Button_typeC_Click(object sender, EventArgs e)
        {
            button_type = 3;
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

        void saveTypeC()
        {
            filePath = filePath + @"C\" + file_name + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    List<List<int>> list_of_stack = new List<List<int>>();
                    for (int i = 0; i < stackList.Count(); ++i)
                    {
                        int m = stackList[i].Count();
                        if (m == 0) continue;
                        list_of_stack.Add(new List<int>());
                        for (int j = 0; j < m; ++j)
                        {
                            list_of_stack[list_of_stack.Count() - 1].Add(stackList[i][j]);
                        }
                    }

                    int n = list_of_stack.Count();
                    sw.WriteLine(n);
                    for (int i = 0; i < n; ++i)
                    {
                        int m = list_of_stack[i].Count();
                        for (int j = 0; j < m; ++j)
                        {
                            sw.Write(list_of_stack[i][j]);
                            sw.Write(' ');
                        }
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
            if (button_type == 3) saveTypeC();
            Router.GetInstance().GoBack();
        }

        private void Button_aboutType_Click(object sender, EventArgs e) =>
            Router.GetInstance().NavigateTo(new Form_help_aboutType());
    }
}