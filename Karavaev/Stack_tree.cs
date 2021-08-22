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
    class Stack_tree : StartBuild
    {

        public List<List<int>> stackList = new List<List<int>>();
  
        public Stack_tree(List<List<int>> stackList)
        {
            this.stackList = stackList;
        }

        bool[] usedVertex = new bool[maxN];
        public Point[] coordinates = new Point[maxN];
        public List<int>[] graph = new List<int>[maxN];

        int yPosition = 0;
        void dfs(int vertex, int ancestor = -1)
        {
            usedVertex[vertex] = true;
            if (ancestor == -1)
            {
                List<int> way = stackList[vertex];
                coordinates[way[0]] = new Point(0, yPosition);
                for (int i = 1; i < way.Count(); ++i)
                {
                    coordinates[way[i]] = new Point(coordinates[way[i - 1]].X + 1, coordinates[way[i - 1]].Y);
                }
            }
            List<int> adjacent = new List<int>();
            for (int i = 0; i < graph[vertex].Count(); ++i)
            {
                if (usedVertex[graph[vertex][i]] == true) continue;
                adjacent.Add(graph[vertex][i]);
            }

            List<int> wayWertex = stackList[vertex];
            int st = 1; if (ancestor == -1) st = 0;

            for (int i = st; i < wayWertex.Count(); ++i)
            {
                List<int> toAdjacent = new List<int>();
                for (int j = 0; j < adjacent.Count(); ++j)
                {
                    if (stackList[adjacent[j]][0] != wayWertex[i]) continue;
                    toAdjacent.Add(adjacent[j]);
                }
                if (toAdjacent.Count() > 0) ++yPosition;
                int x = coordinates[wayWertex[i]].X;
                for (int j = toAdjacent.Count() - 1; j >= 0; --j)
                {
                    List<int> way = stackList[toAdjacent[j]];
                    for (int k = way.Count() - 1; k >= 1; --k)
                    {
                        coordinates[way[k]] = new Point(x, yPosition);
                        --x;
                    }
                }
                for (int j = 0; j < toAdjacent.Count(); ++j)
                {
                    dfs(toAdjacent[j], vertex);
                }
            }
        }

        int lastRow = 35;
        int[] lastXposition = new int[maxN];

        int findYposition(int value)
        {
            for (int i = 0; i < lastRow; ++i)
            {
                if (lastXposition[i] < value)
                {
                    return i;
                }
            }
            return -1;
        }

        void dfsCompressed(int vertex, int ancestor = -1)
        {
            int nowYposition = new int();

            usedVertex[vertex] = true;
            if (ancestor == -1)
            {
                List<int> way = stackList[vertex];
                nowYposition = findYposition(0);
                coordinates[way[0]] = new Point(0, nowYposition);
                for (int i = 1; i < way.Count(); ++i)
                {
                    coordinates[way[i]] = new Point(coordinates[way[i - 1]].X + 1, coordinates[way[i - 1]].Y);
                }
                for(int i = 0; i <= nowYposition; ++i)
                {
                    if(coordinates[way[way.Count() - 1]].X > lastXposition[nowYposition])
                    {
                        lastXposition[nowYposition] = coordinates[way[way.Count() - 1]].X;
                    }
                }
            }
            List<int> adjacent = new List<int>();
            for (int i = 0; i < graph[vertex].Count(); ++i)
            {
                if (usedVertex[graph[vertex][i]] == true) continue;
                adjacent.Add(graph[vertex][i]);
            }

            List<int> wayWertex = stackList[vertex];
            int st = 1; if (ancestor == -1) st = 0;

            for (int i = st; i < wayWertex.Count(); ++i)
            {
                int size = 0;
                List<int> toAdjacent = new List<int>();
                for (int j = 0; j < adjacent.Count(); ++j)
                {
                    if (stackList[adjacent[j]][0] != wayWertex[i]) continue;
                    size += stackList[adjacent[j]].Count() - 1;
                    toAdjacent.Add(adjacent[j]);
                }
                if (toAdjacent.Count() == 0) continue;
                nowYposition = findYposition(coordinates[wayWertex[i]].X - size + 1);
                for (int j = 0; j <= nowYposition; ++j)
                {
                    if (coordinates[wayWertex[i]].X > lastXposition[j])
                    {
                        lastXposition[j] = coordinates[wayWertex[i]].X;
                    }
                }
                int x = coordinates[wayWertex[i]].X;
                for (int j = toAdjacent.Count() - 1; j >= 0; --j)
                {
                    List<int> way = stackList[toAdjacent[j]];
                    for (int k = way.Count() - 1; k >= 1; --k)
                    {
                        coordinates[way[k]] = new Point(x, nowYposition);
                        --x;
                    }
                }
                for (int j = 0; j < toAdjacent.Count(); ++j)
                {
                    dfsCompressed(toAdjacent[j], vertex);
                }
            }
        }

        public int vertexCount = 0, listCount = new int();
        public List<Point> edge = new List<Point>();
        public List<int> startVertices = new List<int>();

        public void findCoordinates(int status)
        {
            List<List<int>> list_of_stack = new List<List<int>>();
            for (int i = 0; i < stackList.Count(); ++i)
            {
                if (stackList[i].Count() == 0) continue;
                list_of_stack.Add(new List<int>());
                for (int j = 0; j < stackList[i].Count(); ++j)
                {
                    list_of_stack[list_of_stack.Count() - 1].Add(stackList[i][j]);
                }
            } stackList = list_of_stack;

            listCount = stackList.Count();

            List<int> setVertex = new List<int>();
            for (int i = 0; i < listCount; ++i)
            {
                graph[i] = new List<int>();
                int m = stackList[i].Count();
                vertexCount += m;
                if(setVertex.Contains(stackList[i][0]) == false)
                {
                    startVertices.Add(i);
                }
                for(int j = 0; j < m; ++j)
                {
                    if (!setVertex.Contains(stackList[i][j]))
                    {
                        setVertex.Add(stackList[i][j]);
                    }
                }
                for (int j = i + 1; j < listCount; ++j)
                {
                    if (stackList[i].Contains(stackList[j][0]) && (startVertices.Contains(i) || stackList[i][0] != stackList[j][0]))
                    {
                        graph[i].Add(j);
                        edge.Add(new Point(stackList[j][0], stackList[j][1]));
                    }
                }
            }
            vertexCount -= (listCount - startVertices.Count());

            if(status == 1)
            {
                for (int i = 0; i < listCount; ++i)
                {
                    if (usedVertex[i] == false)
                    {
                        dfs(i); ++yPosition;
                    }
                }
            }
            if(status == 2)
            {
                for (int i = 0; i < maxN; ++i)
                {
                    lastXposition[i] = -1000;
                }
                for (int i = 0; i < listCount; ++i)
                {
                    if (usedVertex[i] == false)
                    {
                        dfsCompressed(i);
                    }
                }
            }
        }
    }
}
