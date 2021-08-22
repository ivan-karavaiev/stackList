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
    public partial class Form_practic_model : Form
    {
        public Form_practic_model()
        {
            InitializeComponent();
        }
        List<Point> clickList = new List<Point>();
        public List<Point> edge = new List<Point>();
        public List<Point> vertex = new List<Point>();
        bool access = false;
        public Form_practic_model(List<Point> vertex, List<Point> edge)
        {
            InitializeComponent();
            for (int i = 0; i < vertex.Count(); ++i)
            {
                this.vertex.Add(vertex[i]);
            }
            for (int i = 0; i < edge.Count(); ++i)
            {
                this.edge.Add(edge[i]);
            }
            access = true;
        }

        private void Button_practic_model_help_Click(object sender, EventArgs e)
        {
            Form_help newForm = new Form_help();
            newForm.Show();
        }

        private void Button_practic_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void BuildPictureBoxGraphView()
        {
            bmp = new Bitmap(pictureBox_model_GraphView.Width, pictureBox_model_GraphView.Height);
            gr = Graphics.FromImage(bmp);
            gr.Clear(Color.White);
            pictureBox_model_GraphView.Image = bmp;
        }

        void BuildPictureBoxStackView()
        {
            bmp_stack = new Bitmap(pictureBox_model_StackView.Width, pictureBox_model_StackView.Height);
            gr_stack = Graphics.FromImage(bmp_stack);
            gr_stack.Clear(Color.White);
            pictureBox_model_StackView.Image = bmp_stack;
        }

        void BuildPictureBoxStackList()
        {
            bmp_stack_list = new Bitmap(pictureBox_model_StackList.Width, pictureBox_model_StackList.Height);
            gr_stack_list = Graphics.FromImage(bmp_stack_list);
            gr_stack_list.Clear(Color.White);
            pictureBox_model_StackList.Image = bmp_stack_list;
        }

        const int radius = 20;
        StartBuild build = new StartBuild(radius);
        Bitmap bmp, bmp_stack, bmp_stack_list;
        Graphics gr, gr_stack, gr_stack_list;
        private void Form_practic_model_Load(object sender, EventArgs e)
        {
            //Form_practic ownerForm = this.Owner as Form_practic;
            BuildPictureBoxGraphView();
            if (access)
            {
                Button_practic_model_building_Click(sender, e);
                Button_practic_model_modelling_Click(sender, e);
                ViewGraph();
            }
        }

        int building_click = 0;
        private void Button_practic_model_building_Click(object sender, EventArgs e)
        {
            if (building_click == 0)
            {
                button_practic_model_building.Text = "Побудувати ще раз";
            }
            else
            {
                modelling_click = true;
                Button_practic_model_modelling_Click(sender, e);
                gr.Clear(Color.White);
                pictureBox_model_GraphView.Image = bmp;
                clickList.Clear(); edge.Clear(); vertex.Clear();
                //button_practic_model_building.Text = "Розпочати побудову";
            }
            ++building_click;
        }

        public int findIndexInVertex(Point listVertex)
        {
            int index = new int();
            for (int i = 0; i < vertex.Count(); ++i)
            {
                if (build.squareIntersection(vertex[i], listVertex))
                {
                    index = i;
                }
            }
            return index;
        }

        Pen penBlack = new Pen(Color.Black);
        Pen penGreen = new Pen(Color.Green);

        private void PictureBox_model_GraphView_MouseClick(object sender, MouseEventArgs e)
        {
            if (modelling_click) return;
            Point mp = new Point();
            mp.X = e.X; mp.Y = e.Y;
            if (mp.X - radius < 0 || mp.X + radius > 500) return;
            if (mp.Y - radius < 0 || mp.Y + radius > 400) return;
            bool Intersection = false;
            for (int i = 0; i < vertex.Count(); ++i)
            {
                Intersection |= build.squareIntersection(vertex[i], mp);
            }
            if (Intersection) clickList.Add(mp);
            else
            {
                vertex.Add(mp);
                gr = build.DrawRound(gr, penBlack, mp, vertex.Count() - 1);
            }
            if (clickList.Count() == 1)
            {
                int index = findIndexInVertex(clickList[0]);
                gr = build.DrawRound(gr, penGreen, vertex[index], index);
            }
            if (clickList.Count() == 2)
            {
                if (build.squareIntersection(clickList[0], clickList[1]))
                {
                    int position = findIndexInVertex(clickList[0]);
                    gr = build.DrawRound(gr, penBlack, vertex[position], position);
                    clickList.Clear();
                }
                else
                {
                    Point index = new Point();
                    index.X = findIndexInVertex(clickList[0]);
                    index.Y = findIndexInVertex(clickList[1]);
                    if (!(edge.Contains(index) || edge.Contains(new Point(index.Y, index.X))))
                    {
                        edge.Add(index);
                        int position = findIndexInVertex(clickList[0]);
                        gr = build.DrawRound(gr, penBlack, vertex[position], position);
                        gr = build.DrawEdge(gr, penBlack, vertex[index.X], vertex[index.Y]);
                        clickList.Clear();
                    }
                    else
                    {
                        clickList.RemoveAt(1);
                    }
                }
            }
            pictureBox_model_GraphView.Image = bmp;
        }

        int time = 0, maxTime = new int();

        List<List<int>> DFS_knot = new List<List<int>>();
        List<List<int>> DFS_stack = new List<List<int>>();
        List<List<List<int>>> list_of_stack = new List<List<List<int>>>();
        List<List<Point>> cyclic_edge = new List<List<Point>>();

        bool modelling_click = false;

        void ViewGraph()
        {
            gr.Clear(Color.White);
            for(int i = 0; i < vertex.Count(); ++i)
            {
                gr = build.DrawRound(gr, penBlack, vertex[i], i);
            }
            for(int i = 0; i < edge.Count(); ++i)
            {
                gr = build.DrawEdge(gr, penBlack, vertex[edge[i].X], vertex[edge[i].Y]);
            }
            pictureBox_model_GraphView.Image = bmp;
        }

        private void Button_practic_rebuilding_Click(object sender, EventArgs e)
        {
            Form_practic_rebuilding newForm = new Form_practic_rebuilding(vertex, edge, cyclic_edge[maxTime - 1], list_of_stack[maxTime - 1]);
            newForm.Show();
        }

        private void Button_practic_model_icon_upup_Click(object sender, EventArgs e)
        {
            time = maxTime - 2;
            viewGraphInTime(false);
            viewButtonCursor();
        }

        private void Button_practic_model_icon_downdown_Click(object sender, EventArgs e)
        {
            time = 0;
            viewGraphInTime(false);
            viewButtonCursor();
        }

        private void Button_practic_model_text_Click(object sender, EventArgs e)
        {
            Form_save_to_text newForm = new Form_save_to_text(vertex, edge, list_of_stack[maxTime - 1]);
            newForm.Show();
        }

        private void Button_practic_model_modelling_Click(object sender, EventArgs e)
        {
            modelling_click = !modelling_click;
            button_practic_model_icon_up.Visible = modelling_click;
            button_practic_model_icon_down.Visible = modelling_click;
            button_practic_model_icon_upup.Visible = modelling_click;
            button_practic_model_icon_downdown.Visible = modelling_click;
            button_practic_model_icon_down.Cursor = System.Windows.Forms.Cursors.No;
            button_practic_model_icon_downdown.Cursor = System.Windows.Forms.Cursors.No;
            if (modelling_click)
            {
                time = 0;
                BuildPictureBoxStackView();
                BuildPictureBoxStackList();
                button_practic_model_text.Visible = true;
                pictureBox_model_StackView.Visible = true;
                panel_model_StackList.Visible = true;
                button_practic_rebuilding.Visible = true;
                button_practic_model_modelling.Text = "Продовжити побудову";
            }
            else
            {
                button_practic_model_text.Visible = false;
                pictureBox_model_StackView.Visible = false;
                panel_model_StackList.Visible = false;
                button_practic_rebuilding.Visible = false;
                time = 0;
                ViewGraph();
                button_practic_model_modelling.Text = "Розпочати моделювання";
                return;
            }

            Stack_list model = new Stack_list(vertex, edge);
            model.buildStackList(0);
            
            DFS_knot = model.DFS_knot_in_time;
            DFS_stack = model.DFS_stack_in_time;
            list_of_stack = model.list_of_stack_in_time;
            cyclic_edge = model.cyclic_edge_in_time;
            maxTime = DFS_stack.Count();
        }
        void viewButtonCursor()
        {
            if(time == maxTime - 2)
            {
                button_practic_model_icon_upup.Cursor = System.Windows.Forms.Cursors.No;
            }
            else
            {
                button_practic_model_icon_upup.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            if (time == maxTime - 1)
            {
                button_practic_model_icon_up.Cursor = System.Windows.Forms.Cursors.No;
            }
            else
            {
                button_practic_model_icon_up.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            if (time == 0)
            {
                button_practic_model_icon_down.Cursor = System.Windows.Forms.Cursors.No;
                button_practic_model_icon_downdown.Cursor = System.Windows.Forms.Cursors.No;
            }
            else
            {
                button_practic_model_icon_downdown.Cursor = System.Windows.Forms.Cursors.Hand;
                button_practic_model_icon_down.Cursor = System.Windows.Forms.Cursors.Hand;
            }
        }
        void viewGraphInTime(bool viewCyclicEdge)
        {
            ViewData view = new ViewData(vertex, edge, DFS_knot[time], DFS_stack[time], list_of_stack[time], cyclic_edge[time], viewCyclicEdge);
            gr.Clear(Color.White);
            gr_stack.Clear(Color.White);
            gr_stack_list.Clear(Color.White);
            gr = view.viewGraph(gr);
            gr_stack = view.viewStack(gr_stack);
            gr_stack_list = view.viewStackList(gr_stack_list);
            pictureBox_model_GraphView.Image = bmp;
            pictureBox_model_StackView.Image = bmp_stack;
            pictureBox_model_StackList.Image = bmp_stack_list;
        }
        private void Button_practic_model_icon_up_Click(object sender, EventArgs e)
        {
            if (!modelling_click) return;
            ++time;
            if(time == maxTime)
            {
                --time; return;
            }
            viewButtonCursor();
            if(time == maxTime - 1)
            {
                viewGraphInTime(true);
            }
            else
            {
                viewGraphInTime(false);
            }
        }
        private void Button_practic_model_icon_down_Click(object sender, EventArgs e)
        {
            if (!modelling_click) return;
            --time;
            if (time == -1)
            {
                ++time; return;
            }
            viewButtonCursor();
            viewGraphInTime(false);
        }
    }
}
