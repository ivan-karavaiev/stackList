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
    class ViewData : StartBuild
    {
        public ViewData() { }
        public List<Point> vertex = new List<Point>();
        List<Point> edge = new List<Point>();
        List<int> DFS_knot = new List<int>();
        List<int> DFS_stack = new List<int>();
        List<List<int>> list_of_stack = new List<List<int>>();
        List<Point> cyclic_edge = new List<Point>();
        bool viewCyclicEdge = new bool();
        int nowVertex = -1;
        public ViewData(List<Point> vertex, List<Point> edge, List<int> DFS_knot, List<int> DFS_stack, List<List<int>> list_of_stack, List<Point> cyclic_edge, bool viewCyclicEdge)
        {
            this.vertex = vertex;
            this.edge = edge;
            this.DFS_knot = DFS_knot;
            this.DFS_stack = DFS_stack;
            this.list_of_stack = list_of_stack;
            this.cyclic_edge = cyclic_edge;
            this.viewCyclicEdge = viewCyclicEdge;
            if(DFS_stack.Count() > 0)
            {
                nowVertex = DFS_stack[DFS_stack.Count() - 1];
            }
        }
        public ViewData(List<Point> vertex, List<Point> edge, List<List<int>> list_of_stack, List<Point> cyclic_edge)
        {
            this.vertex = vertex;
            this.edge = edge;
            this.list_of_stack = list_of_stack;
            this.cyclic_edge = cyclic_edge;
        }

        public ViewData(List<Point> edge, List<List<int>> list_of_stack, List<Point> cyclic_edge)
        {
            this.edge = edge;
            this.list_of_stack = list_of_stack;
            this.cyclic_edge = cyclic_edge;
        }

        List<List<int>> stackList = new List<List<int>>();
        public ViewData(List<List<int>> stackList)
        {
            this.stackList = stackList;
        }

        Pen penBlack = new Pen(Color.Black);
        Pen penBlue = new Pen(Color.Blue);
        Pen penRed = new Pen(Color.Red);
        Pen penGreen = new Pen(Color.Green);
        public Graphics viewGraph(Graphics gr)
        {
            for (int i = 0; i < vertex.Count(); ++i)
            {
                gr = DrawRound(gr, penBlack, vertex[i], i);
            }
            if (DFS_knot.Count() == 0 && DFS_stack.Count() > 0)
            {
                int index = DFS_stack[DFS_stack.Count() - 1];
                gr = DrawRound(gr, penBlue, vertex[index], index);
            }
            if (DFS_knot.Count() == 1)
            {
                gr = DrawRound(gr, penRed, vertex[DFS_knot[0]], DFS_knot[0]);
            }
            if (DFS_knot.Count() > 1)
            {
                gr = DrawRound(gr, penRed, vertex[DFS_knot[0]], DFS_knot[0]);
                for (int i = 1; i < DFS_knot.Count() - 1; ++i)
                {
                    gr = DrawRound(gr, penGreen, vertex[DFS_knot[i]], DFS_knot[i]);
                }
                int index = DFS_stack[DFS_stack.Count() - 1];
                gr = DrawRound(gr, penBlue, vertex[index], index);
            }
            if (viewCyclicEdge)
            {
                for (int i = 0; i < cyclic_edge.Count(); ++i)
                {
                    gr = DrawEdge(gr, penRed, vertex[cyclic_edge[i].X], vertex[cyclic_edge[i].Y]);
                }
            }
            for (int i = 0; i < edge.Count(); ++i)
            {
                Point rEdge = new Point(edge[i].Y, edge[i].X);
                if (cyclic_edge.Contains(edge[i]) || cyclic_edge.Contains(rEdge)) continue;
                gr = DrawEdge(gr, penBlack, vertex[edge[i].X], vertex[edge[i].Y]);
            }
            return gr;
        }
        public Graphics viewStack(Graphics gr)
        {
            radius += 5;
            Point size = new Point(80, 400);
            Point centerPosition = new Point(size.X / 2, size.Y - radius);
            int kol = 8;
            for (int i = Math.Max(0, DFS_stack.Count() - kol); i < DFS_stack.Count(); ++i)
            {
                gr = DrawRound(gr, penBlack, centerPosition, DFS_stack[i]);
                centerPosition.Y -= 2 * radius;
            }
            radius -= 5;
            return gr;
        }

        public void viewOnlyStackListFindCoordinates()
        {
            vertex.Clear();
            int delta = 5;
            Point position = new Point(radius + delta, radius * 3 + 10);
            int rowDelta = 5, columnDelta = 5;

            Point coordinate = new Point(155, radius);
            for (int i = 0; i < list_of_stack.Count(); ++i)
            {
                if (list_of_stack[i].Count() == 0) continue;
                for (int j = 0; j < list_of_stack[i].Count(); ++j)
                {
                    vertex.Add(position);
                    position.X += columnDelta + 2 * radius;
                }
                position.Y += rowDelta + 2 * radius;
                position.X = radius + delta;
            }

        }
        public Graphics viewOnlyStackList(Graphics gr)
        {
            int delta = 5;
            Point position = new Point(radius + delta, radius * 3 + 10);
            int rowDelta = 5, columnDelta = 5;

            Point coordinate = new Point(155, radius);
            gr = DrawString(gr, "Список стеків", coordinate);

            for (int i = 0; i < list_of_stack.Count(); ++i)
            {
                if (list_of_stack[i].Count() == 0) continue;
                for (int j = 0; j < list_of_stack[i].Count(); ++j)
                {
                    if (nowVertex == list_of_stack[i][j])
                    {
                        gr = DrawRound(gr, penBlue, position, list_of_stack[i][j]);
                    }
                    else
                    {
                        gr = DrawRound(gr, penBlack, position, list_of_stack[i][j]);
                    }
                    position.X += columnDelta + 2 * radius;
                }
                position.Y += rowDelta + 2 * radius;
                position.X = radius + delta;
            }

            return gr;
        }

        public void viewStackListFindCoordinates()
        {
            vertex.Clear();

            int delta = 5;
            Point position = new Point(radius + delta, radius * 3 + 10);
            int rowDelta = 5, columnDelta = 5;

            Point coordinate = new Point(155, radius);

            for (int i = 0; i < list_of_stack.Count(); ++i)
            {
                if (list_of_stack[i].Count() == 0) continue;
                for (int j = 0; j < list_of_stack[i].Count(); ++j)
                {
                    vertex.Add(position);
                    position.X += columnDelta + 2 * radius;
                }
                position.Y += rowDelta + 2 * radius;
                position.X = radius + delta;
            }

            position.Y += -radius + 10;

            coordinate = new Point(95, position.Y);

            position.Y += radius * 2 + 10;

            List<int>[] gEdge = new List<int>[maxN];
            for (int i = 0; i < maxN; ++i)
            {
                gEdge[i] = new List<int>();
            }
            for (int i = 0; i < cyclic_edge.Count(); ++i)
            {
                gEdge[cyclic_edge[i].X].Add(cyclic_edge[i].Y);
                gEdge[cyclic_edge[i].Y].Add(cyclic_edge[i].X);
            }

            for (int i = 0; i < maxN; ++i)
            {
                if (gEdge[i].Count() == 0) continue;
                position.X = radius + delta;
                vertex.Add(position);
                position.X += 3 * radius;
                for (int j = 0; j < gEdge[i].Count(); ++j)
                {
                    if (gEdge[i][j] == i) continue;
                    vertex.Add(position);
                    position.X += columnDelta + 2 * radius;
                }
                position.Y += 2 * radius + rowDelta;
            }
        }

        public Graphics viewStackList(Graphics gr)
        {
            int delta = 5;
            Point position = new Point(radius + delta, radius * 3 + 10);
            int rowDelta = 5, columnDelta = 5;

            Point coordinate = new Point(155, radius);
            gr = DrawString(gr, "Список стеків", coordinate);

            for (int i = 0; i < list_of_stack.Count(); ++i)
            {
                if (list_of_stack[i].Count() == 0) continue;
                for (int j = 0; j < list_of_stack[i].Count(); ++j)
                {
                    if (nowVertex == list_of_stack[i][j])
                    {
                        gr = DrawRound(gr, penBlue, position, list_of_stack[i][j]);
                    }
                    else
                    {
                        gr = DrawRound(gr, penBlack, position, list_of_stack[i][j]);
                    }
                    position.X += columnDelta + 2 * radius;
                }
                position.Y += rowDelta + 2 * radius;
                position.X = radius + delta;
            }

            position.Y += -radius + 10;

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            coordinate = new Point(95, position.Y);
            gr.DrawString("Ребра які утворюють цикли", drawFont, drawBrush, coordinate);

            position.Y += radius * 2 + 10;

            List<int>[] gEdge = new List<int>[maxN];
            for(int i = 0; i < maxN; ++i)
            {
                gEdge[i] = new List<int>();
            }
            for(int i = 0; i < cyclic_edge.Count(); ++i)
            {
                gEdge[cyclic_edge[i].X].Add(cyclic_edge[i].Y);
                gEdge[cyclic_edge[i].Y].Add(cyclic_edge[i].X);
            }

            for(int i = 0; i < maxN; ++i)
            {
                if (gEdge[i].Count() == 0) continue;
                position.X = radius + delta;
                if(nowVertex == i)
                {
                    DrawRound(gr, penBlue, position, i);
                }
                else
                {
                    DrawRound(gr, penBlack, position, i);
                }
                position.X += 3 * radius;
                gr = DrawEdge(gr, penRed, position, new Point(position.X - 3 * radius, position.Y));
                for (int j = 0; j < gEdge[i].Count(); ++j)
                {
                    if (gEdge[i][j] == i) continue;
                    if (nowVertex == gEdge[i][j])
                    {
                        DrawRound(gr, penBlue, position, gEdge[i][j]);
                    }
                    else
                    {
                        DrawRound(gr, penBlack, position, gEdge[i][j]);
                    }
                    position.X += columnDelta + 2 * radius;
                }
                position.Y += 2 * radius + rowDelta;
            }
            return gr;
        }

        List<int>[] graph = new List<int>[maxN];
        List<int> startVertices = new List<int>();
        Point[] coordinates = new Point[maxN];

        public Graphics viewRebuild(Graphics gr)
        {
            for(int i = 0; i < vertex.Count(); ++i)
            {
                gr = DrawRound(gr, penBlack, vertex[i], i);
            }
            for (int i = 0; i < stackList.Count(); ++i)
            {
                int m = stackList[i].Count();
                int st = 2; if (startVertices.Contains(i)) st = 1;
                for (int j = st; j < m; ++j)
                {
                    gr = DrawEdge(gr, penBlack, coordinates[stackList[i][j - 1]], coordinates[stackList[i][j]]);
                }
            }
            for (int i = 0; i < edge.Count(); ++i)
            {
                Point pos1 = coordinates[edge[i].X];
                Point pos2 = coordinates[edge[i].Y];
                if (pos1.Y > pos2.Y)
                {
                    pos1 = coordinates[edge[i].Y];
                    pos2 = coordinates[edge[i].X];
                }
                pos1.Y += radius; pos2.Y -= radius;
                gr.DrawLine(penBlack, pos1, new Point(pos1.X, pos2.Y - radius));
                gr.DrawLine(penBlack, pos2, new Point(pos2.X, pos2.Y - radius));
                gr.DrawLine(penBlack, new Point(pos2.X, pos2.Y - radius), new Point(pos1.X, pos2.Y - radius));
            }
            return gr;
        }
        public void viewRebuildFindCoordinates(int status)
        {
            Stack_tree stackTree = new Stack_tree(stackList);
            stackTree.findCoordinates(status);

            int nList = stackTree.listCount, nVertex = stackTree.vertexCount;
            edge = stackTree.edge;
            coordinates = stackTree.coordinates;
            stackList = stackTree.stackList;
            startVertices = stackTree.startVertices;

            int mn = 0;
            for(int i = 0; i < nVertex; ++i)
            {
                mn = Math.Min(mn, coordinates[i].X);
            }
            int deltaX = 5, deltaY = 5;
            for(int i = 0; i < nVertex; ++i)
            {
                coordinates[i].X += -mn;
                coordinates[i].X = deltaX + radius + 4 * radius * coordinates[i].X;
                coordinates[i].Y = deltaY + radius + 4 * radius * coordinates[i].Y;
                //gr = DrawRound(gr, penBlack, coordinates[i], i);
                vertex.Add(coordinates[i]);
            }
        }
    }
}
