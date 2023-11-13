using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace GraphTheoryProject
{
    class graph
    {
        private int nodes_num;
        private int lines_num;
        private Vertix source,sink;

        #region properyies

        public int Nodes_num
        {
            get { return nodes_num; }
            set { nodes_num = value; }
        }
        
        public int Lines_num
        {
            get { return lines_num; }
            set { lines_num = value; }
        }
        
        public Vertix Source
        {
            get { return source; }
            set { source = value; }
        }
        
        public Vertix Sink
        {
            get { return sink; }
            set { sink = value; }
        }

        #endregion

        public  LinkedList<Edge> lines = new LinkedList<Edge>();

        public  LinkedList<Vertix> nodes = new LinkedList<Vertix>();

        public LinkedList<Vertix> Vs;

        public  void readXML(string fileName)
        {
            XmlNodeList list;
            XmlNode root;
            XmlDocument doc = new XmlDocument();
            //doc = new XmlDocument();
            doc.Load(fileName);

            root = doc.DocumentElement;

            Nodes_num = root.ChildNodes[0].ChildNodes.Count;
            Lines_num = root.ChildNodes[1].ChildNodes.Count;
            for (int i = 0; i < Nodes_num; i++)
            {
                list = root.ChildNodes[0].ChildNodes;
                if (list.Item(1).Name == "node")
                {
                    list = root.ChildNodes[0].ChildNodes[i].ChildNodes;
                    string name = list.Item(0).InnerText.Trim();
                    Vertix n = new Vertix(name);
                    nodes.AddLast(n);
                }


            }
            for (int i = 0; i < Lines_num; i++)
            {
                list = root.ChildNodes[1].ChildNodes;
                if (list.Item(1).Name == "line")
                {
                    list = root.ChildNodes[1].ChildNodes[i].ChildNodes;
                    Edge l = new Edge();
                    l.Name = list.Item(0).InnerText.Trim();
                    string from = list.Item(1).InnerText.Trim();
                    for (int m = 0; m < Nodes_num; m++)
                    {
                        if (nodes.ElementAt(m).Name == from)
                            l.Bigen = nodes.ElementAt(m);
                    }
                    string to = list.Item(2).InnerText.Trim();
                    for (int m = 0; m < Nodes_num; m++)
                    {
                        if (nodes.ElementAt(m).Name == to)
                            l.End = nodes.ElementAt(m);
                    }

                    l.cap = int.Parse(list.Item(3).InnerText.Trim());
                    lines.AddLast(l);
                }

            }

        }

        public void check()
        {
            LinkedList<Vertix> multiSource = new LinkedList<Vertix>();
            
            int c = 0;
            foreach(Vertix v in nodes)
            {
                if (v.Negative_degree == 0)
                {
                    c++;
                    multiSource.AddLast(v);
                }
            }
            if (c > 1)
            {
                int[] newCap = new int[c];
                for(int j=0;j<multiSource.Count;j++)
                {
                    foreach (Edge e in lines)
                        if (e.Bigen.Name == multiSource.ElementAt(j).Name)
                            newCap[j] += e.cap;
                }

                Vertix s = new Vertix("S");
                s.Negative_degree = 0;
                nodes.AddFirst(s);
                for (int i = 0; i < c; i++)
                {
                    Edge e = new Edge();
                    e.Name="e"+i+1;
                    e.Bigen = s;
                    e.End = multiSource.ElementAt(i);
                    e.cap = newCap[i];
                    lines.AddFirst(e);
                }
            }
        }

        int min(int[] x)
        {
            int m=x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (m > x[i])
                    m = x[i];
            }
            return m;
        }

        public int Ford_Fulkerson(Vertix s, Vertix t)
        {
            int flow=0;
            int[] caps;
            int minCap;
            LinkedList<Edge> augPath;
            foreach (Edge l in lines)
            {
                l.flow = 0;
            }
            //while there exists an augmenting path, use it
            augPath = findAugmentedPath(s, t);
            while (Vs.ElementAt(Vs.Count-1).Name==t.Name)
            {
                caps=new int[augPath.Count];
                for (int i = 0; i < augPath.Count; i++)
                {
                    if (augPath.ElementAt(i).Forward)
                        caps[i] = augPath.ElementAt(i).cap - augPath.ElementAt(i).flow;
                    else
                        caps[i] = augPath.ElementAt(i).flow;
                }
                minCap = min(caps);
                foreach (Edge e in augPath)
                {
                    if (e.Forward)
                        e.flow += minCap;
                    else
                        e.flow -= minCap;
                }
                flow += minCap;
                augPath = findAugmentedPath(s, t);
            }

            return flow;
        }

        public LinkedList<Edge> findAugmentedPath(Vertix s, Vertix t)
        {
            Vs = new LinkedList<Vertix>();
            LinkedList<Edge> Q = new LinkedList<Edge>();
            Vs.AddLast(s);
            Vertix from=s;
            int iteration = 0;
            while (!Vs.Contains(t) && iteration<lines.Count)
            {
                
                foreach (Edge l in lines)
                {
                    if (l.Bigen.Name == from.Name && !Vs.Contains(l.End) && l.flow < l.cap)// !Vs.Contains(l.End) &&
                    {
                        //useAbleArcsCount++;
                        l.End.Prev = l.Bigen;
                        l.Forward = true;
                        l.Backward = false;
                        Vs.AddLast(l.End);
                        Q.AddLast(l);
                        if (l.End.Name == t.Name) break;
                    }
                    else if (l.End.Name == from.Name && !Vs.Contains(l.Bigen) && l.flow > 0)
                    {
                        if (l.End.Name == t.Name) break;

                        //useAbleArcsCount++;
                        l.Bigen.Prev = l.End;
                        l.Backward = true;
                        l.Forward = false;
                        Vs.AddLast(l.Bigen);
                        Q.AddLast(l);
                    }

                    if (from.Prev != null && iteration > from.Degree)
                   
                    {
                        from = from.Prev;
                        //Q.RemoveLast();                        
                    }
                    else
                    {
                        from = Vs.ElementAt(Vs.Count - 1);
                    }  
                }               
                iteration++;                
            }
            return Q;
}
       

        #region BFS&DFS_algorithems
             
        public LinkedList<Vertix> BFS(Vertix root)
        {
            LinkedList<Vertix> Closed = new LinkedList<Vertix>();
            LinkedList<Vertix> Open = new LinkedList<Vertix>();

            Open.AddLast(root);
            while (Open.Count != 0)
            {
                Vertix x = Open.ElementAt(0);
                Open.RemoveFirst();
                Closed.AddLast(x);
                for (int i = 0; i < Lines_num; i++)
                {
                    if (x.Name == lines.ElementAt(i).Bigen.Name)
                    {
                        Vertix y = lines.ElementAt(i).End;
                        if (!(Open.Contains(y)) && !(Closed.Contains(y)))
                            Open.AddLast(y);
                    }

                }
            }

            return Closed;
        }
        public LinkedList<Vertix> DFS(Vertix root)
        {
            LinkedList<Vertix> Closed = new LinkedList<Vertix>();
            LinkedList<Vertix> Open = new LinkedList<Vertix>();

            Open.AddFirst(root);
            while (Open.Count != 0)
            {
                Vertix x = Open.ElementAt(0);
                Open.RemoveFirst();
                Closed.AddLast(x);
                foreach(Edge l in lines)
                {
                    if (x.Name == l.Bigen.Name)
                    {
                        Vertix y = l.End;
                        if (!(Open.Contains(y)) && !(Closed.Contains(y)))
                            Open.AddFirst(y);
                    }

                }
            }

            return Closed;
        }

        #endregion


        /*//extra code
         *  public bool isAugmented(LinkedList<Edge> q)
        {
            int c = 0;
            if (q.ElementAt(0).Bigen.Name == nodes.ElementAt(0).Name && q.ElementAt(q.Count - 1).End.Name == nodes.ElementAt(nodes.Count - 1).Name)
            {
                foreach (Edge e in q)
                {
                    if (e.Forward && e.flow < e.cap)
                       c++;
                    else if (e.Backward && e.flow > 0) c++;
                }
            }
            if (c == q.Count) return true;
            else return false;

        }
         *        public int Ford_Fulkerson(Vertix s, Vertix t)
        {
            int flow=0;
            int[] caps;
            int minCap;
            LinkedList<Edge> augPath;
            foreach (Edge l in lines)
            {
                l.flow = 0;
                //l.RFlow = 0;
            }
            //while there exists an augmenting path, use it
            augPath = findAugmentedPath(s, t);
 
                
                //compute bottelneck capacity
                int bottleNeck = int.MaxValue;
                for(Vertix v=t;v!=s;v=ST(v))
                    bottleNeck=Math.Min(bottleNeck,pred[v].capRto(v));
                
                // augment flow
                for (Vertix v = t; v != s; v = ST(v))
                   pred[v].addflowRto(v,bottelNeck);
                
               // keep track of total flow sent from s to t
                value+=bottelNeck;
                 */
    }
}
