using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphTheoryProject
{
   public class Vertix
    {
        private string name;
        private int degree, positive_degree, negative_degree;
       
       private Vertix prev;

       // private string color;

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }       
              
        public int Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        public int Negative_degree
        {
            get { return negative_degree; }
            set { negative_degree = value; }
        }

        public int Positive_degree
        {
            get { return positive_degree; }
            set { positive_degree = value; }
        }

       /* public string Color
        {
            get { return color; }
            set { color = value; }
        }
        */
        public Vertix Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        #endregion

        public Vertix(string name)
        {
            this.name = name;
            this.degree = 0;
            this.negative_degree = 0;
            this.positive_degree = 0;
         //   this.color = "";
            this.prev = new Vertix();
         }

        public Vertix()
        {
            // TODO: Complete member initialization
        }

        
    }
}
