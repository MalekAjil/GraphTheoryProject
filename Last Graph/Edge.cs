using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphTheoryProject
{
    class Edge
    {

        private string name;
        private Vertix bigen, end;

        private int Cap, Flow;//,RFlow;
        private bool forward=false, backward=false;

        public Edge() { }
        public Edge(string Name, Vertix v, Vertix w, int cap)
        {
            this.name = Name;
            this.bigen = v;
            this.end = w;
            this.Cap = cap;
        }

        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Vertix Bigen
        {
            get { return bigen; }
            set { bigen = value; }
        }

        public Vertix End
        {
            get { return end; }
            set { end = value; }
        }

        public int cap
        {
            get { return Cap; }
            set { Cap = value; }
        }

        public int flow
        {
            get { return Flow; }
            set { Flow = value; }
        }

        public bool Forward
        {
            get { return forward; }
            set { forward = value; }
        }

        public bool Backward
        {
            get { return backward; }
            set { backward = value; }
        }

        #endregion

        /*//extra code
        public bool from(Vertix v)
        { 
        return this.bigen.Name==v.Name;
        }

        public Vertix other(Vertix v)
        {
            return from(v) ? this.end : this.bigen;
        }

        public int capRto(Vertix v)
        {
            return from(v) ? flow : cap - flow;
        }

        public void addFlowRto(Vertix v, int d)
        {
            this.flow += from(v) ? -d : d;
        }
        */
    }
}
