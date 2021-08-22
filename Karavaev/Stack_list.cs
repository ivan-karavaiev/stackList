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
    class Stack_list
    {
        const int maxN = 35;
        List<Point> vertex = new List<Point>();
        List<Point> edge = new List<Point>();
        List<int>[] g = new List<int>[maxN];
        int n = new int();
        public Stack_list(List<Point> vertex, List<Point> edge)
        {
            n = vertex.Count();
            this.vertex = vertex;
            this.edge = edge;
            for (int i = 0; i < maxN; ++i)
            {
                g[i] = new List<int>();
            }
            for (int i = 0; i < edge.Count(); ++i)
            {
                g[edge[i].X].Add(edge[i].Y);
                g[edge[i].Y].Add(edge[i].X);
            }
        }
        bool[] used = new bool[maxN];
        List<int> DFS_knot = new List<int>();
        List<int> DFS_stack = new List<int>();
        List<List<int>> list_of_stack = new List<List<int>>();
        List<Point> cyclic_edge = new List<Point>();
        public List<List<int>> DFS_knot_in_time = new List<List<int>>();
        public List<List<int>> DFS_stack_in_time = new List<List<int>>();
        public List<List<List<int>>> list_of_stack_in_time = new List<List<List<int>>>();
        public List<List<Point>> cyclic_edge_in_time = new List<List<Point>>();
        void updateInTime()
        {
            DFS_knot_in_time.Add(new List<int>());
            for (int i = 0; i < DFS_knot.Count(); ++i)
            {
                DFS_knot_in_time[DFS_knot_in_time.Count() - 1].Add(DFS_knot[i]);
            }
            DFS_stack_in_time.Add(new List<int>());
            for (int i = 0; i < DFS_stack.Count(); ++i)
            {
                DFS_stack_in_time[DFS_stack_in_time.Count() - 1].Add(DFS_stack[i]);
            }
            cyclic_edge_in_time.Add(new List<Point>());
            for (int i = 0; i < cyclic_edge.Count(); ++i)
            {
                cyclic_edge_in_time[cyclic_edge_in_time.Count() - 1].Add(cyclic_edge[i]);
            }
            list_of_stack_in_time.Add(new List<List<int>>());
            for(int i = 0; i < list_of_stack.Count(); ++i)
            {
                list_of_stack_in_time[list_of_stack_in_time.Count() - 1].Add(new List<int>());
                for (int j = 0; j < list_of_stack[i].Count(); ++j)
                {
                    list_of_stack_in_time[list_of_stack_in_time.Count() - 1][i].Add(list_of_stack[i][j]);
                }
            }
        }

        void dfs(int v, int p = -1)
        {
            used[v] = true;
            DFS_stack.Add(v);
            DFS_knot.Add(v);
            if (list_of_stack.Count() == 0) list_of_stack.Add(new List<int>());
            list_of_stack[list_of_stack.Count() - 1].Add(v);
            updateInTime();
            bool access = false;
            for(int i = 0; i < g[v].Count(); ++i)
            {
                int to = g[v][i];
                if (used[to])
                {
                    Point new_edge = new Point(v, to);
                    Point new_edge_reverse = new Point(to, v);
                    if (to != p && !cyclic_edge.Contains(new_edge))
                    {
                        if (!cyclic_edge.Contains(new_edge_reverse))
                        {
                             cyclic_edge.Add(new_edge);
                        }
                    }
                }
                else
                {
                    if (access)
                    {
                        DFS_knot.Add(v);
                        list_of_stack[list_of_stack.Count() - 1].Add(v);
                    }
                    access = true;
                    dfs(to, v);
                }
            }
            if (access == false)
            {
                DFS_knot.Clear();
                if(list_of_stack[list_of_stack.Count() - 1].Count > 0)
                {
                    list_of_stack.Add(new List<int>());
                }
            }
            DFS_stack.RemoveAt(DFS_stack.Count - 1);
            if(DFS_knot.Count() > 0)
            {
                DFS_knot.RemoveAt(DFS_knot.Count - 1);
            }
            updateInTime();
        }
        public void buildStackList(int startVertex)
        {
            updateInTime();
            for(int i = 0; i < n; ++i)
            {
                if(i == startVertex)
                {
                    dfs(i);
                }
            }
            for(int i = 0; i < n; ++i)
            {
                if(used[i] == false)
                {
                    dfs(i);
                }
            }
            updateInTime();
        }
    }
}
