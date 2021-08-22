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
    public partial class Form_practic : Form
    {
        public Form_practic()
        {
            InitializeComponent();
        }

        // Button
        private void Button_practic_back_Click(object sender, EventArgs e) => Router.GetInstance().GoBack();

        private void Button_practic_model_Click(object sender, EventArgs e) =>
            Router.GetInstance().NavigateTo(new Form_practic_model());

        // Початок побудови
        Bitmap bmp;
        Graphics gr;
        Pen penBlack = new Pen(Color.Black);

        private void Form_practic_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox_GraphView.Width, pictureBox_GraphView.Height);
            gr = Graphics.FromImage(bmp);
            gr.Clear(Color.White);
            pictureBox_GraphView.Image = bmp;
        }

        public List<Point> vertex = new List<Point>();
        public List<Point> edge = new List<Point>();

        const int mxN = 25;
        const int radius = 20;
        StartBuild build = new StartBuild(radius);

        public void ViewGraph()
        {
            gr.Clear(Color.White);
            for (int i = 0; i < vertex.Count(); ++i)
            {
                gr = build.DrawRound(gr, penBlack, vertex[i], i);
            }

            for (int i = 0; i < edge.Count(); ++i)
            {
                gr = build.DrawEdge(gr, penBlack, vertex[edge[i].X], vertex[edge[i].Y]);
            }

            pictureBox_GraphView.Image = bmp;
        }

        void initializationVertex(int n)
        {
            Point[] coordinates = new Point[n];
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

        private void Button_practic_random_Click(object sender, EventArgs e)
        {
            int n = build.Next(1, mxN);
            vertex.Clear();
            initializationVertex(n);

            // ininitialization Edge
            edge.Clear();
            int m = build.Next(0, n * (n - 1) / 2);
            for (int i = 0; i < m; ++i)
            {
                while (true)
                {
                    Point to = new Point(build.Next(0, n - 1), build.Next(0, n - 1));
                    Point rto = new Point(to.Y, to.X);
                    if (!edge.Contains(to) && !edge.Contains(rto) && to.X != to.Y)
                    {
                        edge.Add(to);
                        break;
                    }
                }

                Point way = edge[i];
            }

            ViewGraph();
        }

        // DSU 
        int[] p = new int[mxN];
        int[] sz = new int[mxN];

        void build_set()
        {
            for (int i = 0; i < mxN; ++i)
            {
                p[i] = i;
                sz[i] = 1;
            }
        }

        int find_set(int v)
        {
            if (p[v] == v) return v;
            return p[v] = find_set(p[v]);
        }

        bool union_sets(int x, int y)
        {
            x = find_set(x);
            y = find_set(y);
            if (x != y)
            {
                if (sz[x] < sz[y])
                {
                    int swap = sz[y];
                    sz[y] = sz[x];
                    sz[x] = swap;
                }

                p[y] = x;
                sz[x] += sz[y];
                sz[y] = 0;
                return true;
            }

            return false;
        }

        //
        private void Button_practic_random_tree_Click(object sender, EventArgs e)
        {
            vertex.Clear();
            int n = build.Next(1, mxN);
            initializationVertex(n);

            edge.Clear();
            int m = n - 1;
            build_set();
            for (int i = 0; i < m; ++i)
            {
                while (true)
                {
                    int x = build.Next(0, n - 1);
                    int y = build.Next(0, n - 1);
                    if (union_sets(x, y))
                    {
                        edge.Add((new Point(x, y)));
                        break;
                    }
                }
            }

            ViewGraph();
        }

        private void Button_practic_random_acyclic_Click(object sender, EventArgs e)
        {
            vertex.Clear();
            int n = build.Next(1, mxN);
            initializationVertex(n);

            edge.Clear();
            int m = build.Next(0, n - 1);
            build_set();
            for (int i = 0; i < m; ++i)
            {
                while (true)
                {
                    int x = build.Next(0, n - 1);
                    int y = build.Next(0, n - 1);
                    if (union_sets(x, y))
                    {
                        edge.Add((new Point(x, y)));
                        break;
                    }
                }
            }

            ViewGraph();
        }

        private void Button_practic_modellling_Click(object sender, EventArgs e) =>
            Router.GetInstance().NavigateTo(new Form_practic_model(vertex, edge));

        private void Button_practic_model_text_download_Click(object sender, EventArgs e)
        {
            var newForm = new Form_text_download(radius, 0);
            newForm.Owner = this;
            
            Router.GetInstance().NavigateTo(newForm);
        }

        private void Button_practic_model_text_save_Click(object sender, EventArgs e) =>
            Router.GetInstance().NavigateTo(new Form_text_save(vertex, edge));
    }
}