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
    public partial class Form_practic_rebuilding : Form
    {
        public Form_practic_rebuilding()
        {
            InitializeComponent();
        }

        List<Point> vertex = new List<Point>();
        List<Point> edge = new List<Point>();
        List<Point> cyclicEdge = new List<Point>();
        List<List<int>> stackList = new List<List<int>>();

        public Form_practic_rebuilding(List<Point> vertex, List<Point> edge, List<Point> cyclicEdge, List<List<int>> stackList)
        {
            InitializeComponent();
            BuildPictureBoxGraphView();
            for (int i = 0; i < stackList.Count(); ++i)
            {
                this.stackList.Add(new List<int>());
                for(int j = 0; j < stackList[i].Count(); ++j)
                {
                    this.stackList[i].Add(stackList[i][j]);
                }
            }
            this.cyclicEdge = cyclicEdge;
            this.vertex = vertex;
            this.edge = edge;
            ViewGraph();
        }

        private void Form_practic_rebuilding_Load(object sender, EventArgs e)
        {
            BuildPictureBoxRebuilding();
            ViewData view = new ViewData(stackList);
            view.viewRebuildFindCoordinates(2);
            gr_rebuild = view.viewRebuild(gr_rebuild);
        }

        const int radius = 20;
        StartBuild build = new StartBuild(radius);
        Bitmap bmp, bmp_rebuild;
        Graphics gr, gr_rebuild;

        Pen penBlack = new Pen(Color.Black);
        Pen penGreen = new Pen(Color.Green);

        void BuildPictureBoxGraphView()
        {
            bmp = new Bitmap(pictureBox_rebuilding_GraphView.Width, pictureBox_rebuilding_GraphView.Height);
            gr = Graphics.FromImage(bmp);
            gr.Clear(Color.White);
            pictureBox_rebuilding_GraphView.Image = bmp;
        }

        bool viewCycle = false;
        private void Button_practic_rebuilding_cycle_Click(object sender, EventArgs e)
        {
            viewCycle = !viewCycle;
            if (viewCycle)
            {
                button_practic_rebuilding_cycle.Text = "Приховати цикли";
                ViewGraph();
            }
            else
            {
                button_practic_rebuilding_cycle.Text = "Відобразити цикли";
                ViewGraph();
            }
        }

        private void Button_practic_rebuilding_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       /*private void Button_saveTree_Click(object sender, EventArgs e)
        {
            if (pictureBox_practic_rebuilding.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Coxранить картинку как";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox_practic_rebuilding.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо зберегти зображення", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }*/

        void BuildPictureBoxRebuilding()
        {
            bmp_rebuild = new Bitmap(pictureBox_practic_rebuilding.Width, pictureBox_practic_rebuilding.Height);
            gr_rebuild = Graphics.FromImage(bmp_rebuild);
            gr_rebuild.Clear(Color.White);
            pictureBox_practic_rebuilding.Image = bmp_rebuild;
        }

        void ViewGraph()
        {
            gr.Clear(Color.White);
            for (int i = 0; i < vertex.Count(); ++i)
            {
                gr = build.DrawRound(gr, penBlack, vertex[i], i);
            }
            for (int i = 0; i < edge.Count(); ++i)
            {
                if (!viewCycle)
                {
                    if(cyclicEdge.Contains(edge[i]) || cyclicEdge.Contains(new Point(edge[i].Y, edge[i].X)))
                    {
                        continue;
                    }
                }
                gr = build.DrawEdge(gr, penBlack, vertex[edge[i].X], vertex[edge[i].Y]);
            }
            pictureBox_rebuilding_GraphView.Image = bmp;
        }
    }
}
