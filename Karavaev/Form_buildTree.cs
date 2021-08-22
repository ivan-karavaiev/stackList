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
    public partial class Form_buildTree : Form
    {
        public Form_buildTree()
        {
            InitializeComponent();
        }

        public List<Point> vertex = new List<Point>();
        public List<Point> edge = new List<Point>();
        public List<Point> cyclic_edge = new List<Point>();
        public List<List<int>> list_of_stack = new List<List<int>>();
        private void Button_textDownload_Click(object sender, EventArgs e)
        {
            var newForm = new Form_text_download(20, 1);
            newForm.Owner = this;
            
            Router.GetInstance().NavigateTo(newForm);
        }

        Bitmap bmp;
        Graphics gr;
        Pen penBlack = new Pen(Color.Black);

        StartBuild build = new StartBuild();

        int radius = 20;

        private void Form_buildTree_Load(object sender, EventArgs e)
        {
            radius = build.radius;
            bmp = new Bitmap(pictureBox_stackTree.Width, pictureBox_stackTree.Height);
            gr = Graphics.FromImage(bmp);
            gr.Clear(Color.White);
            pictureBox_stackTree.Image = bmp;
        }

        int w = 945, h = 603;

        void setBaseSize()
        {
            pictureBox_stackTree.Width = w;
            pictureBox_stackTree.Height = h;
            bmp = new Bitmap(pictureBox_stackTree.Width, pictureBox_stackTree.Height);
            gr = Graphics.FromImage(bmp);
            gr.Clear(Color.White);
        }

        void updateSize(List<Point> coordinates)
        {
            int wMax = 0, hMax = 0;
            for(int i = 0; i < coordinates.Count(); ++i)
            {
                wMax = Math.Max(wMax, coordinates[i].X);
                hMax = Math.Max(hMax, coordinates[i].Y);
            }
            wMax += radius; hMax += radius;
            if (wMax > w) wMax += 5;
            if (hMax > h) hMax += 5;
            wMax = Math.Max(wMax, w);
            hMax = Math.Max(hMax, h);
            pictureBox_stackTree.Width = wMax;
            pictureBox_stackTree.Height = hMax;
            bmp = new Bitmap(pictureBox_stackTree.Width, pictureBox_stackTree.Height);
            gr = Graphics.FromImage(bmp);
            gr.Clear(Color.White);
        }

        private void RadioButton_build_Graph_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_build_Graph.Checked) return;

            setBaseSize();

            for(int i = 0; i < vertex.Count(); ++i)
            {
                build.DrawRound(gr, penBlack, vertex[i], i);
            }
            for(int i = 0; i < edge.Count(); ++i)
            {
                build.DrawEdge(gr, penBlack, vertex[edge[i].X], vertex[edge[i].Y]);
            }

            pictureBox_stackTree.Image = bmp;
        }

        private void RadioButton_build_AcyclicGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_build_AcyclicGraph.Checked) return;

            setBaseSize();

            for (int i = 0; i < vertex.Count(); ++i)
            {
                build.DrawRound(gr, penBlack, vertex[i], i);
            }

            for (int i = 0; i < edge.Count(); ++i)
            {
                if (cyclic_edge.Contains(edge[i])) continue;
                if (cyclic_edge.Contains(new Point(edge[i].Y, edge[i].X))) continue;
                build.DrawEdge(gr, penBlack, vertex[edge[i].X], vertex[edge[i].Y]);
            }

            pictureBox_stackTree.Image = bmp;
        }

        private void RadioButton_build_StackList_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_build_StackList.Checked) return;

            setBaseSize();

            ViewData view = new ViewData(edge, list_of_stack, cyclic_edge);
            view.viewOnlyStackListFindCoordinates();
            updateSize(view.vertex);
            gr = view.viewOnlyStackList(gr);

            pictureBox_stackTree.Image = bmp;
        }

        private void RadioButton_build_StackListFull_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_build_StackListFull.Checked) return;

            setBaseSize();

            ViewData view = new ViewData(edge, list_of_stack, cyclic_edge);
            view.viewStackListFindCoordinates();
            updateSize(view.vertex);
            gr = view.viewStackList(gr);

            pictureBox_stackTree.Image = bmp;
        }

        private void RadioButton_build_StackTree_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_build_StackTree.Checked) return;

            setBaseSize();

            ViewData view = new ViewData(list_of_stack);
            view.viewRebuildFindCoordinates(1);
            updateSize(view.vertex);
            gr = view.viewRebuild(gr);

            pictureBox_stackTree.Image = bmp;
        }

        private void RadioButton_build_StackTreeCompressed_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_build_StackTreeCompressed.Checked) return;

            setBaseSize();

            ViewData view = new ViewData(list_of_stack);
            view.viewRebuildFindCoordinates(2);
            updateSize(view.vertex);
            gr = view.viewRebuild(gr);

            pictureBox_stackTree.Image = bmp;
        }

        private void Button_build_save_Click(object sender, EventArgs e)
        {
            if (pictureBox_stackTree.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Зберегти зображення як...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox_stackTree.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо зберегти зображення", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Button_build_back_Click(object sender, EventArgs e)
        {
            Router.GetInstance().GoBack();
        }
    }
}
