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
    public partial class Form_text_download : Form
    {
        public int form = new int();

        int radius = new int();
        public List<Point> vertex = new List<Point>();
        public List<Point> edge = new List<Point>();
        public Form_text_download(int radius, int form)
        {
            InitializeComponent();
            //Form_practic ownerForm = this.Owner as Form_practic;
            this.radius = radius;
            this.form = form;
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
        void Error(int num = -1)
        {
            //MessageBox.Show(num.ToString());
            MessageBox.Show("Завантажені дані не відповідають типу обраного файлу.");
            Router.GetInstance().GoBack();
        }
        void Download()
        {
            if(form == 0)
            {
                Form_practic ownerForm = this.Owner as Form_practic;
                ownerForm.vertex = vertex;
                ownerForm.edge = edge;
                ownerForm.ViewGraph();
            }
            if (form == 1)
            {
                Form_buildTree ownerForm = this.Owner as Form_buildTree;
                ownerForm.vertex = vertex;
                ownerForm.edge = edge;
                Stack_list stackList = new Stack_list(vertex, edge);
                stackList.buildStackList(0);
                ownerForm.list_of_stack = stackList.list_of_stack_in_time[stackList.list_of_stack_in_time.Count() - 1];
                ownerForm.cyclic_edge = stackList.cyclic_edge_in_time[stackList.cyclic_edge_in_time.Count() - 1];
            }
        }
        void downloadTypeA()
        {
            filePath = filePath + @"A\" + file_name + ".txt";
            int n = -1, m = -1;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    List<int> strElements = new List<int>();
                    int counter = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string s in words)
                        {
                            strElements.Add(Convert.ToInt32(s));
                        }
                        if (counter == 0)
                        {
                            if (strElements.Count() != 1) Error(counter);
                            n = strElements[0];
                        }
                        if (counter >= 1 && counter <= n)
                        {
                            if (strElements.Count() != 2) Error(counter);
                            vertex.Add(new Point(strElements[0], strElements[1]));
                        }
                        if(counter == n + 1)
                        {
                            if (strElements.Count() != 1) Error(counter);
                            m = strElements[0];
                        }
                        if(counter >= n + 2 && counter <= n + m + 1)
                        {
                            if (strElements.Count() != 2) Error(counter);
                            edge.Add(new Point(strElements[0], strElements[1]));
                        }
                        ++counter; strElements.Clear();
                    }
                    if (m != edge.Count() || n != vertex.Count()) Error();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Download();
        }
        void initializationVertex(int n)
        {
            Point[] coordinates = new Point[n];
            StartBuild build = new StartBuild(radius);
            for (int i = 0; i < n; ++i)
            {
                // Good Random
                bool Intersection = true;
                while (Intersection)
                {
                    Intersection = false;
                    coordinates[i].X = build.Next(radius, 500 - radius);
                    coordinates[i].Y = build.Next(radius, 400 - radius);
                    for (int j = 0; j < i && !Intersection; ++j)
                    {
                        Intersection |= build.squareIntersection(coordinates[i], coordinates[j]);
                    }
                }
                vertex.Add(coordinates[i]);
            }
        }
        void downloadTypeB()
        {
            filePath = filePath + @"B\" + file_name + ".txt";
            int n = -1, m = -1;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    List<int> strElements = new List<int>();
                    int counter = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string s in words)
                        {
                            strElements.Add(Convert.ToInt32(s));
                        }
                        if(counter > 1)
                        {
                            if (strElements.Count() != 2) Error(counter);
                            edge.Add(new Point(strElements[0], strElements[1]));
                        }
                        else
                        {
                            if (strElements.Count() != 1) Error(counter);
                            if (n == -1) n = strElements[0];
                            else m = strElements[0];
                        }
                        ++counter; strElements.Clear();
                    }
                    if (m != edge.Count()) Error();
                    initializationVertex(n);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Download();
        }

        private void Button_download_Click(object sender, EventArgs e)
        {
            file_name = textBox_fileName.Text;
            if (button_type == 0 || file_name == "") return;
            if (button_type == 1) downloadTypeA();
            if (button_type == 2) downloadTypeB();
            Router.GetInstance().GoBack();
        }

        private void Button_aboutType_Click(object sender, EventArgs e) =>
            Router.GetInstance().NavigateTo(new Form_help_aboutType());
    }
}
